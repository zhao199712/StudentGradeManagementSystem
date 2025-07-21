
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditStudentForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly Student _student;

        public EditStudentForm(IStudentService studentService, Student student)
        {
            InitializeComponent();
            _studentService = studentService;
            _student = student;

            // Populate the form with the student's data
            textBox_Name.Text = _student.Name;
            textBox_ClassName.Text = _student.ClassName;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the student's information
                _student.Name = textBox_Name.Text;
                _student.ClassName = textBox_ClassName.Text;

                _studentService.Update(_student);

                MessageBox.Show("學生資訊更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新學生資訊失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
