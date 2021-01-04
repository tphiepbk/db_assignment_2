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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void gunaButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton_done_Click(object sender, EventArgs e)
        {
            string input_username = tb_username.Text;
            string input_password = tb_matkhau.Text;
            string input_emp_id = tb_manhanvien.Text;
            string input_date = dtp_ngaycap.Value.Date.ToShortDateString();

            int input_admin = 0;
            if (gunaRadioButton_yes.Checked == true)
            {
                input_admin = 1;
            }
            else
            {
                input_admin = 0;
            }

            if (input_username == "" || input_password == "" || input_emp_id == "" || input_date == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string temp = "insert into Taikhoan values ('{0}', '{1}', {2}, convert(date, '{3}', 101), '{4}')";
                string insertQuery = String.Format(temp, input_username, input_password, input_admin, input_date, input_emp_id);

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                this.Close();
            }
        }
    }
}
