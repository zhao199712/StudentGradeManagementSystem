using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddStudentForm : Form
    {
        private readonly IStudentService _studentService;

        public AddStudentForm(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student
                {
                    Name = textBox_Name.Text,
                    ClassName = textBox_ClassName.Text
                };

                _studentService.Add(newStudent);

                MessageBox.Show("學生新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增學生失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
