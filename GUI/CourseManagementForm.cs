
using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using System;
using System.Windows.Forms;
using CourseModel = StudentGradeManagementSystem.Domain.POCO.Course;

namespace GUI
{
    public partial class CourseManagementForm : Form
    {
        private readonly ICourseService _courseService;

        public CourseManagementForm(ICourseService courseService)
        {
            InitializeComponent();
            _courseService = courseService;
        }

        private void CourseManagementForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = _courseService.GetAll();
            dataGridView_Courses.DataSource = courses;
        }

        private void button_AddCourse_Click(object sender, EventArgs e)
        {
            var form = new CourseForm(_courseService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void button_EditCourse_Click(object sender, EventArgs e)
        {
            if (dataGridView_Courses.SelectedRows.Count > 0)
            {
                var selectedCourse = dataGridView_Courses.SelectedRows[0].DataBoundItem as CourseModel;
                if (selectedCourse != null)
                {
                    var form = new CourseForm(_courseService, selectedCourse);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadCourses();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取要編輯的課程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_DeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridView_Courses.SelectedRows.Count > 0)
            {
                var selectedCourse = dataGridView_Courses.SelectedRows[0].DataBoundItem as CourseModel;
                if (selectedCourse != null)
                {
                    DialogResult result = MessageBox.Show($"確定要刪除課程 {selectedCourse.Name} 嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _courseService.Delete(selectedCourse.Id);
                            MessageBox.Show("課程刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCourses();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"刪除課程失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取要刪除的課程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
