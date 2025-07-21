using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Presentation.ViewModels;
using StudentGradeManagementSystem.Domain.Strategy;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class CourseAnalysisForm : Form
    {
        private readonly IGradeService _gradeService;
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService; // Add this
        private readonly int _studentId; // Change from _courseId
        private readonly string _studentName; // Change from _courseName
        private readonly string _gradingStrategyName; // New field

        public CourseAnalysisForm(IGradeService gradeService, IStudentService studentService, ICourseService courseService, int studentId, string studentName, string gradingStrategyName)
        {
            InitializeComponent();
            _gradeService = gradeService;
            _studentService = studentService;
            _courseService = courseService; // Assign it
            _studentId = studentId;
            _studentName = studentName;
            _gradingStrategyName = gradingStrategyName;
            this.Text = $"{_studentName} - 成績分析 ({_gradingStrategyName})";
        }

        private void CourseAnalysisForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadAnalysisData();
        }

        private void SetupDataGridView()
        {
            dataGridViewAnalysis.AutoGenerateColumns = false; // Ensure auto-generation is off from the start
            dataGridViewAnalysis.Columns.Clear(); // Clear existing columns to prevent duplicates
            dataGridViewAnalysis.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CourseName", // Change to CourseName
                HeaderText = "課程名稱",
                DataPropertyName = "CourseName"
            });
            dataGridViewAnalysis.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Score",
                HeaderText = "分數",
                DataPropertyName = "Score"
            });
            dataGridViewAnalysis.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "狀態",
                DataPropertyName = "Status"
            });
        }

        private void LoadAnalysisData()
        {
            // Resolve the specific grading strategy
            var gradingStrategyFactory = Program.Container.Resolve<Func<string, IGradingStrategy>>();
            var selectedGradingStrategy = gradingStrategyFactory(_gradingStrategyName);

            var gradesForStudent = _gradeService.GetGradesByStudentId(_studentId).ToList();
            var courses = _courseService.GetAll().ToList();

            var analysisData = gradesForStudent.Select(g =>
            {
                var course = courses.FirstOrDefault(c => c.Id == g.CourseId);
                // Use the selected strategy to determine passing status
                string status = selectedGradingStrategy.IsPassing(g.Score) ? "及格" : "未及格";
                return new CourseAnalysisViewModel
                {
                    StudentName = _studentName, // Now it's student name
                    CourseName = course?.Name ?? "N/A", // Add CourseName
                    Score = g.Score,
                    Status = status
                };
            }).ToList();

            dataGridViewAnalysis.DataSource = analysisData;
        }
    }
}
