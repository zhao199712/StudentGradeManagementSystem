namespace GUI
{
    partial class MainForm
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
			components = new System.ComponentModel.Container();
			studentViewModelBindingSource = new BindingSource(components);
			studentViewModelBindingSource1 = new BindingSource(components);
			studentRepositoryBindingSource = new BindingSource(components);
			button_update = new Button();
			button_insertStu = new Button();
			button_deleteStu = new Button();
			displayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			classNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			button_Refresh = new Button();
			button_editStu = new Button();
			button_ManageCourses = new Button();
			button_AnalyzeGrades = new Button();
			((System.ComponentModel.ISupportInitialize)studentViewModelBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)studentViewModelBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)studentRepositoryBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// studentViewModelBindingSource
			// 
			studentViewModelBindingSource.DataSource = typeof(StudentGradeManagementSystem.Presentation.ViewModels.StudentViewModel);
			studentViewModelBindingSource.CurrentChanged += studentViewModelBindingSource_CurrentChanged;
			// 
			// studentViewModelBindingSource1
			// 
			studentViewModelBindingSource1.DataSource = typeof(StudentGradeManagementSystem.Presentation.ViewModels.StudentViewModel);
			// 
			// studentRepositoryBindingSource
			// 
			studentRepositoryBindingSource.DataSource = typeof(StudentGradeManagementSystem.Data.Repositories.StudentRepository);
			studentRepositoryBindingSource.CurrentChanged += studentRepositoryBindingSource_CurrentChanged;
			// 
			// button_update
			// 
			button_update.Location = new Point(1300, 300);
			button_update.Name = "button_update";
			button_update.Size = new Size(150, 46);
			button_update.TabIndex = 0;
			button_update.Text = "顯示成績";
			button_update.UseVisualStyleBackColor = true;
			button_update.Click += button_update_Click;
			// 
			// button_insertStu
			// 
			button_insertStu.Location = new Point(1300, 100);
			button_insertStu.Name = "button_insertStu";
			button_insertStu.Size = new Size(150, 46);
			button_insertStu.TabIndex = 1;
			button_insertStu.Text = "新增學生";
			button_insertStu.UseVisualStyleBackColor = true;
			button_insertStu.Click += button_insert_Click;
			// 
			// button_deleteStu
			// 
			button_deleteStu.Location = new Point(1300, 220);
			button_deleteStu.Name = "button_deleteStu";
			button_deleteStu.Size = new Size(150, 46);
			button_deleteStu.TabIndex = 2;
			button_deleteStu.Text = "刪除學生";
			button_deleteStu.UseVisualStyleBackColor = true;
			button_deleteStu.Click += button_deleteStu_Click;
			// 
			// displayDataGridViewTextBoxColumn
			// 
			displayDataGridViewTextBoxColumn.MinimumWidth = 10;
			displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
			displayDataGridViewTextBoxColumn.Width = 200;
			// 
			// classNameDataGridViewTextBoxColumn
			// 
			classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
			classNameDataGridViewTextBoxColumn.HeaderText = "班級";
			classNameDataGridViewTextBoxColumn.MinimumWidth = 10;
			classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
			classNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			nameDataGridViewTextBoxColumn.MinimumWidth = 10;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "學號";
			idDataGridViewTextBoxColumn.MinimumWidth = 10;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.Width = 200;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, classNameDataGridViewTextBoxColumn, displayDataGridViewTextBoxColumn });
			dataGridView1.DataSource = studentViewModelBindingSource1;
			dataGridView1.Location = new Point(30, 100);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 82;
			dataGridView1.Size = new Size(1200, 600);
			dataGridView1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 50);
			label1.Name = "label1";
			label1.Size = new Size(289, 32);
			label1.TabIndex = 4;
			label1.Text = "以下是你現有的同學資訊";
			label1.Click += label1_Click;
			// 
			// button_Refresh
			// 
			button_Refresh.Location = new Point(1300, 40);
			button_Refresh.Name = "button_Refresh";
			button_Refresh.Size = new Size(150, 46);
			button_Refresh.TabIndex = 5;
			button_Refresh.Text = "重新整理";
			button_Refresh.UseVisualStyleBackColor = true;
			button_Refresh.Click += button_Refresh_Click;
			// 
			// button_editStu
			// 
			button_editStu.Location = new Point(1300, 160);
			button_editStu.Name = "button_editStu";
			button_editStu.Size = new Size(150, 46);
			button_editStu.TabIndex = 9;
			button_editStu.Text = "修改學生";
			button_editStu.UseVisualStyleBackColor = true;
			button_editStu.Click += button_editStu_Click;
			// 
			// button_ManageCourses
			// 
			button_ManageCourses.Location = new Point(1300, 550);
			button_ManageCourses.Name = "button_ManageCourses";
			button_ManageCourses.Size = new Size(150, 46);
			button_ManageCourses.TabIndex = 10;
			button_ManageCourses.Text = "管理課程";
			button_ManageCourses.UseVisualStyleBackColor = true;
			button_ManageCourses.Click += button_ManageCourses_Click;
			// 
			// button_AnalyzeGrades
			// 
			button_AnalyzeGrades.Location = new Point(1300, 360);
			button_AnalyzeGrades.Name = "button_AnalyzeGrades";
			button_AnalyzeGrades.Size = new Size(150, 46);
			button_AnalyzeGrades.TabIndex = 6;
			button_AnalyzeGrades.Text = "成績分析";
			button_AnalyzeGrades.UseVisualStyleBackColor = true;
			button_AnalyzeGrades.Click += button_AnalyzeGrades_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1738, 750);
			Controls.Add(button_AnalyzeGrades);
			Controls.Add(button_ManageCourses);
			Controls.Add(button_editStu);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(button_deleteStu);
			Controls.Add(button_insertStu);
			Controls.Add(button_update);
			Name = "MainForm";
			Text = "學生成績管理";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)studentViewModelBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)studentViewModelBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)studentRepositoryBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource studentViewModelBindingSource;
        private System.Windows.Forms.BindingSource studentViewModelBindingSource1;
        private System.Windows.Forms.BindingSource studentRepositoryBindingSource;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insertStu;
        private System.Windows.Forms.Button button_deleteStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_editStu;
        private System.Windows.Forms.Button button_ManageCourses;
        private System.Windows.Forms.Button button_AnalyzeGrades;
    }
}