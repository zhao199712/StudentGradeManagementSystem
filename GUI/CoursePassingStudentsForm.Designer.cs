namespace GUI
{
    partial class CoursePassingStudentsForm
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
            this.dataGridViewPassingStudents = new System.Windows.Forms.DataGridView();
            this.lblPassingCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassingStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassingStudents
            // 
            this.dataGridViewPassingStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassingStudents.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewPassingStudents.Name = "dataGridViewPassingStudents";
            this.dataGridViewPassingStudents.RowHeadersWidth = 82;
            this.dataGridViewPassingStudents.Size = new System.Drawing.Size(776, 398);
            this.dataGridViewPassingStudents.TabIndex = 0;
            // 
            // lblPassingCount
            // 
            this.lblPassingCount.AutoSize = true;
            this.lblPassingCount.Location = new System.Drawing.Point(12, 12);
            this.lblPassingCount.Name = "lblPassingCount";
            this.lblPassingCount.Size = new System.Drawing.Size(104, 18);
            this.lblPassingCount.TabIndex = 1;
            this.lblPassingCount.Text = "總通過人數: 0";
            // 
            // CoursePassingStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassingCount);
            this.Controls.Add(this.dataGridViewPassingStudents);
            this.Name = "CoursePassingStudentsForm";
            this.Text = "課程及格學生";
            this.Load += new System.EventHandler(this.CoursePassingStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassingStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPassingStudents;
        private System.Windows.Forms.Label lblPassingCount;
    }
}
