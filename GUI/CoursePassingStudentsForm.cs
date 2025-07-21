using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.Strategy;
using StudentGradeManagementSystem.Presentation.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class CoursePassingStudentsForm : Form
    {
        private readonly IGradeService _gradeService;
        private readonly IStudentService _studentService;
        private readonly int _courseId;
        private readonly string _courseName;
        private readonly string _gradingStrategyName;

        public CoursePassingStudentsForm(IGradeService gradeService, IStudentService studentService, int courseId, string courseName, string gradingStrategyName)
        {
            InitializeComponent();
            _gradeService = gradeService;
            _studentService = studentService;
            _courseId = courseId;
            _courseName = courseName;
            _gradingStrategyName = gradingStrategyName;
            this.Text = $"{_courseName} - 及格學生列表 ({_gradingStrategyName})";
        }

        private void CoursePassingStudentsForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadPassingStudents();
        }

        private void SetupDataGridView()
        {
            dataGridViewPassingStudents.AutoGenerateColumns = false;
            dataGridViewPassingStudents.Columns.Clear();

            dataGridViewPassingStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StudentId",
                HeaderText = "學號",
                DataPropertyName = "Id"
            });
            dataGridViewPassingStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StudentName",
                HeaderText = "姓名",
                DataPropertyName = "Name"
            });
            dataGridViewPassingStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Score",
                HeaderText = "分數",
                DataPropertyName = "Score"
            });
        }

        private void LoadPassingStudents()
        {
            var gradingStrategyFactory = Program.Container.Resolve<Func<string, IGradingStrategy>>();
            var selectedGradingStrategy = gradingStrategyFactory(_gradingStrategyName);

            var gradesForCourse = _gradeService.GetGradesByCourseId(_courseId).ToList();
            var students = _studentService.GetAll().ToList();

            var passingStudents = gradesForCourse.Where(g => selectedGradingStrategy.IsPassing(g.Score))
                                                 .Select(g => new StudentViewModel
                                                 {
                                                     Id = g.StudentId,
                                                     Name = students.FirstOrDefault(s => s.Id == g.StudentId)?.Name ?? "N/A",
                                                     Score = g.Score // Add score to display
                                                 }).ToList();

            dataGridViewPassingStudents.DataSource = passingStudents;

            // Update the passing count label
            lblPassingCount.Text = $"總通過人數: {passingStudents.Count}";
        }
    }
}
