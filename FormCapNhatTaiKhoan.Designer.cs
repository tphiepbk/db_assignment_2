
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
            this.tc_updatemethod = new System.Windows.Forms.TabControl();
            this.tp_username = new System.Windows.Forms.TabPage();
            this.tp_emp_id = new System.Windows.Forms.TabPage();
            this.gunaButton_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaButton_done = new Guna.UI2.WinForms.Guna2Button();
            this.tc_updatemethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_updatemethod
            // 
            this.tc_updatemethod.Controls.Add(this.tp_username);
            this.tc_updatemethod.Controls.Add(this.tp_emp_id);
            this.tc_updatemethod.Location = new System.Drawing.Point(12, 12);
            this.tc_updatemethod.Name = "tc_updatemethod";
            this.tc_updatemethod.SelectedIndex = 0;
            this.tc_updatemethod.Size = new System.Drawing.Size(517, 349);
            this.tc_updatemethod.TabIndex = 0;
            // 
            // tp_username
            // 
            this.tp_username.Location = new System.Drawing.Point(4, 22);
            this.tp_username.Name = "tp_username";
            this.tp_username.Padding = new System.Windows.Forms.Padding(3);
            this.tp_username.Size = new System.Drawing.Size(509, 323);
            this.tp_username.TabIndex = 0;
            this.tp_username.Text = "Username";
            this.tp_username.UseVisualStyleBackColor = true;
            // 
            // tp_emp_id
            // 
            this.tp_emp_id.Location = new System.Drawing.Point(4, 22);
            this.tp_emp_id.Name = "tp_emp_id";
            this.tp_emp_id.Padding = new System.Windows.Forms.Padding(3);
            this.tp_emp_id.Size = new System.Drawing.Size(509, 323);
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
            this.gunaButton_cancel.Location = new System.Drawing.Point(209, 367);
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
            this.gunaButton_done.Location = new System.Drawing.Point(12, 367);
            this.gunaButton_done.Name = "gunaButton_done";
            this.gunaButton_done.ShadowDecoration.Parent = this.gunaButton_done;
            this.gunaButton_done.Size = new System.Drawing.Size(107, 35);
            this.gunaButton_done.TabIndex = 22;
            this.gunaButton_done.Text = "Hoàn tất";
            this.gunaButton_done.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton_done.Click += new System.EventHandler(this.gunaButton_done_Click);
            // 
            // FormCapNhatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.gunaButton_cancel);
            this.Controls.Add(this.gunaButton_done);
            this.Controls.Add(this.tc_updatemethod);
            this.Name = "FormCapNhatTaiKhoan";
            this.Text = "Cập nhật tài khoản";
            this.tc_updatemethod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_updatemethod;
        private System.Windows.Forms.TabPage tp_username;
        private System.Windows.Forms.TabPage tp_emp_id;
        private Guna.UI2.WinForms.Guna2Button gunaButton_cancel;
        private Guna.UI2.WinForms.Guna2Button gunaButton_done;
    }
}