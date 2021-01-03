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
    public partial class Nhanvien : UserControl
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //connect to dtb
        //string connectstr = @"Data Source=LAPTOP-0H50M25G;Initial Catalog=as2;Integrated Security=True";
        string connectstr = ConnectionString.connectionString;
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectstr);
            connect.Open();
            show();
        }
        private void show()
        {

            string sql = "select * from Nhanvien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.ReadOnly = true;
            txtaddr.ReadOnly = true;
            txtphone.ReadOnly = true;
            txtname.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtmachinhanh.ReadOnly = true;
            cbosex.Enabled = false;
            dtimebirth.Enabled = false;
            dtimestart.Enabled = false;
            groupBox1.Text = "Thông tin chi tiết nhân viên";
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbosex.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtaddr.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtphone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtname.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtimebirth.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtmachinhanh.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dtimestart.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();


        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "insert into Nhanvien values('" + txtid.Text + "','" + cbosex.Text + "','" + txtaddr.Text + "','" + txtphone.Text + "','" + txtname.Text + "','" + dtimebirth.Text + "','" + txtemail.Text + "','" + txtmachinhanh.Text + "','" + dtimestart.Text + "')";
            command.ExecuteNonQuery();
            show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "update Nhanvien set" + " Gioitinh = '" + cbosex.Text + "',Diachi= '" + txtaddr.Text + "',Dienthoai='" + txtphone.Text + "',Hoten = '" + txtname.Text + "',Ngaysinh='" + dtimebirth.Text + "',Email='" + txtemail.Text + "',Machinhanh = '" + txtmachinhanh.Text + "',Ngaybatdau='" + dtimestart.Text + "' where NhanvienID = '" + txtid.Text + "'";
            command.ExecuteNonQuery();
            show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "delete from Nhanvien where NhanvienID = '" + txtid.Text + "'";
            command.ExecuteNonQuery();
            show();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.ReadOnly = false;
            txtaddr.ReadOnly = false;
            txtphone.ReadOnly = false;
            txtname.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtmachinhanh.ReadOnly = false;
            cbosex.Enabled = true;
            dtimebirth.Enabled = true;
            dtimestart.Enabled = true;
            //Text
            cbosex.Text = "";
            dtimestart.Text = "";
            dtimebirth.Text = "";
            txtid.Text = "";
            txtaddr.Text = "";
            txtphone.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtmachinhanh.Text = "";
            groupBox1.Text = "Nhập thông tin nhân viên";
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string sql = "select * from Nhanvien where NhanvienID = '" + txtid.Text + "'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectstr);
            connect.Open();
            show();
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = false;
            txtaddr.ReadOnly = false;
            txtphone.ReadOnly = false;
            txtname.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtmachinhanh.ReadOnly = false;
            cbosex.Enabled = true;
            dtimebirth.Enabled = true;
            dtimestart.Enabled = true;
            //Text
            cbosex.Text = "";
            dtimestart.Text = "";
            dtimebirth.Text = "";
            txtid.Text = "";
            txtaddr.Text = "";
            txtphone.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtmachinhanh.Text = "";
            groupBox1.Text = "Nhập thông tin nhân viên";
        }

        private void btnbranch_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectstr);
            string sql;
            if (txtmachinhanh.Text != "")
            {
                sql = "select * from Nhanvien nv join Chinhanh cn on nv.Machinhanh = cn.Machinhanh where nv.Machinhanh = '" + txtmachinhanh.Text + "'";
            }
            else
                sql = "select * from Nhanvien , Chinhanh";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            connect.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
    }
}
