
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
            this.loaddataBtn = new System.Windows.Forms.Button();
            this.getCountBtn = new System.Windows.Forms.Button();
            this.gb_thongtinkhachhang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_makhachhang = new System.Windows.Forms.TextBox();
            this.tb_tenkhachhang = new System.Windows.Forms.TextBox();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_ngaysinh = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_thongtinkhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loaddataBtn
            // 
            this.loaddataBtn.Location = new System.Drawing.Point(27, 504);
            this.loaddataBtn.Name = "loaddataBtn";
            this.loaddataBtn.Size = new System.Drawing.Size(75, 23);
            this.loaddataBtn.TabIndex = 2;
            this.loaddataBtn.Text = "Tải dữ liệu";
            this.loaddataBtn.UseVisualStyleBackColor = true;
            this.loaddataBtn.Click += new System.EventHandler(this.loaddataBtn_Click);
            // 
            // getCountBtn
            // 
            this.getCountBtn.Location = new System.Drawing.Point(860, 504);
            this.getCountBtn.Name = "getCountBtn";
            this.getCountBtn.Size = new System.Drawing.Size(75, 23);
            this.getCountBtn.TabIndex = 3;
            this.getCountBtn.Text = "Tổng số";
            this.getCountBtn.UseVisualStyleBackColor = true;
            this.getCountBtn.Click += new System.EventHandler(this.getCountBtn_Click);
            // 
            // gb_thongtinkhachhang
            // 
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
            this.gb_thongtinkhachhang.Location = new System.Drawing.Point(958, 22);
            this.gb_thongtinkhachhang.Name = "gb_thongtinkhachhang";
            this.gb_thongtinkhachhang.Size = new System.Drawing.Size(371, 505);
            this.gb_thongtinkhachhang.TabIndex = 4;
            this.gb_thongtinkhachhang.TabStop = false;
            this.gb_thongtinkhachhang.Text = "Thông tin khách hàng";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số CMND : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email : ";
            // 
            // tb_makhachhang
            // 
            this.tb_makhachhang.Location = new System.Drawing.Point(103, 33);
            this.tb_makhachhang.Name = "tb_makhachhang";
            this.tb_makhachhang.Size = new System.Drawing.Size(262, 20);
            this.tb_makhachhang.TabIndex = 6;
            // 
            // tb_tenkhachhang
            // 
            this.tb_tenkhachhang.Location = new System.Drawing.Point(103, 59);
            this.tb_tenkhachhang.Name = "tb_tenkhachhang";
            this.tb_tenkhachhang.Size = new System.Drawing.Size(262, 20);
            this.tb_tenkhachhang.TabIndex = 7;
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Location = new System.Drawing.Point(103, 85);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(262, 20);
            this.tb_cmnd.TabIndex = 8;
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.Location = new System.Drawing.Point(103, 111);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(262, 20);
            this.tb_ngaysinh.TabIndex = 9;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(103, 137);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(262, 20);
            this.tb_sdt.TabIndex = 10;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(103, 163);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(262, 20);
            this.tb_email.TabIndex = 11;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_thongtinkhachhang);
            this.Controls.Add(this.getCountBtn);
            this.Controls.Add(this.loaddataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1354, 608);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_thongtinkhachhang.ResumeLayout(false);
            this.gb_thongtinkhachhang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loaddataBtn;
        private System.Windows.Forms.Button getCountBtn;
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
    }
}
