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
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string makhachhang = tb_makhachhang.Text;
            string cmnd = tb_cmnd.Text;
            string gioitinh = tb_gioitinh.Text;
            string ho = tb_ho.Text;

            string chulot = tb_chulot.Text;
            string ten = tb_ten.Text;
            string ngaysinh = dtp_ngaysinh.Value.Date.ToShortDateString();

            string sdt = tb_sdt.Text;
            string email = tb_email.Text;

            string temp = "insert into Khachhang values ('{0}', {1}, N'{2}', N'{3}', N'{4}', N'{5}', convert(date, '{6}', 101), '{7}', '{8}')";
            string insertQuery = String.Format(temp, makhachhang, cmnd, gioitinh, ho, chulot, ten, ngaysinh, sdt, email);

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
