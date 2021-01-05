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

    public partial class KhachHang : UserControl
    {
        string connectstr = ConnectionString.connectionString; 
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectstr);
            connect.Open();
            show();
        }
        private void show()
        {

            string sql = "select * from Khachhang";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhachhang.ReadOnly = true;
            txtcmnd.ReadOnly = true;
            txtgioitinh.ReadOnly = true;
            txtho.ReadOnly = true;
            txtchulot.ReadOnly = true;
            txtten.ReadOnly = true;
            dtp.Enabled = false;

            txtdienthoai.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtsoluongnguoithan.ReadOnly = true;


            groupBox1.Text = "Thông tin chi tiết khách hàng";
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmakhachhang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtcmnd.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtgioitinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtho.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtchulot.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtten.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dtp.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtdienthoai.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtemail.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtsoluongnguoithan.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string sql = "select * from Khachhang where Makhachhang = '" + txtmakhachhang.Text + "'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
       
        private void btninsert_Click_1(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "insert into Khachhang values('" + txtmakhachhang.Text + "','" + txtcmnd.Text + "','" + txtgioitinh.Text + "','" + txtho.Text + "','" + txtchulot.Text + "','" + txtten.Text + "','" + dtp.Text + "','" + txtdienthoai.Text + "','" + txtemail.Text + "','" + txtsoluongnguoithan.Text +"')";

            command.ExecuteNonQuery();
            show();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "update Khachhang set" + " Gioitinh ='" + txtgioitinh.Text + "',Ho = '" + txtho.Text + "',Chulot='" + txtchulot.Text + "',Ten='" + txtten.Text + "',Ngaysinh= '" + dtp.Text + "',Dienthoai='" + txtdienthoai.Text + "',Email='" + txtemail.Text + "',Soluongnguoithan='" + txtsoluongnguoithan.Text +"' where Makhachhang = '" + txtmakhachhang.Text +  "'";
            command.ExecuteNonQuery();
            show();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "delete from Khachhang where Makhachhang = '" + txtmakhachhang.Text + "'";
            command.ExecuteNonQuery();
            show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectstr);
            string sql;
            if (txtmakhachhang.Text != "")
            {
                sql = "select * from Khachhang kh join Hoadon hd on kh.Makhachhang = hd.Makhachhang where kh.Makhachhang = '" + txtmakhachhang.Text + "'";
            }
            else
                sql = "select * from Khachhang , Hoadon";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connect); //bat dau truy van
            connect.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
      

        private void groupBox1_MouseCaptureChanged_1(object sender, EventArgs e)
        {

            txtmakhachhang.ReadOnly = false;
            txtcmnd.ReadOnly = false;
            txtgioitinh.ReadOnly = false;
            txtho.ReadOnly = false;
            txtchulot.ReadOnly = false;
            txtten.ReadOnly = false;
            dtp.Enabled = false;

            txtdienthoai.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtsoluongnguoithan.ReadOnly = false;
            //Text
            txtmakhachhang.Text = "";
            txtcmnd.Text = "";
            txtgioitinh.Text = "";
            txtho.Text = "";
            txtchulot.Text = "";
            txtten.Text = "";
            dtp.Text = "";

            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtsoluongnguoithan.Text = "";
            groupBox1.Text = "Nhập thông tin khách hàng";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
 
