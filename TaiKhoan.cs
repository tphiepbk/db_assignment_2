﻿using System;
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
    public partial class TaiKhoan : UserControl
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        DataTable GetAllAccount()
        {

            DataTable data = new DataTable();

            string query = "select * from Taikhoan";

            // "using" keyword : when we done, it will be deleted
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        DataTable GetAllAdmin()
        {

            DataTable data = new DataTable();

            string query = "select Username from Taikhoan where Covaitroquantri = 1";

            // "using" keyword : when we done, it will be deleted
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }


        private void loadData()
        {
            gunaDataGridView_main.DataSource = GetAllAccount();
            gunaDataGridView_main.AutoResizeColumnHeadersHeight();
            gunaDataGridView_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gunaDataGridView_adminlist.DataSource = GetAllAdmin();
            gunaDataGridView_adminlist.AutoResizeColumnHeadersHeight();
            gunaDataGridView_adminlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void getCount()
        {
            int count = 0;
            string queryGetCount = "select count(*) from Taikhoan";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryGetCount, connection);
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            lb_count.Text = count.ToString();

            string queryGetAdminCount = "select count(*) from Taikhoan where Covaitroquantri = 1";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryGetAdminCount, connection);
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            lb_admin_count.Text = count.ToString();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void gunaDataGridView_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = gunaDataGridView_main.CurrentRow.Index;
            tb_username.Text = gunaDataGridView_main.Rows[rowIndex].Cells[0].Value.ToString();
            tb_matkhau.Text = gunaDataGridView_main.Rows[rowIndex].Cells[1].Value.ToString();

            string quantri= gunaDataGridView_main.Rows[rowIndex].Cells[2].Value.ToString();
            if (quantri == "True")
            {
                gunaRadioButton_quantri_yes.Checked = true;
                gunaRadioButton_quantri_no.Checked = false;
            }
            else
            { 
                gunaRadioButton_quantri_yes.Checked = false;
                gunaRadioButton_quantri_no.Checked = true;
            }

            string ngaycap = gunaDataGridView_main.Rows[rowIndex].Cells[3].Value.ToString();
            tb_ngaycap.Text = ngaycap;


            tb_manhanvien.Text = gunaDataGridView_main.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void gunaButton_themtaikhoan_Click(object sender, EventArgs e)
        {
            var f_themtaikhoan = new FormThemTaiKhoan();
            f_themtaikhoan.Show();
        }

        private void gunaButton_taidulieu_Click(object sender, EventArgs e)
        {
            loadData();
            getCount();
        }

        private void gunaButton_xoataikhoan_Click(object sender, EventArgs e)
        {
            int current_row_index = gunaDataGridView_main.CurrentCell.RowIndex;
            string current_username = gunaDataGridView_main.Rows[current_row_index].Cells[0].Value.ToString();

            string temp = "delete from Taikhoan where Username = '{0}'";
            string queryDeleteAccount = String.Format(temp, current_username);

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryDeleteAccount, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            loadData();
        }

        private void gunaButton_capnhattaikhoan_Click(object sender, EventArgs e)
        {
            int current_row_index = gunaDataGridView_main.CurrentCell.RowIndex;
            string current_username = gunaDataGridView_main.Rows[current_row_index].Cells[0].Value.ToString();

            var f_capnhattaikhoan = new FormCapNhatTaiKhoan(current_username);
            f_capnhattaikhoan.Show();
        }

        private void gunaButton_filter_Click(object sender, EventArgs e)
        {
            var f_filter = new FormLocTaiKhoan();
            f_filter.Show();
        }
    }
}
