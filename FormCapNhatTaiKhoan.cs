using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_assignment_2
{
    public partial class FormCapNhatTaiKhoan : Form
    {
        public FormCapNhatTaiKhoan()
        {
            InitializeComponent();
        }

        private void gunaButton_done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
