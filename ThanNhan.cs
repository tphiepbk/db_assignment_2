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
    public partial class ThanNhan : UserControl
    {
        public ThanNhan()
        {
            InitializeComponent();
        }
        DataSet GetAllThanNhan()
        {

            DataSet data = new DataSet();

            string query = "select * from ThanNhan";

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

        private void loaddataBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllThanNhan().Tables[0];
        }

        private void getCountBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            string queryGetCount = "select count(*) from Thannhan";
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
