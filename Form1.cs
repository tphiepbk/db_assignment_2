﻿using System;
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

        private void loaddataBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllKhachHang().Tables[0];
        }

        // Connection string : usually create new class named "ConnectionString"

        DataSet GetAllKhachHang()
        {

            DataSet data = new DataSet();

            string ID = "PV1012";
            string query  = "select * from Khachhang where Makhachhang = @id";

            // "using" keyword : when we done, it will be deleted
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) 
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        private void getCount_Click(object sender, EventArgs e)
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
            MessageBox.Show("Total : " + count.ToString());
        }
    }
}
