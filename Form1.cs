using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace db_assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
        }
        DataTable GetAllKhachHang()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "select * from Khachhang";

            // "using" keyword : when we done, it will be deleted
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@id", ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        private void btnThanNhan_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton_khachhang_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = true;
        }

        private void gunaButton_thannhan_Click(object sender, EventArgs e)
        {

        }
    }
}
