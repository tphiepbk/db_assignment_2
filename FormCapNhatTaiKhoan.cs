using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_assignment_2
{
    public partial class FormCapNhatTaiKhoan : Form
    {
        string input_username;

        public FormCapNhatTaiKhoan(string input)
        {
            InitializeComponent();
            input_username = input;
            tb_username.Text = input_username;
        }

        private void gunaButton_done_Click(object sender, EventArgs e)
        {
            string input_password = "";
            string input_date = "";
            int input_admin = -1;

            if (cb_matkhau.Checked == true)
            {
                input_password = tb_matkhau.Text;
                if (input_password == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatePasswordQuery = "update Taikhoan set Matkhau = '{0}' where Username = '{1}'";
                    updatePasswordQuery = String.Format(updatePasswordQuery, input_password, input_username);

                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updatePasswordQuery, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

            if (cb_quantri.Checked == true)
            {
                if (gunaRadioButton_yes.Checked == true)
                {
                    input_admin = 1;
                }
                else
                {
                    input_admin = 0;
                }

                string updateAdminQuery = "update Taikhoan set Covaitroquantri = {0} where Username = '{1}'";
                updateAdminQuery = String.Format(updateAdminQuery, input_admin, input_username);

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateAdminQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }

            if (cb_ngaycap.Checked == true) 
            {
                input_date = dtp_ngaycap.Value.Date.ToShortDateString();

                string updateAdminQuery = "update Taikhoan set Ngaycap = convert(date, '{0}', 101) where Username = '{1}'";
                updateAdminQuery = String.Format(updateAdminQuery, input_date, input_username);

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateAdminQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            if (input_password != "" || cb_matkhau.Checked == false)
            {
                this.Close();
            }
        }

        private void gunaButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
