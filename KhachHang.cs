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
using System.IO;

namespace db_assignment_2
{
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        // Connection string : usually create new class named "ConnectionString"

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

        private void loadData()
        {
            gunaDataGridView_main.DataSource = GetAllKhachHang();
            gunaDataGridView_main.AutoResizeColumnHeadersHeight();
            gunaDataGridView_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void getCount() 
        { 
            int count = 0;
            string queryGetCount = "select count(*) from Khachhang";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryGetCount, connection);
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            lb_count.Text = count.ToString();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var formThemKhachHang = new FormThemKhachHang();
            formThemKhachHang.Show();
        }

        private void gunaDataGridView_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = gunaDataGridView_main.CurrentRow.Index;
            tb_makhachhang.Text = gunaDataGridView_main.Rows[rowIndex].Cells[0].Value.ToString();
            tb_cmnd.Text = gunaDataGridView_main.Rows[rowIndex].Cells[1].Value.ToString();
            tb_gioitinh.Text = gunaDataGridView_main.Rows[rowIndex].Cells[2].Value.ToString();
            tb_tenkhachhang.Text = gunaDataGridView_main.Rows[rowIndex].Cells[3].Value.ToString() + " " + gunaDataGridView_main.Rows[rowIndex].Cells[4].Value.ToString() + " " + gunaDataGridView_main.Rows[rowIndex].Cells[5].Value.ToString();
            tb_ngaysinh.Text = gunaDataGridView_main.Rows[rowIndex].Cells[6].Value.ToString();
            tb_sdt.Text = gunaDataGridView_main.Rows[rowIndex].Cells[7].Value.ToString();
            tb_email.Text = gunaDataGridView_main.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void gunaButton_taidulieu_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
