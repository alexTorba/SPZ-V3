using System;
using System.Linq;

using Lb5.View;
using Lb5.Model;

namespace Lb5.Presenter
{
	class StudentInfoPresenter
	{
		//---------------------------------------------------------------------------

		readonly IStudentBoard m_studentInfoBoard;
		Model.Model m_model;
		Student m_student;

		//---------------------------------------------------------------------------

		public StudentInfoPresenter( Model.Model _model, Student _student, IStudentBoard _studentInfo )
		{
			m_model = _model;
			m_student = _student;
			m_studentInfoBoard = _studentInfo;

			m_studentInfoBoard.FormLoad += StudentInfo_FormLoad;
			m_studentInfoBoard.ClosingForm += StudentInfo_ClosingForm;
		}

		//---------------------------------------------------------------------------

		private void StudentInfo_ClosingForm( object sender, EventArgs e )
		{
		}

		private void StudentInfo_FormLoad( object sender, EventArgs e )
		{
			//m_studentInfoBoard.FirstName = m_student.FirstName;
			//m_studentInfoBoard.LastName = m_student.LastName;
			//m_studentInfoBoard.MiddleName = m_student.MiddleName;

			//var marks = from s in EFGenericRepository.Get<Students>().Where( st => st.Id == student.Id )
			//			join m in EFGenericRepository.Get<Marks>() on s.Id equals m.IdSt
			//			select m;

			//studentInfo.GridDataSource = marks.ToList();
		}

		//---------------------------------------------------------------------------
	}
}
