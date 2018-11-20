using System;

using Lb5.View;
using Lb5.Model;

namespace Lb5.Presenter
{
	class AddSubjectFormPresenter
	{
		//---------------------------------------------------------------------------

		readonly IAddSubjectForm m_addSubjectForm;

		Model.Model m_model;

		//---------------------------------------------------------------------------

		public AddSubjectFormPresenter( Model.Model _model, IAddSubjectForm _addSubjectForm )
		{
			m_model = _model;
			m_addSubjectForm = _addSubjectForm;

			m_addSubjectForm.SaveButton += AddSubjectForm_SaveButton;
		}

		private void AddSubjectForm_SaveButton( object _sender, EventArgs _e )
		{
			Subject subject = new Subject { Name = m_addSubjectForm.SubjectName };
			m_model.AddSubject( subject );
		}

		//---------------------------------------------------------------------------
	}
}
