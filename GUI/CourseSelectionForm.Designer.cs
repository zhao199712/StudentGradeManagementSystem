namespace GUI
{
    partial class CourseSelectionForm
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
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.button_SelectCourse = new System.Windows.Forms.Button();
            this.comboBox_GradingStrategy = new System.Windows.Forms.ComboBox();
            this.label_GradingStrategy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 82;
            this.dataGridViewCourses.Size = new System.Drawing.Size(600, 350);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // button_SelectCourse
            // 
            this.button_SelectCourse.Location = new System.Drawing.Point(630, 12);
            this.button_SelectCourse.Name = "button_SelectCourse";
            this.button_SelectCourse.Size = new System.Drawing.Size(150, 46);
            this.button_SelectCourse.TabIndex = 1;
            this.button_SelectCourse.Text = "選擇課程";
            this.button_SelectCourse.UseVisualStyleBackColor = true;
            this.button_SelectCourse.Click += new System.EventHandler(this.button_SelectCourse_Click);
            // 
            // comboBox_GradingStrategy
            // 
            this.comboBox_GradingStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GradingStrategy.FormattingEnabled = true;
            this.comboBox_GradingStrategy.Items.AddRange(new object[] {
            "traditional",
            "curved"});
            this.comboBox_GradingStrategy.Location = new System.Drawing.Point(630, 120);
            this.comboBox_GradingStrategy.Name = "comboBox_GradingStrategy";
            this.comboBox_GradingStrategy.Size = new System.Drawing.Size(150, 32);
            this.comboBox_GradingStrategy.TabIndex = 2;
            // 
            // label_GradingStrategy
            // 
            this.label_GradingStrategy.AutoSize = true;
            this.label_GradingStrategy.Location = new System.Drawing.Point(630, 90);
            this.label_GradingStrategy.Name = "label_GradingStrategy";
            this.label_GradingStrategy.Size = new System.Drawing.Size(129, 32);
            this.label_GradingStrategy.TabIndex = 3;
            // 
            // CourseSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_GradingStrategy);
            this.Controls.Add(this.comboBox_GradingStrategy);
            this.Controls.Add(this.button_SelectCourse);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "CourseSelectionForm";
            this.Text = "選擇課程";
            this.Load += new System.EventHandler(this.CourseSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button button_SelectCourse;
        private System.Windows.Forms.ComboBox comboBox_GradingStrategy;
        private System.Windows.Forms.Label label_GradingStrategy;
    }
}
