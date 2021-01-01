
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // loaddataBtn
            // 
            this.loaddataBtn.Location = new System.Drawing.Point(27, 504);
            this.loaddataBtn.Name = "loaddataBtn";
            this.loaddataBtn.Size = new System.Drawing.Size(75, 23);
            this.loaddataBtn.TabIndex = 2;
            this.loaddataBtn.Text = "Load Data";
            this.loaddataBtn.UseVisualStyleBackColor = true;
            this.loaddataBtn.Click += new System.EventHandler(this.loaddataBtn_Click);
            // 
            // getCountBtn
            // 
            this.getCountBtn.Location = new System.Drawing.Point(860, 504);
            this.getCountBtn.Name = "getCountBtn";
            this.getCountBtn.Size = new System.Drawing.Size(75, 23);
            this.getCountBtn.TabIndex = 3;
            this.getCountBtn.Text = "Count";
            this.getCountBtn.UseVisualStyleBackColor = true;
            this.getCountBtn.Click += new System.EventHandler(this.getCountBtn_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getCountBtn);
            this.Controls.Add(this.loaddataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(971, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loaddataBtn;
        private System.Windows.Forms.Button getCountBtn;
    }
}
