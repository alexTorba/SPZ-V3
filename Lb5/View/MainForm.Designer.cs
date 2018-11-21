namespace Lb5.View
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.studentsDataGrid = new System.Windows.Forms.DataGridView();
			this.subjectGridView = new System.Windows.Forms.DataGridView();
			this.studentsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.subjectsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).BeginInit();
			this.studentsContextMenuStrip.SuspendLayout();
			this.subjectsContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// studentsDataGrid
			// 
			this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentsDataGrid.ContextMenuStrip = this.studentsContextMenuStrip;
			this.studentsDataGrid.Location = new System.Drawing.Point(9, 54);
			this.studentsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.studentsDataGrid.MultiSelect = false;
			this.studentsDataGrid.Name = "studentsDataGrid";
			this.studentsDataGrid.RowTemplate.Height = 24;
			this.studentsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.studentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.studentsDataGrid.Size = new System.Drawing.Size(441, 368);
			this.studentsDataGrid.TabIndex = 0;
			this.studentsDataGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.studentsDataGrid_CellContextMenuStripNeeded);
			this.studentsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGrid_CellDoubleClick);
			// 
			// subjectGridView
			// 
			this.subjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.subjectGridView.ContextMenuStrip = this.subjectsContextMenuStrip;
			this.subjectGridView.Location = new System.Drawing.Point(498, 54);
			this.subjectGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.subjectGridView.Name = "subjectGridView";
			this.subjectGridView.RowTemplate.Height = 24;
			this.subjectGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.subjectGridView.Size = new System.Drawing.Size(294, 368);
			this.subjectGridView.TabIndex = 1;
			this.subjectGridView.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.subjectGridView_CellContextMenuStripNeeded);
			// 
			// studentsContextMenuStrip
			// 
			this.studentsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.studentsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.studentsContextMenuStrip.Name = "studentsContextMenuStrip";
			this.studentsContextMenuStrip.Size = new System.Drawing.Size(108, 70);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.infoToolStripMenuItem.Text = "Info";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
			// 
			// changeToolStripMenuItem
			// 
			this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
			this.changeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.changeToolStripMenuItem.Text = "Add";
			this.changeToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(190, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Students";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(611, 24);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Subjects";
			// 
			// subjectsContextMenuStrip
			// 
			this.subjectsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.subjectsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.toolStripMenuItem3});
			this.subjectsContextMenuStrip.Name = "studentsContextMenuStrip";
			this.subjectsContextMenuStrip.Size = new System.Drawing.Size(108, 48);
			// 
			// addMenuItem
			// 
			this.addMenuItem.Name = "addMenuItem";
			this.addMenuItem.Size = new System.Drawing.Size(107, 22);
			this.addMenuItem.Text = "Add";
			this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
			this.toolStripMenuItem3.Text = "Delete";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 438);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.subjectGridView);
			this.Controls.Add(this.studentsDataGrid);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).EndInit();
			this.studentsContextMenuStrip.ResumeLayout(false);
			this.subjectsContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView studentsDataGrid;
		private System.Windows.Forms.DataGridView subjectGridView;
		private System.Windows.Forms.ContextMenuStrip studentsContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip subjectsContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
	}
}

