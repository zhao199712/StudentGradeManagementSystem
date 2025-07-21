
namespace GUI
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_ClassName = new System.Windows.Forms.Label();
            this.textBox_ClassName = new System.Windows.Forms.TextBox();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(50, 53);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(44, 18);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "姓名:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(120, 50);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // label_ClassName
            // 
            this.label_ClassName.AutoSize = true;
            this.label_ClassName.Location = new System.Drawing.Point(50, 103);
            this.label_ClassName.Name = "label_ClassName";
            this.label_ClassName.Size = new System.Drawing.Size(44, 18);
            this.label_ClassName.TabIndex = 2;
            this.label_ClassName.Text = "班級:";
            // 
            // textBox_ClassName
            // 
            this.textBox_ClassName.Location = new System.Drawing.Point(120, 100);
            this.textBox_ClassName.Name = "textBox_ClassName";
            this.textBox_ClassName.Size = new System.Drawing.Size(200, 29);
            this.textBox_ClassName.TabIndex = 3;
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Location = new System.Drawing.Point(80, 160);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(100, 35);
            this.button_AddStudent.TabIndex = 4;
            this.button_AddStudent.Text = "新增";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(220, 160);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 35);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddStudent);
            this.Controls.Add(this.textBox_ClassName);
            this.Controls.Add(this.label_ClassName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增學生";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_ClassName;
        private System.Windows.Forms.TextBox textBox_ClassName;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button button_Cancel;
    }
}
