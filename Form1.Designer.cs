
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loaddataBtn = new System.Windows.Forms.Button();
            this.getCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // loaddataBtn
            // 
            this.loaddataBtn.Location = new System.Drawing.Point(840, 451);
            this.loaddataBtn.Name = "loaddataBtn";
            this.loaddataBtn.Size = new System.Drawing.Size(75, 23);
            this.loaddataBtn.TabIndex = 1;
            this.loaddataBtn.Text = "Load Data";
            this.loaddataBtn.UseVisualStyleBackColor = true;
            this.loaddataBtn.Click += new System.EventHandler(this.loaddataBtn_Click);
            // 
            // getCount
            // 
            this.getCount.Location = new System.Drawing.Point(981, 451);
            this.getCount.Name = "getCount";
            this.getCount.Size = new System.Drawing.Size(75, 23);
            this.getCount.TabIndex = 2;
            this.getCount.Text = "Count";
            this.getCount.UseVisualStyleBackColor = true;
            this.getCount.Click += new System.EventHandler(this.getCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 568);
            this.Controls.Add(this.getCount);
            this.Controls.Add(this.loaddataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loaddataBtn;
        private System.Windows.Forms.Button getCount;
    }
}

