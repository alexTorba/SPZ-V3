using System;
using System.Windows.Forms;

using Lb5.Model;
using Lb5.View;

namespace Lb5.Presenter
{
	class MainFormPresenter
	{
		//---------------------------------------------------------------------------

		Model.Model m_model;
		IMainForm m_mainForm;

		//---------------------------------------------------------------------------

		public MainFormPresenter( Model.Model _model, IMainForm _mainForm )
		{
			m_model = _model;
			m_mainForm = _mainForm;

			m_model.LoadData();

			m_mainForm.LoadForm += MainForm_LoadForm;
			m_mainForm.ClosingForm += MainForm_ClosingForm;
			m_mainForm.DeleteStudent += MainForm_DeleteEntity;
			m_mainForm.DeleteSubject += MainForm_DeleteSubject;
			m_mainForm.AddSubject += AddSubject;
			m_mainForm.AddStudent += AddStudent;
			m_mainForm.EditStudent += EditStudent;
		}

		//---------------------------------------------------------------------------

		private void MainForm_DeleteSubject( object _sender, EventArgs _e )
		{
			if ( m_mainForm.CurrentSubjectRow is Subject subject )
				m_model.RemoveSubject( subject );
		}

		private void MainForm_DeleteEntity( object _sender, EventArgs _e )
		{
			if ( m_mainForm.CurrentStudentRow is Student student )
				m_model.RemoveStudent( student );
		}

		private void MainForm_ClosingForm( object _sender, EventArgs _e )
		{
			m_model.SaveData();
		}

		private void MainForm_LoadForm( object _sender, EventArgs _e )
		{
			m_model.BindStudents( m_mainForm.StudentGridDataSource );
			m_model.BindSubjects( m_mainForm.SubjectGridDataSource );
		}

		private void AddSubject( object sender, EventArgs e )
		{
			var addSubjectForm = new AddSubjectForm();
			var presenter = new AddSubjectFormPresenter( m_model, addSubjectForm );

			if ( addSubjectForm.ShowDialog() == DialogResult.OK )
				MainForm_LoadForm( null, EventArgs.Empty );
		}

		private void AddStudent( object sender, EventArgs e )
		{
			var addStudentForm = new AddStudentForm();
			var presenter = new AddStudentFormPresenter( m_model, addStudentForm );

			if ( addStudentForm.ShowDialog() == DialogResult.OK )
				MainForm_LoadForm( null, EventArgs.Empty );
		}

		private void EditStudent( object sender, EventArgs e )
		{
			var form = new StudentInfoForm();
			var presenter = new StudentInfoPresenter(
					m_model
				,	m_mainForm.CurrentStudentRow as Student
				,	form
			);

			form.Show();
		}

		//---------------------------------------------------------------------------
	}
}
