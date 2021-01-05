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
    public partial class KhuyenMai : UserControl
    {
        string Makhuyenmai;
     
        public KhuyenMai()
        {
            InitializeComponent();

            btnkhuyenmai_Click(this, new EventArgs());


        }
        DataTable GetAllKhuyenmai()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "select * from Khuyenmai";

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
            guna_khuyenmai.DataSource = GetAllKhuyenmai();
            guna_khuyenmai.AutoResizeColumnHeadersHeight();
            guna_khuyenmai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Khuyenmai_Load(object sender, EventArgs e)
        {
            loadData();
            //getCount();
        }

        private void guna_khuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = guna_khuyenmai.CurrentRow.Index;
            tb_makhuyenmai.Text = guna_khuyenmai.Rows[rowIndex].Cells[0].Value.ToString();
            datetime_ngaybatdau.Value = Convert.ToDateTime(guna_khuyenmai.Rows[rowIndex].Cells[1].Value.ToString());
            datetime_ngayketthuc.Value = Convert.ToDateTime(guna_khuyenmai.Rows[rowIndex].Cells[2].Value.ToString());
            cbloaikhuyenmai.Text = guna_khuyenmai.Rows[rowIndex].Cells[3].Value.ToString();
            

            this.Makhuyenmai = tb_makhuyenmai.Text;
        }

        private void guna_quatang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = guna_khuyenmai.CurrentRow.Index;
            qt_makhyenmai.Text = guna_khuyenmai.Rows[rowIndex].Cells[0].Value.ToString();
            qt_masanpham.Text = guna_khuyenmai.Rows[rowIndex].Cells[2].Value.ToString();
            


            this.Makhuyenmai = qt_makhyenmai.Text;
        }


        private void guna_giamgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = guna_khuyenmai.CurrentRow.Index;
            dis_maquatang.Text = guna_khuyenmai.Rows[rowIndex].Cells[0].Value.ToString();
            dis_giatri.Text = guna_khuyenmai.Rows[rowIndex].Cells[1].Value.ToString();

            this.Makhuyenmai = dis_maquatang.Text;
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("Makhuyenmai", "\'"+tb_makhuyenmai.Text+ "\'");
            MyAdd.Add("Ngaybatdau", "\'" + datetime_ngaybatdau.Value.ToString("MM/dd/yyyy HH:mm") + "\'");
            MyAdd.Add("Ngayketthuc", "\'"+ datetime_ngayketthuc.Value.ToString("MM/dd/yyyy HH:mm")+ "\'");
            MyAdd.Add("Loaikhuyenmai", "\'"+ cbloaikhuyenmai.Text + "\'");
       


            string que_str = @"insert into Khuyenmai values (" + MyAdd["Makhuyenmai"] + "," + MyAdd["Ngaybatdau"] + "," + MyAdd["Ngayketthuc"] + "," + MyAdd["Loaikhuyenmai"] + ")";
            mod_query_string(que_str);
        }

        private void mod_query_string(string que_str)
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

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            string que_str = @"delete from Khuyenmai where Makhuyenmai=" + "\'" + tb_makhuyenmai.Text + "\'";
            mod_query_string(que_str);
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("Makhuyenmai", "\'" + tb_makhuyenmai.Text + "\'");
            MyAdd.Add("Ngaybatdau", "\'" + datetime_ngaybatdau.Value.ToString("MM/dd/yyyy HH:mm") + "\'");
            MyAdd.Add("Ngayketthuc", "\'" + datetime_ngayketthuc.Value.ToString("MM/dd/yyyy HH:mm") + "\'");
            MyAdd.Add("Loaikhuyenmai", "\'" + cbloaikhuyenmai.Text + "\'");

            string que_str = "set ";
            foreach (KeyValuePair<string, string> ele in MyAdd)
            {
                que_str += " " + ele.Key + " = " + ele.Value + ", ";
            }
            que_str = que_str.Substring(0, que_str.Length - 2);
            que_str += " where Makhuyenmai= " + "\'" + Makhuyenmai + "\'";

            que_str = "UPDATE" + " " + "Khuyenmai" + " " + que_str;
            mod_query_string(que_str);
        }

        DataTable GetAllQT()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "SELECT Makhuyenmai as 'Mã khuyến mãi', Ten as 'Sản phẩm áp được áp dụng',Sanphamtang.SPID FROM Sanphamtang INNER JOIN Sanpham on Sanphamtang.SPID =Sanpham.SPID ORDER BY  Sanphamtang.SPID ASC";

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

        private void loadDataQT()
        {
            guna_khuyenmai.DataSource = GetAllQT();
            guna_khuyenmai.AutoResizeColumnHeadersHeight();
            guna_khuyenmai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnquatang_Click(object sender, EventArgs e)
        {
            visibleTTKM(false);
            visibleTTQT(true);
            visibleTTGG(false);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_khuyenmai_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_quatang_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_giamgia_CellContentClick);
            this.guna_khuyenmai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_quatang_CellContentClick);
            loadDataQT();
        }




        DataTable GetAllGG()
        {

            DataTable data = new DataTable();

            //string ID = "PV1012";
            string query = "SELECT Makhuyenmai as 'Mã khuyến mãi', Giatri as 'Số tiền được giảm' FROM Magiamgia ORDER BY Giatri ASC  ";

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
        private void loadDataGG()
        {
            guna_khuyenmai.DataSource = GetAllGG();
            guna_khuyenmai.AutoResizeColumnHeadersHeight();
            guna_khuyenmai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btngiamgia_Click(object sender, EventArgs e)
        {
            visibleTTKM(false);
            visibleTTQT(false);
            visibleTTGG(true);

            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_khuyenmai_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_quatang_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_giamgia_CellContentClick);
            this.guna_khuyenmai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_quatang_CellContentClick);
            loadDataGG();
        }

        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
            visibleTTKM(true);
            visibleTTQT(false);
            visibleTTGG(false);

            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_khuyenmai_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_quatang_CellContentClick);
            this.guna_khuyenmai.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_giamgia_CellContentClick);
            this.guna_khuyenmai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_khuyenmai_CellContentClick);

            loadData();
        }

        private void visibleTTKM(bool check)
        {
            if (check) {
                gb_thongtinkhuyenmai.Visible=true;
                Addbtn.Visible=true;
                XoaBtn.Visible=true;
                ModBtn.Visible=true;
            }
            else
            {
                gb_thongtinkhuyenmai.Visible = false;
                Addbtn.Visible = false;
                XoaBtn.Visible = false;
                ModBtn.Visible = false;
            }
        }

        private void visibleTTQT(bool check)
        {
            if (check)
            {
                gB_qt.Visible = true;
                qt_add.Visible = true;
                qt_del.Visible = true;
                qt_mod.Visible = true;
            }
            else
            {
                gB_qt.Visible = false;
                qt_add.Visible = false;
                qt_del.Visible = false;
                qt_mod.Visible = false;
            }
        }

        private void visibleTTGG(bool check)
        {
            if (check)
            {
                gB_giamgia.Visible = true;
                dis_add.Visible = true;
                dis_del.Visible = true;
                dis_mod.Visible = true;
            }
            else
            {
                gB_giamgia.Visible = false;
                dis_add.Visible = false;
                dis_del.Visible = false;
                dis_mod.Visible = false;
            }
        }

        private void qt_add_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("SPID",  qt_masanpham.Text );
            MyAdd.Add("Makhuyenmai", "\'" + qt_makhyenmai.Text + "\'");
 
            string que_str = @"insert into Sanphamtang values (" + MyAdd["SPID"] + "," + MyAdd["Makhuyenmai"] + ")";
            mod_query_string(que_str);
        }

        private void qt_del_Click(object sender, EventArgs e)
        {
            string que_str = @"delete from Sanphamtang where Makhuyenmai=" + "\'" + qt_makhyenmai.Text + "\'";
            mod_query_string(que_str);
        }

        private void qt_mod_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("SPID", qt_masanpham.Text);
            MyAdd.Add("Makhuyenmai", "\'" + qt_makhyenmai.Text + "\'");


            string que_str = "set ";
            foreach (KeyValuePair<string, string> ele in MyAdd)
            {
                que_str += " " + ele.Key + " = " + ele.Value + ", ";
            }
            que_str = que_str.Substring(0, que_str.Length - 2);
            que_str += " where Makhuyenmai= " + "\'" + Makhuyenmai + "\'";

            que_str = "UPDATE" + " " + "Sanphamtang" + " " + que_str;
            mod_query_string(que_str);
        }

        private void dis_add_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("Makhuyenmai", "\'" + dis_maquatang.Text + "\'");
            MyAdd.Add("Giatri", dis_giatri.Text);

            string que_str = @"insert into Magiamgia values (" + MyAdd["Makhuyenmai"] + "," + MyAdd["Giatri"] + ")";
            mod_query_string(que_str);
        }

        private void dis_del_Click(object sender, EventArgs e)
        {
            string que_str = @"delete from Magiamgia where Makhuyenmai=" + "\'" + dis_maquatang.Text + "\'";
            mod_query_string(que_str);
        }

        private void dis_mod_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MyAdd = new Dictionary<string, string>();

            MyAdd.Add("Makhuyenmai", "\'" + dis_maquatang.Text + "\'");
            MyAdd.Add("Giatri", dis_giatri.Text);


            string que_str = "set ";
            foreach (KeyValuePair<string, string> ele in MyAdd)
            {
                que_str += " " + ele.Key + " = " + ele.Value + ", ";
            }
            que_str = que_str.Substring(0, que_str.Length - 2);
            que_str += " where Makhuyenmai= " + "\'" + Makhuyenmai + "\'";

            que_str = "UPDATE" + " " + "Magiamgia" + " " + que_str;
            mod_query_string(que_str);
        }
    }

    


}
