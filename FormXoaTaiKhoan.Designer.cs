
namespace db_assignment_2
{
    partial class FormXoaTaiKhoan
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
            this.tc_deletemethod = new System.Windows.Forms.TabControl();
            this.tp_username = new System.Windows.Forms.TabPage();
            this.tp_emp_id = new System.Windows.Forms.TabPage();
            this.gunaButton_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaButton_done = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_manhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_deletemethod.SuspendLayout();
            this.tp_username.SuspendLayout();
            this.tp_emp_id.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_deletemethod
            // 
            this.tc_deletemethod.Controls.Add(this.tp_username);
            this.tc_deletemethod.Controls.Add(this.tp_emp_id);
            this.tc_deletemethod.Location = new System.Drawing.Point(12, 12);
            this.tc_deletemethod.Name = "tc_deletemethod";
            this.tc_deletemethod.SelectedIndex = 0;
            this.tc_deletemethod.Size = new System.Drawing.Size(294, 281);
            this.tc_deletemethod.TabIndex = 0;
            // 
            // tp_username
            // 
            this.tp_username.Controls.Add(this.tb_username);
            this.tp_username.Controls.Add(this.label1);
            this.tp_username.Location = new System.Drawing.Point(4, 22);
            this.tp_username.Name = "tp_username";
            this.tp_username.Padding = new System.Windows.Forms.Padding(3);
            this.tp_username.Size = new System.Drawing.Size(286, 255);
            this.tp_username.TabIndex = 0;
            this.tp_username.Text = "Username";
            this.tp_username.UseVisualStyleBackColor = true;
            // 
            // tp_emp_id
            // 
            this.tp_emp_id.Controls.Add(this.tb_manhanvien);
            this.tp_emp_id.Controls.Add(this.label2);
            this.tp_emp_id.Location = new System.Drawing.Point(4, 22);
            this.tp_emp_id.Name = "tp_emp_id";
            this.tp_emp_id.Padding = new System.Windows.Forms.Padding(3);
            this.tp_emp_id.Size = new System.Drawing.Size(286, 255);
            this.tp_emp_id.TabIndex = 1;
            this.tp_emp_id.Text = "Mã nhân viên";
            this.tp_emp_id.UseVisualStyleBackColor = true;
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
            this.gunaButton_cancel.Location = new System.Drawing.Point(233, 299);
            this.gunaButton_cancel.Name = "gunaButton_cancel";
            this.gunaButton_cancel.ShadowDecoration.Parent = this.gunaButton_cancel;
            this.gunaButton_cancel.Size = new System.Drawing.Size(73, 35);
            this.gunaButton_cancel.TabIndex = 25;
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
            this.gunaButton_done.Location = new System.Drawing.Point(12, 299);
            this.gunaButton_done.Name = "gunaButton_done";
            this.gunaButton_done.ShadowDecoration.Parent = this.gunaButton_done;
            this.gunaButton_done.Size = new System.Drawing.Size(107, 35);
            this.gunaButton_done.TabIndex = 24;
            this.gunaButton_done.Text = "Hoàn tất";
            this.gunaButton_done.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton_done.Click += new System.EventHandler(this.gunaButton_done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(73, 6);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(138, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_manhanvien
            // 
            this.tb_manhanvien.Location = new System.Drawing.Point(90, 6);
            this.tb_manhanvien.Name = "tb_manhanvien";
            this.tb_manhanvien.Size = new System.Drawing.Size(143, 20);
            this.tb_manhanvien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên :";
            // 
            // FormXoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 349);
            this.Controls.Add(this.gunaButton_cancel);
            this.Controls.Add(this.gunaButton_done);
            this.Controls.Add(this.tc_deletemethod);
            this.Name = "FormXoaTaiKhoan";
            this.Text = "Xoá tài khoản";
            this.tc_deletemethod.ResumeLayout(false);
            this.tp_username.ResumeLayout(false);
            this.tp_username.PerformLayout();
            this.tp_emp_id.ResumeLayout(false);
            this.tp_emp_id.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_deletemethod;
        private System.Windows.Forms.TabPage tp_username;
        private System.Windows.Forms.TabPage tp_emp_id;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_manhanvien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button gunaButton_cancel;
        private Guna.UI2.WinForms.Guna2Button gunaButton_done;
    }
}