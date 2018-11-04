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

        public event EventHandler LoadForm;

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm.Invoke(sender, e);
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
    }
}
