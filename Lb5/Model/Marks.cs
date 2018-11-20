using System;
using System.Collections.Generic;
using System.Linq;

namespace Lb5.Model
{
	[Serializable]
	public class Marks
	{
		//---------------------------------------------------------------------------

		Dictionary< Student, SortedDictionary< Subject, int > > m_marks;

		//---------------------------------------------------------------------------

		public Marks()
		{
			m_marks = new Dictionary< Student, SortedDictionary< Subject, int > >();
		}

		//---------------------------------------------------------------------------

		public void AddStudent( Student _student, SortedDictionary< Subject, int > _marks )
		{
			m_marks.Add( _student, _marks );
		}

		public void SetMark( Student _student, Subject _subject, int _value )
		{
			var studentMarks = m_marks[_student];
			studentMarks[_subject] = _value;
		}

		//---------------------------------------------------------------------------

		public void RemoveSubject( Subject _subject )
		{
			foreach ( var student in m_marks )
				if ( student.Value.ContainsKey( _subject ) )
					student.Value.Remove( _subject );
		}

		public void RemoveStudent( Student _student )
		{
			m_marks.Remove( _student );
		}

		//---------------------------------------------------------------------------
	}
}
