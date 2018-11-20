using System;
using System.Drawing;
using System.Windows.Forms;

using Lb5.Presenter;

namespace Lb5.View
{
	public partial class MainForm : Form, IMainForm
	{
		//---------------------------------------------------------------------------

		public MainForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------------

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
		public event EventHandler AddSubject;
		public event EventHandler AddStudent;
		public event EventHandler EditStudent;

		//---------------------------------------------------------------------------

		private void MainForm_Load( object sender, EventArgs e )
		{
			LoadForm?.Invoke( sender, e );

			//subjectGridView.Columns["Marks"].Visible = false;
		}

		private void InfoToolStripMenuItem_Click( object sender, EventArgs e )
		{
			EditStudent?.Invoke( sender, e );
		}

		private void studentsDataGrid_CellContextMenuStripNeeded(
				object sender
			,	DataGridViewCellContextMenuStripNeededEventArgs e
		)
		{
			if ( e.ColumnIndex < 0 || e.RowIndex < 0 )
				return;

			studentsDataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
			studentsContextMenuStrip.Show( new Point( Cursor.Position.X, Cursor.Position.Y ) );
		}

		private void studentsDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			EditStudent?.Invoke( sender, e );
			LoadForm?.Invoke( sender, e );
		}

		private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			ClosingForm?.Invoke( sender, e );
		}

		private void addToolStripMenuItem_Click( object sender, EventArgs e )
		{
			AddStudent?.Invoke( sender, e );
		}

		private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
		{
			DeleteStudent?.Invoke( sender, e );
			LoadForm?.Invoke( sender, e );
		}

		private void subjectGridView_CellContextMenuStripNeeded(
				object sender
			,	DataGridViewCellContextMenuStripNeededEventArgs e
		)
		{
			if ( e.ColumnIndex < 0 || e.RowIndex < 0 )
				return;

			subjectGridView[e.ColumnIndex, e.RowIndex].Selected = true;
			subjectsContextMenuStrip.Show( new Point( Cursor.Position.X, Cursor.Position.Y ) );
		}

		private void addMenuItem_Click( object sender, EventArgs e )
		{
			AddSubject?.Invoke( sender, e );
		}

		private void toolStripMenuItem3_Click( object sender, EventArgs e )
		{
			DeleteSubject?.Invoke( sender, e );
			LoadForm?.Invoke( sender, e );
		}

		//---------------------------------------------------------------------------
	}
}
