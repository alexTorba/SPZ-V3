using System;
using System.Collections.Generic;
using System.Linq;

using Lb5.View;
using Lb5.Model;

namespace Lb5.Presenter
{
	class AddStudentFormPresenter
	{
		//---------------------------------------------------------------------------

		readonly IAddStudentFrom m_addStudentBoard;
		Model.Model m_model;
		List<KeyValuePair<Subject, int>> marks;

		//---------------------------------------------------------------------------

		public AddStudentFormPresenter( Model.Model _model, IAddStudentFrom addStudentBoard )
		{
			m_model = _model;
			m_addStudentBoard = addStudentBoard;

			addStudentBoard.FormLoad += Student_FormLoad;
			addStudentBoard.SaveClick += Student_SaveClick;
		}

		//---------------------------------------------------------------------------

		private void Student_SaveClick( object sender, EventArgs e )
		{
			Student student = new Student
			{
				FirstName = m_addStudentBoard.FirstName,
				LastName = m_addStudentBoard.LastName,
				MiddleName = m_addStudentBoard.MiddleName
			};

			SortedDictionary<Subject, int> result = new SortedDictionary<Subject, int>();
			foreach ( var sub in marks )
				result.Add( sub.Key, sub.Value );

			m_model.AddStudent( student, result );
		}

		private void Student_FormLoad( object sender, EventArgs e )
		{
			marks = new List<KeyValuePair<Subject, int>>();
			foreach ( var sub in m_model.Subjects )
				marks.Add( new KeyValuePair<Subject, int>( sub, 0 ) );

			m_addStudentBoard.GridDataSource = marks;
		}

		//---------------------------------------------------------------------------
	}
}
