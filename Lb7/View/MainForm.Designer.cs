namespace Lb7.View
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
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.subjectGridView = new System.Windows.Forms.DataGridView();
            this.studentsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).BeginInit();
            this.studentsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(12, 66);
            this.studentsDataGrid.MultiSelect = false;
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.RowTemplate.Height = 24;
            this.studentsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGrid.Size = new System.Drawing.Size(588, 453);
            this.studentsDataGrid.TabIndex = 0;
            this.studentsDataGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.studentsDataGrid_CellContextMenuStripNeeded);
            // 
            // subjectGridView
            // 
            this.subjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGridView.Location = new System.Drawing.Point(664, 66);
            this.subjectGridView.Name = "subjectGridView";
            this.subjectGridView.RowTemplate.Height = 24;
            this.subjectGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subjectGridView.Size = new System.Drawing.Size(392, 453);
            this.subjectGridView.TabIndex = 1;
            // 
            // studentsContextMenuStrip
            // 
            this.studentsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.studentsContextMenuStrip.Name = "studentsContextMenuStrip";
            this.studentsContextMenuStrip.Size = new System.Drawing.Size(129, 76);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 539);
            this.Controls.Add(this.subjectGridView);
            this.Controls.Add(this.studentsDataGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).EndInit();
            this.studentsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.DataGridView subjectGridView;
        private System.Windows.Forms.ContextMenuStrip studentsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

