using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lb5.Model
{
	public class Model
	{
		//---------------------------------------------------------------------------

		List< Student > m_students;
		List< Subject > m_subjects;

		Marks m_marks;

		//---------------------------------------------------------------------------

		public List< Subject > Subjects => m_subjects;

		//---------------------------------------------------------------------------

		public void AddStudent( Student _student, List<KeyValuePair<Subject, int>> _marks )
		{
			m_students.Add( _student );
			m_marks.AddStudent( _student, _marks );
		}

		public void AddSubject( Subject _subject )
		{
			m_subjects.Add( _subject );
		}

		//---------------------------------------------------------------------------

		public void RemoveStudent( Student _student )
		{
			m_students.Remove( _student );
			m_marks.RemoveStudent( _student );
		}

		public void RemoveSubject( Subject _subject )
		{
			m_subjects.Remove( _subject );
			m_marks.RemoveSubject( _subject );
		}

		public List<KeyValuePair<Subject, int>> GetStudentMarks( Student _student )
		{
			return m_marks.GetStudentMarks( _student );
		}

		//---------------------------------------------------------------------------

		public void BindStudents( object _obj )
		{
			_obj = m_students;
		}

		public void BindSubjects( object _obj )
		{
			_obj = m_subjects;
		}

		//---------------------------------------------------------------------------

		public void LoadData()
		{
			m_students = LoadObj( "students" ) as List< Student > ?? new List< Student >();
			m_subjects = LoadObj( "subjects" ) as List< Subject > ?? new List< Subject >();
			m_marks = LoadObj( "marks" ) as Marks ?? new Marks();
		}

		public void SaveData()
		{
			SaveObj( m_students, "students" );
			SaveObj( m_subjects, "subjects" );
			SaveObj( m_marks, "marks" );
		}

		//---------------------------------------------------------------------------

		private object LoadObj( string _name )
		{
			if ( !File.Exists( _name ) )
				return null;

			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using ( FileStream fs = new FileStream( _name, FileMode.Open ) )
				return binaryFormatter.Deserialize( fs );
		}

		private void SaveObj( object _obj, string _name )
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using ( FileStream fs = new FileStream( _name, FileMode.Create ) )
				binaryFormatter.Serialize( fs, _obj );
		}

		//---------------------------------------------------------------------------
	}
}
