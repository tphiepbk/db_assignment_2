
namespace db_assignment_2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanNhan = new System.Windows.Forms.Button();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.khachHang1 = new db_assignment_2.KhachHang();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Location = new System.Drawing.Point(32, 26);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(115, 52);
            this.btnKhachhang.TabIndex = 4;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.khachHang1);
            this.panel1.Location = new System.Drawing.Point(176, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 570);
            this.panel1.TabIndex = 5;
            // 
            // btnThanNhan
            // 
            this.btnThanNhan.Location = new System.Drawing.Point(32, 99);
            this.btnThanNhan.Name = "btnThanNhan";
            this.btnThanNhan.Size = new System.Drawing.Size(115, 52);
            this.btnThanNhan.TabIndex = 6;
            this.btnThanNhan.Text = "Thân nhân";
            this.btnThanNhan.UseVisualStyleBackColor = true;
            this.btnThanNhan.Click += new System.EventHandler(this.btnThanNhan_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(21, 174);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(140, 67);
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // khachHang1
            // 
            this.khachHang1.Location = new System.Drawing.Point(18, 14);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1285, 542);
            this.khachHang1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 588);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btnThanNhan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKhachhang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanNhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private KhachHang khachHang1;
    }
}

