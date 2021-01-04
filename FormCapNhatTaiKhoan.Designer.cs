
namespace db_assignment_2
{
    partial class FormCapNhatTaiKhoan
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
            this.gunaButton_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaButton_done = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.dtp_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.gunaRadioButton_no = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gunaRadioButton_yes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cb_matkhau = new System.Windows.Forms.CheckBox();
            this.cb_quantri = new System.Windows.Forms.CheckBox();
            this.cb_ngaycap = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.gunaButton_cancel.Location = new System.Drawing.Point(247, 151);
            this.gunaButton_cancel.Name = "gunaButton_cancel";
            this.gunaButton_cancel.ShadowDecoration.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.Size = new System.Drawing.Size(73, 35);
            this.gunaButton_cancel.TabIndex = 23;
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
            this.gunaButton_done.Location = new System.Drawing.Point(12, 151);
            this.gunaButton_done.Name = "gunaButton_done";
            this.gunaButton_done.ShadowDecoration.Parent = this.gunaButton_done;
            this.gunaButton_done.Size = new System.Drawing.Size(107, 35);
            this.gunaButton_done.TabIndex = 22;
            this.gunaButton_done.Text = "Hoàn tất";
            this.gunaButton_done.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton_done.Click += new System.EventHandler(this.gunaButton_done_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_ngaycap);
            this.groupBox2.Controls.Add(this.cb_quantri);
            this.groupBox2.Controls.Add(this.cb_matkhau);
            this.groupBox2.Controls.Add(this.tb_matkhau);
            this.groupBox2.Controls.Add(this.dtp_ngaycap);
            this.groupBox2.Controls.Add(this.gunaRadioButton_no);
            this.groupBox2.Controls.Add(this.gunaRadioButton_yes);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 113);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chỉnh sửa";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(99, 19);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(200, 20);
            this.tb_matkhau.TabIndex = 15;
            // 
            // dtp_ngaycap
            // 
            this.dtp_ngaycap.Location = new System.Drawing.Point(99, 74);
            this.dtp_ngaycap.Name = "dtp_ngaycap";
            this.dtp_ngaycap.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaycap.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Username :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(79, 6);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(200, 20);
            this.tb_username.TabIndex = 17;
            // 
            // gunaRadioButton_no
            // 
            this.gunaRadioButton_no.AutoSize = true;
            this.gunaRadioButton_no.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_no.CheckedState.BorderThickness = 0;
            this.gunaRadioButton_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_no.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaRadioButton_no.CheckedState.InnerOffset = -4;
            this.gunaRadioButton_no.Location = new System.Drawing.Point(152, 49);
            this.gunaRadioButton_no.Name = "gunaRadioButton_no";
            this.gunaRadioButton_no.Size = new System.Drawing.Size(56, 17);
            this.gunaRadioButton_no.TabIndex = 19;
            this.gunaRadioButton_no.Text = "Không";
            this.gunaRadioButton_no.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaRadioButton_no.UncheckedState.BorderThickness = 2;
            this.gunaRadioButton_no.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.gunaRadioButton_no.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // gunaRadioButton_yes
            // 
            this.gunaRadioButton_yes.AutoSize = true;
            this.gunaRadioButton_yes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_yes.CheckedState.BorderThickness = 0;
            this.gunaRadioButton_yes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaRadioButton_yes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gunaRadioButton_yes.CheckedState.InnerOffset = -4;
            this.gunaRadioButton_yes.Location = new System.Drawing.Point(99, 49);
            this.gunaRadioButton_yes.Name = "gunaRadioButton_yes";
            this.gunaRadioButton_yes.Size = new System.Drawing.Size(38, 17);
            this.gunaRadioButton_yes.TabIndex = 18;
            this.gunaRadioButton_yes.Text = "Có";
            this.gunaRadioButton_yes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaRadioButton_yes.UncheckedState.BorderThickness = 2;
            this.gunaRadioButton_yes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.gunaRadioButton_yes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb_matkhau
            // 
            this.cb_matkhau.AutoSize = true;
            this.cb_matkhau.Location = new System.Drawing.Point(6, 22);
            this.cb_matkhau.Name = "cb_matkhau";
            this.cb_matkhau.Size = new System.Drawing.Size(77, 17);
            this.cb_matkhau.TabIndex = 23;
            this.cb_matkhau.Text = "Mật khẩu :";
            this.cb_matkhau.UseVisualStyleBackColor = true;
            // 
            // cb_quantri
            // 
            this.cb_quantri.AutoSize = true;
            this.cb_quantri.Location = new System.Drawing.Point(6, 49);
            this.cb_quantri.Name = "cb_quantri";
            this.cb_quantri.Size = new System.Drawing.Size(69, 17);
            this.cb_quantri.TabIndex = 24;
            this.cb_quantri.Text = "Quản trị :";
            this.cb_quantri.UseVisualStyleBackColor = true;
            // 
            // cb_ngaycap
            // 
            this.cb_ngaycap.AutoSize = true;
            this.cb_ngaycap.Location = new System.Drawing.Point(6, 79);
            this.cb_ngaycap.Name = "cb_ngaycap";
            this.cb_ngaycap.Size = new System.Drawing.Size(78, 17);
            this.cb_ngaycap.TabIndex = 25;
            this.cb_ngaycap.Text = "Ngày cấp :";
            this.cb_ngaycap.UseVisualStyleBackColor = true;
            // 
            // FormCapNhatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 199);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gunaButton_cancel);
            this.Controls.Add(this.gunaButton_done);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label8);
            this.Name = "FormCapNhatTaiKhoan";
            this.Text = "Cập nhật tài khoản";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button gunaButton_cancel;
        private Guna.UI2.WinForms.Guna2Button gunaButton_done;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.DateTimePicker dtp_ngaycap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_username;
        private Guna.UI2.WinForms.Guna2RadioButton gunaRadioButton_no;
        private Guna.UI2.WinForms.Guna2RadioButton gunaRadioButton_yes;
        private System.Windows.Forms.CheckBox cb_ngaycap;
        private System.Windows.Forms.CheckBox cb_quantri;
        private System.Windows.Forms.CheckBox cb_matkhau;
    }
}