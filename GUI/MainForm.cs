using StudentGradeManagementSystem.Domain.Logic;
using System;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using StudentGradeManagementSystem.Presentation.Mappers;
using StudentGradeManagementSystem.Presentation.ViewModels;
using StudentModel = StudentGradeManagementSystem.Domain.POCO.Student;

namespace GUI
{
    public partial class MainForm : Form
    {
        private readonly IStudentService _studentService;

        public MainForm(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            var students = _studentService.GetAll().Select(s => s.ToViewModel());
            studentViewModelBindingSource1.DataSource = students;
        }

        private void studentRepositoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void studentViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            var form = new AddStudentForm(_studentService);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents(); // 新增學生後重新載入學生列表
            }
        }

        private void button_deleteStu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as StudentViewModel;

                    if (selectedStudent != null)
                    {
                        DialogResult result = MessageBox.Show($"確定要刪除學生 {selectedStudent.Name} 嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _studentService.Delete(selectedStudent.Id);
                            MessageBox.Show("學生刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudents(); // 重新載入學生列表
                        }
                    }
                }
                else
                {
                    MessageBox.Show("請選取要刪除的學生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除學生失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button_editStu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as StudentViewModel;
                if (selectedStudent != null)
                {
                    var student = _studentService.GetById(selectedStudent.Id);
                    if (student != null)
                    {
                        var form = new EditStudentForm(_studentService, student);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadStudents();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取要編輯的學生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as StudentViewModel;
                if (selectedStudent != null)
                {
                    if (Program.Container != null)
                    {
                        var gradeService = Program.Container.Resolve<IGradeService>();
                        var form = new StudentGradesForm(gradeService, selectedStudent.Id);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取學生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_ManageCourses_Click(object sender, EventArgs e)
        {
            if (Program.Container != null)
            {
                var form = new CourseManagementForm(Program.Container.Resolve<ICourseService>());
                form.ShowDialog();
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button_AnalyzeGrades_Click(object sender, EventArgs e)
        {
            if (Program.Container != null)
            {
                var courseService = Program.Container.Resolve<ICourseService>();
                var form = new CourseSelectionForm(courseService);
                form.ShowDialog();
            }
        }
    }
}