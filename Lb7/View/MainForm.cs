using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lb7.Presenter;

namespace Lb7.View
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            MainFormPresenter mainFormPresenter = new MainFormPresenter(this);
        }

        public object StudentGridDataSource
        {
            get => studentsDataGrid.DataSource;
            set => studentsDataGrid.DataSource = value;
        }
        public object SubjectGridDataSource
        {
            get => subjectGridView.DataSource;
            set => subjectGridView.DataSource = value;
        }

        public object CurrentStudentRow => studentsDataGrid.CurrentRow.DataBoundItem;

        public object CurrentSubjectRow => subjectGridView.CurrentRow.DataBoundItem;

        public event EventHandler LoadForm;
        public event EventHandler ClosingForm;
        public event EventHandler DeleteStudent;
        public event EventHandler DeleteSubject;

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(sender, e);

            this.subjectGridView.Columns["Marks"].Visible = false;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)studentsDataGrid.SelectedCells[0].Value;
            new StudentInfoForm(id).ShowDialog();

        }

        private void studentsDataGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            studentsDataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
            studentsContextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void studentsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)studentsDataGrid.SelectedCells[0].Value;
            new StudentInfoForm(id).Show();
            LoadForm?.Invoke(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingForm?.Invoke(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {

                LoadForm?.Invoke(sender, e);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent?.Invoke(sender, e);
            LoadForm?.Invoke(sender, e);
        }

        private void subjectGridView_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            subjectGridView[e.ColumnIndex, e.RowIndex].Selected = true;
            subjectsContextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            var addSubjectForm = new AddSubjectForm();
            if (addSubjectForm.ShowDialog() == DialogResult.OK)
                LoadForm?.Invoke(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteSubject?.Invoke(sender, e);
            LoadForm?.Invoke(sender, e);
        }
    }
}
