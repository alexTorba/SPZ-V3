using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lb7.Model.StudentsDB;

namespace Lb7.Model
{
    static class DataManager
    {
        static readonly MarksDataTable marks;
        static readonly SubjectsDataTable subjects;
        static readonly StudentsDataTable students;

        static DataManager()
        {
            marks = new StudentsDBTableAdapters.MarksTableAdapter().GetData();
            subjects = new StudentsDBTableAdapters.SubjectsTableAdapter().GetData();
            students = new StudentsDBTableAdapters.StudentsTableAdapter().GetData();
        }
      
        public static MarksDataTable GetMarks()
        {
            return marks;
        }

        public static SubjectsDataTable GetSubjects()
        {
            return subjects;
        }

        public static StudentsDataTable GetStudents()
        {
            return students;
        }

    }
}
