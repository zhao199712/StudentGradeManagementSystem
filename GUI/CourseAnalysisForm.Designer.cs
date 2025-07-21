namespace GUI
{
    partial class CourseAnalysisForm
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
            this.dataGridViewAnalysis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnalysis
            // 
            this.dataGridViewAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAnalysis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAnalysis.Name = "dataGridViewAnalysis";
            this.dataGridViewAnalysis.RowHeadersWidth = 82;
            this.dataGridViewAnalysis.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewAnalysis.TabIndex = 0;
            // 
            // CourseAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAnalysis);
            this.Name = "CourseAnalysisForm";
            this.Text = "Course Analysis";
            this.Load += new System.EventHandler(this.CourseAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnalysis;
    }
}
