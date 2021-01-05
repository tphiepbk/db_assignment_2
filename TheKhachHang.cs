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
    public partial class TheKhachHang : UserControl
    {
        public TheKhachHang()
        {
            InitializeComponent();
        }

        private void gb_thongtinkhachhang_Enter(object sender, EventArgs e)
        {

        }

        DataTable GetAllTheKhachHang()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "select * from TheKhachhang";

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

        DataTable GetAllKetQuaTimKiem(string query)
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";

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
            gunaDataGridView_TheKhachHang.DataSource = GetAllTheKhachHang();
            gunaDataGridView_TheKhachHang.AutoResizeColumnHeadersHeight();
            gunaDataGridView_TheKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void getCount()
        {
            int count = 0;
            string queryGetCount = "select count(*) from TheKhachhang";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryGetCount, connection);
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            lb_count.Text = count.ToString();
        }

        private void TheKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void gunaDataGridView_TheKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = gunaDataGridView_TheKhachHang.CurrentRow.Index;
            tb_mathe.Text = gunaDataGridView_TheKhachHang.Rows[rowIndex].Cells[0].Value.ToString();
            tb_diemtichluy.Text = gunaDataGridView_TheKhachHang.Rows[rowIndex].Cells[1].Value.ToString();
            tb_makhachhang.Text = gunaDataGridView_TheKhachHang.Rows[rowIndex].Cells[2].Value.ToString();
            tb_machinhanh.Text = gunaDataGridView_TheKhachHang.Rows[rowIndex].Cells[3].Value.ToString();
            tb_ngaycapthe.Text = gunaDataGridView_TheKhachHang.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void gunaButton_themthekhachhang_Click(object sender, EventArgs e)
        {
            string queryThemTheKhachHang = "";

            if (tb_diemtichluy.Text != "")
                queryThemTheKhachHang = "INSERT Thekhachhang(Mathe, Diemtichluy, Makhachhang, Machinhanh, Ngaycapthe) " +
                                            "VALUES (@Mathe, @Diemtichluy, @Makhachhang, @Machinhanh, @Ngaycapthe)";
            else queryThemTheKhachHang = "INSERT Thekhachhang(Mathe, Makhachhang, Machinhanh, Ngaycapthe) " +
                                           "VALUES (@Mathe, @Makhachhang, @Machinhanh, @Ngaycapthe)";

            string mathe = tb_mathe.Text;
            string diemtichluy = tb_diemtichluy.Text;
            string makhachhang = tb_makhachhang.Text;
            string machinhanh = tb_machinhanh.Text;
            string ngaycapthe = tb_ngaycapthe.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryThemTheKhachHang, connection))
                {
                    command.Parameters.AddWithValue("@Mathe", tb_mathe.Text);
                    command.Parameters.AddWithValue("@Diemtichluy", tb_diemtichluy.Text);
                    command.Parameters.AddWithValue("@Makhachhang", tb_makhachhang.Text);
                    command.Parameters.AddWithValue("@Machinhanh", tb_machinhanh.Text);
                    command.Parameters.AddWithValue("@Ngaycapthe", tb_ngaycapthe.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    loadData();
                    getCount();
                }
            }
        }

        private void gunaButtonLoadData_Click(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void gunaButton_xoathekhachhang_Click(object sender, EventArgs e)
        {
            string queryXoaTheKhachHang = "DELETE FROM Thekhachhang WHERE Mathe = @Mathe";

            string mathe = tb_mathe.Text;
            string diemtichluy = tb_diemtichluy.Text;
            string makhachhang = tb_makhachhang.Text;
            string machinhanh = tb_machinhanh.Text;
            string ngaycapthe = tb_ngaycapthe.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryXoaTheKhachHang, connection))
                {
                    command.Parameters.AddWithValue("@Mathe", tb_mathe.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error deleting data from Database!");
                    loadData();
                    getCount();
                }
            }
        }

        private void gunaButton_suathekhachhang_Click(object sender, EventArgs e)
        {
            string querySuaTheKhachHang = "UPDATE Thekhachhang SET Diemtichluy = @Diemtichluy WHERE Mathe = @Mathe";

            string mathe = tb_mathe.Text;
            string diemtichluy = tb_diemtichluy.Text;
            string makhachhang = tb_makhachhang.Text;
            string machinhanh = tb_machinhanh.Text;
            string ngaycapthe = tb_ngaycapthe.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(querySuaTheKhachHang, connection))
                {
                    command.Parameters.AddWithValue("@Mathe", tb_mathe.Text);
                    command.Parameters.AddWithValue("@Diemtichluy", tb_diemtichluy.Text);
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error update data for Database!");
                    loadData();
                    getCount();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton_timthekhachhang_Click(object sender, EventArgs e)
        {
            string mathe = tb_mathe1.Text;
            string diemtichluy = tb_diemtichluy1.Text;
            string makhachhang = tb_makhachhang1.Text;
            string machinhanh = tb_machinhanh1.Text;
            string ngaycapthe = tb_ngaycapthe1.Text;

            string queryTimTheKhachHang = "";

            if (mathe != "")
                queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Mathe = @Mathe";
            else if (makhachhang != "")
                queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Makhachhang = @Makhachhang";
            else if (diemtichluy != "")
            {
                if (machinhanh != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Diemtichluy = @Diemtichluy AND Machinhanh = @Machinhanh";
                else if (ngaycapthe != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Diemtichluy = @Diemtichluy AND Mgaycapthe = @Ngaycapthe";
                else
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Diemtichluy = @Diemtichluy";
            }
            else if (machinhanh != "")
            {
                if (diemtichluy != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Machinhanh = @Machinhanh AND Diemtichluy = @Diemtichluy";
                else if (ngaycapthe != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Machinhanh = @Machinhanh AND Ngaycapthe = @Ngaycapthe";
                else
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Machinhanh = @Machinhanh";
            }
            else if (ngaycapthe != "")
            {
                if (diemtichluy != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Ngaycapthe = @Ngaycapthe AND Diemtichluy = @Diemtichluy";
                else if (machinhanh != "")
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Machinhanh = @Machinhanh AND Ngaycapthe = @Ngaycapthe";
                else
                    queryTimTheKhachHang = "SELECT * FROM Thekhachhang WHERE Ngaycapthe = @Ngaycapthe";
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryTimTheKhachHang, connection))
                {
                    command.Parameters.AddWithValue("@Mathe", tb_mathe1.Text);
                    command.Parameters.AddWithValue("@Diemtichluy", tb_diemtichluy1.Text);
                    command.Parameters.AddWithValue("@Makhachhang", tb_makhachhang1.Text);
                    command.Parameters.AddWithValue("@Machinhanh", tb_machinhanh1.Text);
                    command.Parameters.AddWithValue("@Ngaycapthe", tb_ngaycapthe1.Text);


                    DataTable data = new DataTable();

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    connection.Close();

                    gunaDataGridView_TheKhachHang.DataSource = data;
                    gunaDataGridView_TheKhachHang.AutoResizeColumnHeadersHeight();
                    gunaDataGridView_TheKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    getCount();

                    //connection.Open();
                    //int result = command.ExecuteNonQuery();

                    //// Check Error
                    //if (result < 0)
                    //    Console.WriteLine("Error inserting data into Database!");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Thekhachhang JOIN Loaithe ON Thekhachhang.Mathe = Loaithe.Mathe";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mathe", tb_mathe1.Text);
                    command.Parameters.AddWithValue("@Diemtichluy", tb_diemtichluy1.Text);
                    command.Parameters.AddWithValue("@Makhachhang", tb_makhachhang1.Text);
                    command.Parameters.AddWithValue("@Machinhanh", tb_machinhanh1.Text);
                    command.Parameters.AddWithValue("@Ngaycapthe", tb_ngaycapthe1.Text);


                    DataTable data = new DataTable();

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    connection.Close();

                    gunaDataGridView_TheKhachHang.DataSource = data;
                    gunaDataGridView_TheKhachHang.AutoResizeColumnHeadersHeight();
                    gunaDataGridView_TheKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    getCount();

                    //connection.Open();
                    //int result = command.ExecuteNonQuery();

                    //// Check Error
                    //if (result < 0)
                    //    Console.WriteLine("Error inserting data into Database!");
                }
            }
        }
    }
}



