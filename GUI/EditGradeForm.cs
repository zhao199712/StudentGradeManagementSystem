using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Presentation.ViewModels;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditGradeForm : Form
    {
        private readonly IGradeService _gradeService;
        private readonly GradeViewModel _gradeToEdit;

        public EditGradeForm(IGradeService gradeService, GradeViewModel gradeToEdit)
        {
            InitializeComponent();
            _gradeService = gradeService;
            _gradeToEdit = gradeToEdit;
            LoadGradeData();
        }

        private void LoadGradeData()
        {
            labelCourseName.Text = _gradeToEdit.CourseName;
            numericUpDownScore.Value = (decimal)_gradeToEdit.Score;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                _gradeToEdit.Score = (double)numericUpDownScore.Value;
                _gradeService.UpdateGrade(_gradeToEdit.ToGrade()); // Assuming a ToGrade() method in ViewModel
                MessageBox.Show("成績更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新成績失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
