
namespace db_assignment_2
{
    partial class FormThemTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_manhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaRadioButton_yes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gunaRadioButton_no = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.gunaButton_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaButton_done = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(96, 6);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(200, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(96, 32);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(200, 20);
            this.tb_matkhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            // 
            // tb_manhanvien
            // 
            this.tb_manhanvien.Location = new System.Drawing.Point(96, 118);
            this.tb_manhanvien.Name = "tb_manhanvien";
            this.tb_manhanvien.Size = new System.Drawing.Size(200, 20);
            this.tb_manhanvien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên :";
            // 
            // gunaRadioButton_yes
            // 
            this.gunaRadioButton_yes.AutoSize = true;
            this.gunaRadioButton_yes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_yes.CheckedState.BorderThickness = 0;
            this.gunaRadioButton_yes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_yes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaRadioButton_yes.CheckedState.InnerOffset = -4;
            this.gunaRadioButton_yes.Location = new System.Drawing.Point(96, 62);
            this.gunaRadioButton_yes.Name = "gunaRadioButton_yes";
            this.gunaRadioButton_yes.Size = new System.Drawing.Size(38, 17);
            this.gunaRadioButton_yes.TabIndex = 6;
            this.gunaRadioButton_yes.Text = "Có";
            this.gunaRadioButton_yes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaRadioButton_yes.UncheckedState.BorderThickness = 2;
            this.gunaRadioButton_yes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.gunaRadioButton_yes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // gunaRadioButton_no
            // 
            this.gunaRadioButton_no.AutoSize = true;
            this.gunaRadioButton_no.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_no.CheckedState.BorderThickness = 0;
            this.gunaRadioButton_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_no.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaRadioButton_no.CheckedState.InnerOffset = -4;
            this.gunaRadioButton_no.Location = new System.Drawing.Point(149, 62);
            this.gunaRadioButton_no.Name = "gunaRadioButton_no";
            this.gunaRadioButton_no.Size = new System.Drawing.Size(56, 17);
            this.gunaRadioButton_no.TabIndex = 7;
            this.gunaRadioButton_no.Text = "Không";
            this.gunaRadioButton_no.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaRadioButton_no.UncheckedState.BorderThickness = 2;
            this.gunaRadioButton_no.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.gunaRadioButton_no.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quản trị :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày cấp :";
            // 
            // dtp_ngaycap
            // 
            this.dtp_ngaycap.Location = new System.Drawing.Point(96, 87);
            this.dtp_ngaycap.Name = "dtp_ngaycap";
            this.dtp_ngaycap.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaycap.TabIndex = 11;
            // 
            // gunaButton_cancel
            // 
            this.gunaButton_cancel.CheckedState.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.CustomImages.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.gunaButton_cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton_cancel.ForeColor = System.Drawing.Color.White;
            this.gunaButton_cancel.HoverState.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.Image = global::db_assignment_2.Properties.Resources.fluent_delete;
            this.gunaButton_cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaButton_cancel.Location = new System.Drawing.Point(211, 163);
            this.gunaButton_cancel.Name = "gunaButton_cancel";
            this.gunaButton_cancel.ShadowDecoration.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.Size = new System.Drawing.Size(85, 35);
            this.gunaButton_cancel.TabIndex = 21;
            this.gunaButton_cancel.Text = "Huỷ";
            this.gunaButton_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton_cancel.Click += new System.EventHandler(this.gunaButton_cancel_Click);
            // 
            // gunaButton_done
            // 
            this.gunaButton_done.CheckedState.Parent = this.gunaButton_done;
            this.gunaButton_done.CustomImages.Parent = this.gunaButton_done;
            this.gunaButton_done.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.gunaButton_done.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton_done.ForeColor = System.Drawing.Color.White;
            this.gunaButton_done.HoverState.Parent = this.gunaButton_done;
            this.gunaButton_done.Image = global::db_assignment_2.Properties.Resources.fluent_insert;
            this.gunaButton_done.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaButton_done.Location = new System.Drawing.Point(12, 163);
            this.gunaButton_done.Name = "gunaButton_done";
            this.gunaButton_done.ShadowDecoration.Parent = this.gunaButton_done;
            this.gunaButton_done.Size = new System.Drawing.Size(85, 35);
            this.gunaButton_done.TabIndex = 20;
            this.gunaButton_done.Text = "Thêm";
            this.gunaButton_done.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton_done.Click += new System.EventHandler(this.gunaButton_done_Click);
            // 
            // FormThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 210);
            this.Controls.Add(this.gunaButton_cancel);
            this.Controls.Add(this.gunaButton_done);
            this.Controls.Add(this.dtp_ngaycap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaRadioButton_no);
            this.Controls.Add(this.gunaRadioButton_yes);
            this.Controls.Add(this.tb_manhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemTaiKhoan";
            this.Text = "Thêm tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_manhanvien;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RadioButton gunaRadioButton_yes;
        private Guna.UI2.WinForms.Guna2RadioButton gunaRadioButton_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngaycap;
        private Guna.UI2.WinForms.Guna2Button gunaButton_cancel;
        private Guna.UI2.WinForms.Guna2Button gunaButton_done;
    }
}