namespace Lb2_V2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFacultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLaboratoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLectureHallsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countProfessorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.countFacultyDataGridViewTextBoxColumn,
            this.countLaboratoriesDataGridViewTextBoxColumn,
            this.countStudentsDataGridViewTextBoxColumn,
            this.countLectureHallsDataGridViewTextBoxColumn,
            this.countProfessorsDataGridViewTextBoxColumn,
            this.countEmployeeDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.universityBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 50);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(696, 375);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.exitToolStripMenuItem.Text = "Merge";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countFacultyDataGridViewTextBoxColumn
            // 
            this.countFacultyDataGridViewTextBoxColumn.DataPropertyName = "CountFaculty";
            this.countFacultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.countFacultyDataGridViewTextBoxColumn.Name = "countFacultyDataGridViewTextBoxColumn";
            this.countFacultyDataGridViewTextBoxColumn.ReadOnly = true;
            this.countFacultyDataGridViewTextBoxColumn.Width = 70;
            // 
            // countLaboratoriesDataGridViewTextBoxColumn
            // 
            this.countLaboratoriesDataGridViewTextBoxColumn.DataPropertyName = "CountLaboratories";
            this.countLaboratoriesDataGridViewTextBoxColumn.HeaderText = "Laboratories";
            this.countLaboratoriesDataGridViewTextBoxColumn.Name = "countLaboratoriesDataGridViewTextBoxColumn";
            this.countLaboratoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countStudentsDataGridViewTextBoxColumn
            // 
            this.countStudentsDataGridViewTextBoxColumn.DataPropertyName = "CountStudents";
            this.countStudentsDataGridViewTextBoxColumn.HeaderText = "Students";
            this.countStudentsDataGridViewTextBoxColumn.Name = "countStudentsDataGridViewTextBoxColumn";
            this.countStudentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.countStudentsDataGridViewTextBoxColumn.Width = 80;
            // 
            // countLectureHallsDataGridViewTextBoxColumn
            // 
            this.countLectureHallsDataGridViewTextBoxColumn.DataPropertyName = "CountLectureHalls";
            this.countLectureHallsDataGridViewTextBoxColumn.HeaderText = "LectureHalls";
            this.countLectureHallsDataGridViewTextBoxColumn.Name = "countLectureHallsDataGridViewTextBoxColumn";
            this.countLectureHallsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countProfessorsDataGridViewTextBoxColumn
            // 
            this.countProfessorsDataGridViewTextBoxColumn.DataPropertyName = "CountProfessors";
            this.countProfessorsDataGridViewTextBoxColumn.HeaderText = "Professors";
            this.countProfessorsDataGridViewTextBoxColumn.Name = "countProfessorsDataGridViewTextBoxColumn";
            this.countProfessorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.countProfessorsDataGridViewTextBoxColumn.Width = 80;
            // 
            // countEmployeeDataGridViewTextBoxColumn
            // 
            this.countEmployeeDataGridViewTextBoxColumn.DataPropertyName = "CountEmployee";
            this.countEmployeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.countEmployeeDataGridViewTextBoxColumn.Name = "countEmployeeDataGridViewTextBoxColumn";
            this.countEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.countEmployeeDataGridViewTextBoxColumn.Width = 80;
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(Lb2_V2._0.University);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource universityBindingSource;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFacultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countLaboratoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countLectureHallsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countProfessorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countEmployeeDataGridViewTextBoxColumn;
    }
}

