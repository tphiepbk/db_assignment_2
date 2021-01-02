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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllKhachHang();
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            tb_makhachhang.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tb_cmnd.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            tb_gioitinh.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tb_tenkhachhang.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString()  + " " + dataGridView1.Rows[rowIndex].Cells[4].Value.ToString() + " " + dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            tb_ngaysinh.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            tb_email.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            var formThemKhachHang = new FormThemKhachHang();
            formThemKhachHang.Show();
        }
    }
}
