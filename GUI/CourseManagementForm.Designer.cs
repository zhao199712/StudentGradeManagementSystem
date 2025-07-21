namespace GUI
{
    partial class CourseManagementForm
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
            this.dataGridView_Courses = new System.Windows.Forms.DataGridView();
            this.button_AddCourse = new System.Windows.Forms.Button();
            this.button_EditCourse = new System.Windows.Forms.Button();
            this.button_DeleteCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Courses
            // 
            this.dataGridView_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Courses.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Courses.Name = "dataGridView_Courses";
            this.dataGridView_Courses.RowHeadersWidth = 82;
            this.dataGridView_Courses.Size = new System.Drawing.Size(800, 400);
            this.dataGridView_Courses.TabIndex = 0;
            // 
            // button_AddCourse
            // 
            this.button_AddCourse.Location = new System.Drawing.Point(830, 12);
            this.button_AddCourse.Name = "button_AddCourse";
            this.button_AddCourse.Size = new System.Drawing.Size(150, 46);
            this.button_AddCourse.TabIndex = 1;
            this.button_AddCourse.Text = "新增課程";
            this.button_AddCourse.UseVisualStyleBackColor = true;
            this.button_AddCourse.Click += new System.EventHandler(this.button_AddCourse_Click);
            // 
            // button_EditCourse
            // 
            this.button_EditCourse.Location = new System.Drawing.Point(830, 70);
            this.button_EditCourse.Name = "button_EditCourse";
            this.button_EditCourse.Size = new System.Drawing.Size(150, 46);
            this.button_EditCourse.TabIndex = 2;
            this.button_EditCourse.Text = "編輯課程";
            this.button_EditCourse.UseVisualStyleBackColor = true;
            this.button_EditCourse.Click += new System.EventHandler(this.button_EditCourse_Click);
            // 
            // button_DeleteCourse
            // 
            this.button_DeleteCourse.Location = new System.Drawing.Point(830, 128);
            this.button_DeleteCourse.Name = "button_DeleteCourse";
            this.button_DeleteCourse.Size = new System.Drawing.Size(150, 46);
            this.button_DeleteCourse.TabIndex = 3;
            this.button_DeleteCourse.Text = "刪除課程";
            this.button_DeleteCourse.UseVisualStyleBackColor = true;
            this.button_DeleteCourse.Click += new System.EventHandler(this.button_DeleteCourse_Click);
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.button_DeleteCourse);
            this.Controls.Add(this.button_EditCourse);
            this.Controls.Add(this.button_AddCourse);
            this.Controls.Add(this.dataGridView_Courses);
            this.Name = "CourseManagementForm";
            this.Text = "課程管理";
            this.Load += new System.EventHandler(this.CourseManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Courses;
        private System.Windows.Forms.Button button_AddCourse;
        private System.Windows.Forms.Button button_EditCourse;
        private System.Windows.Forms.Button button_DeleteCourse;
    }
}