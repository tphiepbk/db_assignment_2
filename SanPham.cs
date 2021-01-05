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
    public partial class SanPham : UserControl
    {

        int SPID;
        public SanPham()
        {
            InitializeComponent();
        }

        DataTable GetAllSanpham()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "select * from Sanpham order by SPID ASC";

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
            gunaDataGridView_main.DataSource = GetAllSanpham();
            gunaDataGridView_main.AutoResizeColumnHeadersHeight();
            gunaDataGridView_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            loadData();
            //getCount();
        }

        private void gunaDataGridView_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = gunaDataGridView_main.CurrentRow.Index;
            
            tb_masanpham.Text = gunaDataGridView_main.Rows[rowIndex].Cells[0].Value.ToString();
            tb_tensanpham.Text = gunaDataGridView_main.Rows[rowIndex].Cells[1].Value.ToString();
            tb_soluong.Text = gunaDataGridView_main.Rows[rowIndex].Cells[2].Value.ToString();
            tb_dongia.Text = gunaDataGridView_main.Rows[rowIndex].Cells[3].Value.ToString();
            tb_mahoadon.Text = gunaDataGridView_main.Rows[rowIndex].Cells[4].Value.ToString();
            cBx_loai.Text = gunaDataGridView_main.Rows[rowIndex].Cells[5].Value.ToString();

            this.SPID = Int32.Parse(tb_masanpham.Text);


        }

        private void gunaButton_themkhachhang_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("SPID", tb_masanpham.Text);
            MyAdd.Add("Ten", "\'"+tb_tensanpham.Text+ "\'");
            MyAdd.Add("Soluong", tb_soluong.Text);
            MyAdd.Add("Dongia", tb_dongia.Text);
            MyAdd.Add("Mahoadon", "\'"+tb_mahoadon.Text+ "\'");
            MyAdd.Add("Loai", "\'"+cBx_loai.Text+ "\'");

            string que_str = "set ";
            foreach (KeyValuePair<string, string> ele in MyAdd)
            {
                que_str += " " + ele.Key + " = " + ele.Value + ", ";
            }
            que_str = que_str.Substring(0, que_str.Length - 2);
            que_str += " where SPID= " + this.SPID;

            que_str = "UPDATE" + " " + "Sanpham" + " " + que_str;
            mod_query_string( que_str);
        }

        private void  mod_query_string( string que_str)
        {

            



            Console.WriteLine(que_str);
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
            connection.Open();
            SqlCommand sqlcom = new SqlCommand(que_str, connection);
            try
            {
                sqlcom.ExecuteNonQuery();
                
                
                
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return;
            }
            MessageBox.Show("Thao tác thành công");
            connection.Close();
            this.loadData();


        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("SPID", tb_masanpham.Text);
            MyAdd.Add("Ten", "\'" + tb_tensanpham.Text + "\'");
            MyAdd.Add("Soluong", tb_soluong.Text);
            MyAdd.Add("Dongia", tb_dongia.Text);
            MyAdd.Add("Mahoadon", "\'" + tb_mahoadon.Text + "\'");
            MyAdd.Add("Loai", "\'" + cBx_loai.Text + "\'");


            string que_str = @"insert into Sanpham values (" + MyAdd["SPID"] + "," + MyAdd["Ten"] + "," + MyAdd["Soluong"] +","+ MyAdd["Dongia"] + "," + MyAdd["Mahoadon"] + "," + MyAdd["Loai"]+")";
            mod_query_string(que_str);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string que_str = @"delete from Sanpham where SPID=" + tb_masanpham.Text;
            mod_query_string(que_str);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("SPID", tb_masanpham.Text);
            MyAdd.Add("Ten", "\'" + tb_tensanpham.Text + "\'");
            MyAdd.Add("Soluong", tb_soluong.Text);
            MyAdd.Add("Dongia", tb_dongia.Text);
            MyAdd.Add("Mahoadon", "\'" + tb_mahoadon.Text + "\'");
            MyAdd.Add("Loai", "\'" + cBx_loai.Text + "\'");

            string que_str = "set ";
            foreach (KeyValuePair<string, string> ele in MyAdd)
            {
                que_str += " " + ele.Key + " = " + ele.Value + ", ";
            }
            que_str = que_str.Substring(0, que_str.Length - 2);
            que_str += " where SPID= " + this.SPID;

            que_str = "UPDATE" + " " + "Sanpham" + " " + que_str;
            mod_query_string(que_str);
        }
    }

}
