using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using System;
using System.Linq;
using System.Windows.Forms;
using Autofac;

namespace GUI
{
    public partial class AddGradeForm : Form
    {
        private readonly IGradeService _gradeService;
        private readonly ICourseService _courseService;
        private readonly int _studentId;

        public AddGradeForm(IGradeService gradeService, int studentId)
        {
            InitializeComponent();
            _gradeService = gradeService;
            _studentId = studentId;
            // Resolve ICourseService from the container
            _courseService = Program.Container.Resolve<ICourseService>();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            var existingGrades = _gradeService.GetGradesByStudentId(_studentId);
            var allCourses = _courseService.GetAll();

            var availableCourses = allCourses.Where(c => !existingGrades.Any(g => g.CourseId == c.Id)).ToList();
            
            comboBoxCourses.DataSource = availableCourses;
            comboBoxCourses.DisplayMember = "Name";
            comboBoxCourses.ValueMember = "Id";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (comboBoxCourses.SelectedValue == null)
            {
                MessageBox.Show("請選取一門課程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var newGrade = new Grade
                {
                    StudentId = _studentId,
                    CourseId = (int)comboBoxCourses.SelectedValue,
                    Score = (double)numericUpDownScore.Value
                };

                _gradeService.Add(newGrade);
                MessageBox.Show("成績新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增成績失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
