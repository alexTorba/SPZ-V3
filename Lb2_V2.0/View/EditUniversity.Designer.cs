namespace Lb2_V2._0
{
    partial class EditUniversity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.employeesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.professorsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.studentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lectureHallsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.laboratoriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.facultyesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.employeesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cancelButton.Location = new System.Drawing.Point(226, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 33);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.saveButton.Location = new System.Drawing.Point(26, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 33);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(222, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Employees:";
            // 
            // employeesNumericUpDown
            // 
            this.employeesNumericUpDown.Location = new System.Drawing.Point(226, 262);
            this.employeesNumericUpDown.Name = "employeesNumericUpDown";
            this.employeesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.employeesNumericUpDown.TabIndex = 28;
            this.employeesNumericUpDown.ValueChanged += new System.EventHandler(this.employeesNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(222, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Professors:";
            // 
            // professorsNumericUpDown
            // 
            this.professorsNumericUpDown.Location = new System.Drawing.Point(226, 193);
            this.professorsNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.professorsNumericUpDown.Name = "professorsNumericUpDown";
            this.professorsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.professorsNumericUpDown.TabIndex = 26;
            this.professorsNumericUpDown.ValueChanged += new System.EventHandler(this.professorsNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(222, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Students:";
            // 
            // studentsNumericUpDown
            // 
            this.studentsNumericUpDown.Location = new System.Drawing.Point(226, 118);
            this.studentsNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.studentsNumericUpDown.Name = "studentsNumericUpDown";
            this.studentsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.studentsNumericUpDown.TabIndex = 24;
            this.studentsNumericUpDown.ValueChanged += new System.EventHandler(this.studentsNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "LectureHalls:";
            // 
            // lectureHallsNumericUpDown
            // 
            this.lectureHallsNumericUpDown.Location = new System.Drawing.Point(26, 262);
            this.lectureHallsNumericUpDown.Name = "lectureHallsNumericUpDown";
            this.lectureHallsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.lectureHallsNumericUpDown.TabIndex = 22;
            this.lectureHallsNumericUpDown.ValueChanged += new System.EventHandler(this.lectureHallsNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Laboratories:";
            // 
            // laboratoriesNumericUpDown
            // 
            this.laboratoriesNumericUpDown.Location = new System.Drawing.Point(26, 193);
            this.laboratoriesNumericUpDown.Name = "laboratoriesNumericUpDown";
            this.laboratoriesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.laboratoriesNumericUpDown.TabIndex = 20;
            this.laboratoriesNumericUpDown.ValueChanged += new System.EventHandler(this.laboratoriesNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Facultyes:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(22, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // facultyesNumericUpDown
            // 
            this.facultyesNumericUpDown.Enabled = false;
            this.facultyesNumericUpDown.Location = new System.Drawing.Point(26, 118);
            this.facultyesNumericUpDown.Name = "facultyesNumericUpDown";
            this.facultyesNumericUpDown.ReadOnly = true;
            this.facultyesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.facultyesNumericUpDown.TabIndex = 16;
            // 
            // EditUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 377);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.employeesNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.professorsNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentsNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lectureHallsNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laboratoriesNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facultyesNumericUpDown);
            this.Name = "EditUniversity";
            this.Text = "EditUniversity";
            this.Load += new System.EventHandler(this.EditUniversity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown employeesNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown professorsNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown studentsNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lectureHallsNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown laboratoriesNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown facultyesNumericUpDown;
    }
}