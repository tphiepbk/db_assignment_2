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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;

            pb_logo.Image = Properties.Resources._120x120hcmut;
        }
        private void gunaButton_khachhang_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = true;
        }
    }
}
