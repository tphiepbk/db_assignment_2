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
            pb_logo.Image = Properties.Resources._120x120hcmut;

            uc_khachhang.Visible = true;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;

        }
        private void gunaButton_khachhang_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = true;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_nhanvien_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = true;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_hoadon_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = true;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_chinhanh_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = true;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_sanpham_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = true;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_khuyenmai_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = true;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_taikhoan_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = true;
            uc_thekhachhang.Visible = false;
        }

        private void gunaButton_thekhachhang_Click(object sender, EventArgs e)
        {
            uc_khachhang.Visible = false;
            uc_hoadon.Visible = false;
            uc_chinhanh.Visible = false;
            uc_nhanvien.Visible = false;
            uc_sanpham.Visible = false;
            uc_khuyenmai.Visible = false;
            uc_taikhoan.Visible = false;
            uc_thekhachhang.Visible = true;
        }
    }
}
