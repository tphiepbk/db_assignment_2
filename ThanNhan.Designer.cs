
namespace db_assignment_2
{
    partial class ThanNhan
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
            this.getCountBtn = new System.Windows.Forms.Button();
            this.loaddataBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getCountBtn
            // 
            this.getCountBtn.Location = new System.Drawing.Point(864, 505);
            this.getCountBtn.Name = "getCountBtn";
            this.getCountBtn.Size = new System.Drawing.Size(75, 23);
            this.getCountBtn.TabIndex = 6;
            this.getCountBtn.Text = "Tổng số";
            this.getCountBtn.UseVisualStyleBackColor = true;
            this.getCountBtn.Click += new System.EventHandler(this.getCountBtn_Click);
            // 
            // loaddataBtn
            // 
            this.loaddataBtn.Location = new System.Drawing.Point(31, 505);
            this.loaddataBtn.Name = "loaddataBtn";
            this.loaddataBtn.Size = new System.Drawing.Size(75, 23);
            this.loaddataBtn.TabIndex = 5;
            this.loaddataBtn.Text = "Tải dữ liệu";
            this.loaddataBtn.UseVisualStyleBackColor = true;
            this.loaddataBtn.Click += new System.EventHandler(this.loaddataBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 456);
            this.dataGridView1.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(329, 505);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(251, 20);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Giao diện dùng để hiện thông tin thân nhân\r\n";
            // 
            // ThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.getCountBtn);
            this.Controls.Add(this.loaddataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThanNhan";
            this.Size = new System.Drawing.Size(971, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCountBtn;
        private System.Windows.Forms.Button loaddataBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
