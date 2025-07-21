using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Presentation.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentGradesForm : Form
    {
        private readonly IGradeService _gradeService;
        private readonly int _studentId;

        public StudentGradesForm(IGradeService gradeService, int studentId)
        {
            InitializeComponent();
            _gradeService = gradeService;
            _studentId = studentId;
        }

        private void StudentGradesForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadGrades();
        }

        private void SetupDataGridView()
        {
            dataGridViewGrades.AutoGenerateColumns = false; // Ensure auto-generation is off from the start
            dataGridViewGrades.Columns.Clear(); // Clear existing columns to prevent duplicates
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CourseName",
                HeaderText = "課程名稱",
                DataPropertyName = "CourseName"
            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Score",
                HeaderText = "分數",
                DataPropertyName = "Score"
            });
        }

        private void LoadGrades()
        {
            var grades = _gradeService.GetGradesByStudentId(_studentId)
                                      .Select(g => new GradeViewModel
                                      {
                                          Id = g.Id,
                                          Score = g.Score,
                                          StudentId = g.StudentId,
                                          CourseId = g.CourseId,
                                          CourseName = g.Course?.Name ?? "N/A"
                                      }).ToList();
            dataGridViewGrades.DataSource = grades;
        }

        private void button_AddGrade_Click(object sender, EventArgs e)
        {
            // Open a form to add a new grade
            var form = new AddGradeForm(_gradeService, _studentId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadGrades();
            }
        }

        private void button_EditGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count > 0)
            {
                var selectedGrade = dataGridViewGrades.SelectedRows[0].DataBoundItem as GradeViewModel;
                if (selectedGrade != null)
                {
                    var form = new EditGradeForm(_gradeService, selectedGrade);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadGrades();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取要編輯的成績！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_DeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count > 0)
            {
                var selectedGrade = dataGridViewGrades.SelectedRows[0].DataBoundItem as GradeViewModel;
                if (selectedGrade != null)
                {
                    DialogResult result = MessageBox.Show($"確定要刪除課程 {selectedGrade.CourseName} 的成績嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _gradeService.Delete(selectedGrade.Id);
                        LoadGrades();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選取要刪除的成績！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
