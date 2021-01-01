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

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            khachHangUserControl.Visible = true;
            thanNhanUserControl.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khachHangUserControl.Visible = false;
            thanNhanUserControl.Visible = false;
        }

        private void btnThanNhan_Click(object sender, EventArgs e)
        {
            khachHangUserControl.Visible = false;
            thanNhanUserControl.Visible = true;
        }
    }
}
