using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Presentation.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class CourseSelectionForm : Form
    {
        private readonly ICourseService _courseService;
        public CourseSelectionForm(ICourseService courseService)
        {
            InitializeComponent();
            _courseService = courseService;
            this.Text = "選擇課程進行成績分析";
        }

        private void CourseSelectionForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            // Initialize grading strategy combo box
            comboBox_GradingStrategy.SelectedIndex = 0; // Select the first strategy by default
        }

        private void LoadCourses()
        {
            var courses = _courseService.GetAll().Select(c => new CourseViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Credit = c.Credit
            }).ToList();

            // Assuming a DataGridView named dataGridViewCourses
            dataGridViewCourses.AutoGenerateColumns = false;
            dataGridViewCourses.Columns.Clear();

            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CourseId",
                HeaderText = "課程ID",
                DataPropertyName = "Id",
                Visible = false // Hide ID column
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CourseName",
                HeaderText = "課程名稱",
                DataPropertyName = "Name"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Credit",
                HeaderText = "學分",
                DataPropertyName = "Credit"
            });

            dataGridViewCourses.DataSource = courses;
        }

        private void button_SelectCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                var selectedCourse = dataGridViewCourses.SelectedRows[0].DataBoundItem as CourseViewModel;
                if (selectedCourse != null)
                {
                    // Get the selected grading strategy
                    string selectedStrategy = comboBox_GradingStrategy.SelectedItem?.ToString() ?? "traditional";

                    // Open the new CoursePassingStudentsForm
                    if (Program.Container != null)
                    {
                        var gradeService = Program.Container.Resolve<IGradeService>();
                        var studentService = Program.Container.Resolve<IStudentService>();
                        var form = new CoursePassingStudentsForm(gradeService, studentService, selectedCourse.Id, selectedCourse.Name, selectedStrategy);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取一門課程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
