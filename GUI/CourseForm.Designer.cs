
namespace GUI
{
    partial class CourseForm
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
            this.label_Credit = new System.Windows.Forms.Label();
            this.numericUpDown_Credit = new System.Windows.Forms.NumericUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Credit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(50, 53);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(80, 18);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "課程名稱:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(140, 50);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // label_Credit
            // 
            this.label_Credit.AutoSize = true;
            this.label_Credit.Location = new System.Drawing.Point(50, 103);
            this.label_Credit.Name = "label_Credit";
            this.label_Credit.Size = new System.Drawing.Size(44, 18);
            this.label_Credit.TabIndex = 2;
            this.label_Credit.Text = "學分:";
            // 
            // numericUpDown_Credit
            // 
            this.numericUpDown_Credit.Location = new System.Drawing.Point(140, 100);
            this.numericUpDown_Credit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Credit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Credit.Name = "numericUpDown_Credit";
            this.numericUpDown_Credit.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_Credit.TabIndex = 3;
            this.numericUpDown_Credit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(80, 160);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(100, 35);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "儲存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.numericUpDown_Credit);
            this.Controls.Add(this.label_Credit);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "課程";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Credit;
        private System.Windows.Forms.NumericUpDown numericUpDown_Credit;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}
