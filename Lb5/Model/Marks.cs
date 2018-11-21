using System;
using System.Collections.Generic;
using System.Linq;

namespace Lb5.Model
{
	[Serializable]
	public class Marks
	{
		//---------------------------------------------------------------------------

		Dictionary< Student, List<KeyValuePair<Subject, int>>> m_marks;

		//---------------------------------------------------------------------------

		public Marks()
		{
			m_marks = new Dictionary< Student, List<KeyValuePair<Subject, int>> >();
		}

		//---------------------------------------------------------------------------

		public void AddStudent( Student _student, List<KeyValuePair<Subject, int>> _marks )
		{
			m_marks.Add( _student, _marks );
		}

		//public void SetMark( Student _student, Subject _subject, int _value )
		//{
		//	var studentMarks = m_marks[_student];
		//	studentMarks[_subject] = _value;
		//}

		public List<KeyValuePair<Subject, int>> GetStudentMarks( Student _stud )
		{
			return m_marks[_stud];
		}

		//---------------------------------------------------------------------------

		public void RemoveSubject( Subject _subject )
		{
			List<KeyValuePair<Subject, int>> list = new List<KeyValuePair<Subject, int>>();
			list.RemoveAll( ( pair ) => pair.Key == _subject );

			//foreach ( var student in m_marks )
			//	if ( student.Value.ContainsKey( _subject ) )
			//		student.Value.Remove( _subject );
		}

		public void RemoveStudent( Student _student )
		{
			m_marks.Remove( _student );
		}

		//---------------------------------------------------------------------------
	}
}
