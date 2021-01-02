
namespace db_assignment_2
{
    partial class KhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_thongtinkhachhang = new System.Windows.Forms.GroupBox();
            this.tb_gioitinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ngaysinh = new System.Windows.Forms.TextBox();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_tenkhachhang = new System.Windows.Forms.TextBox();
            this.tb_makhachhang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.btn_themkhachhang = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_thongtinkhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // gb_thongtinkhachhang
            // 
            this.gb_thongtinkhachhang.Controls.Add(this.tb_gioitinh);
            this.gb_thongtinkhachhang.Controls.Add(this.label7);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_email);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_sdt);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_ngaysinh);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_cmnd);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_tenkhachhang);
            this.gb_thongtinkhachhang.Controls.Add(this.tb_makhachhang);
            this.gb_thongtinkhachhang.Controls.Add(this.label6);
            this.gb_thongtinkhachhang.Controls.Add(this.label5);
            this.gb_thongtinkhachhang.Controls.Add(this.label4);
            this.gb_thongtinkhachhang.Controls.Add(this.label3);
            this.gb_thongtinkhachhang.Controls.Add(this.label2);
            this.gb_thongtinkhachhang.Controls.Add(this.label1);
            this.gb_thongtinkhachhang.Location = new System.Drawing.Point(837, 13);
            this.gb_thongtinkhachhang.Name = "gb_thongtinkhachhang";
            this.gb_thongtinkhachhang.Size = new System.Drawing.Size(314, 230);
            this.gb_thongtinkhachhang.TabIndex = 4;
            this.gb_thongtinkhachhang.TabStop = false;
            this.gb_thongtinkhachhang.Text = "Thông tin khách hàng";
            // 
            // tb_gioitinh
            // 
            this.tb_gioitinh.Location = new System.Drawing.Point(103, 85);
            this.tb_gioitinh.Name = "tb_gioitinh";
            this.tb_gioitinh.Size = new System.Drawing.Size(196, 20);
            this.tb_gioitinh.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới tính :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(103, 189);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(196, 20);
            this.tb_email.TabIndex = 11;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(103, 163);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(196, 20);
            this.tb_sdt.TabIndex = 10;
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.Location = new System.Drawing.Point(103, 137);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(196, 20);
            this.tb_ngaysinh.TabIndex = 9;
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Location = new System.Drawing.Point(103, 111);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(196, 20);
            this.tb_cmnd.TabIndex = 8;
            // 
            // tb_tenkhachhang
            // 
            this.tb_tenkhachhang.Location = new System.Drawing.Point(103, 59);
            this.tb_tenkhachhang.Name = "tb_tenkhachhang";
            this.tb_tenkhachhang.Size = new System.Drawing.Size(196, 20);
            this.tb_tenkhachhang.TabIndex = 7;
            // 
            // tb_makhachhang
            // 
            this.tb_makhachhang.Location = new System.Drawing.Point(103, 33);
            this.tb_makhachhang.Name = "tb_makhachhang";
            this.tb_makhachhang.Size = new System.Drawing.Size(196, 20);
            this.tb_makhachhang.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số CMND : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng số hàng hiển thị : ";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(126, 483);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(13, 13);
            this.lb_count.TabIndex = 6;
            this.lb_count.Text = "0";
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.Location = new System.Drawing.Point(837, 249);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(120, 23);
            this.btn_themkhachhang.TabIndex = 7;
            this.btn_themkhachhang.Text = "Thêm khách hàng";
            this.btn_themkhachhang.UseVisualStyleBackColor = true;
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themkhachhang_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(898, 337);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(13, 13);
            this.testLabel.TabIndex = 8;
            this.testLabel.Text = "0";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.btn_themkhachhang);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gb_thongtinkhachhang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1163, 506);
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_thongtinkhachhang.ResumeLayout(false);
            this.gb_thongtinkhachhang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_thongtinkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_ngaysinh;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.TextBox tb_tenkhachhang;
        private System.Windows.Forms.TextBox tb_makhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button btn_themkhachhang;
        private System.Windows.Forms.Label testLabel;
    }
}
