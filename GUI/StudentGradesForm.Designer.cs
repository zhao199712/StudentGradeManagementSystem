namespace GUI
{
    partial class StudentGradesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.button_AddGrade = new System.Windows.Forms.Button();
            this.button_EditGrade = new System.Windows.Forms.Button();
            this.button_DeleteGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersWidth = 82;
            this.dataGridViewGrades.Size = new System.Drawing.Size(600, 400);
            this.dataGridViewGrades.TabIndex = 0;
            // 
            // button_AddGrade
            // 
            this.button_AddGrade.Location = new System.Drawing.Point(630, 12);
            this.button_AddGrade.Name = "button_AddGrade";
            this.button_AddGrade.Size = new System.Drawing.Size(150, 46);
            this.button_AddGrade.TabIndex = 1;
            this.button_AddGrade.Text = "新增成績";
            this.button_AddGrade.UseVisualStyleBackColor = true;
            this.button_AddGrade.Click += new System.EventHandler(this.button_AddGrade_Click);
            // 
            // button_EditGrade
            // 
            this.button_EditGrade.Location = new System.Drawing.Point(630, 70);
            this.button_EditGrade.Name = "button_EditGrade";
            this.button_EditGrade.Size = new System.Drawing.Size(150, 46);
            this.button_EditGrade.TabIndex = 2;
            this.button_EditGrade.Text = "編輯成績";
            this.button_EditGrade.UseVisualStyleBackColor = true;
            this.button_EditGrade.Click += new System.EventHandler(this.button_EditGrade_Click);
            // 
            // button_DeleteGrade
            // 
            this.button_DeleteGrade.Location = new System.Drawing.Point(630, 128);
            this.button_DeleteGrade.Name = "button_DeleteGrade";
            this.button_DeleteGrade.Size = new System.Drawing.Size(150, 46);
            this.button_DeleteGrade.TabIndex = 3;
            this.button_DeleteGrade.Text = "刪除成績";
            this.button_DeleteGrade.UseVisualStyleBackColor = true;
            this.button_DeleteGrade.Click += new System.EventHandler(this.button_DeleteGrade_Click); 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DeleteGrade);
            this.Controls.Add(this.button_EditGrade);
            this.Controls.Add(this.button_AddGrade);
            this.Controls.Add(this.dataGridViewGrades);
            this.Name = "StudentGradesForm";
            this.Text = "學生成績";
            this.Load += new System.EventHandler(this.StudentGradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Button button_AddGrade;
        private System.Windows.Forms.Button button_EditGrade;
        private System.Windows.Forms.Button button_DeleteGrade;
    }
}