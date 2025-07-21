
using StudentGradeManagementSystem.Domain.Logic;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class CourseForm : Form
    {
        private readonly ICourseService _courseService;
        private readonly StudentGradeManagementSystem.Domain.POCO.Course _course;

        public CourseForm(ICourseService courseService, StudentGradeManagementSystem.Domain.POCO.Course? course = null)
        {
            InitializeComponent();
            _courseService = courseService;
            _course = course ?? new StudentGradeManagementSystem.Domain.POCO.Course();

            if (_course.Id != 0)
            {
                textBox_Name.Text = _course.Name;
                numericUpDown_Credit.Value = _course.Credit;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                _course.Name = textBox_Name.Text;
                _course.Credit = (int)numericUpDown_Credit.Value;

                if (_course.Id == 0)
                {
                    _courseService.Add(_course);
                    MessageBox.Show("課程新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _courseService.Update(_course);
                    MessageBox.Show("課程更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存課程失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
