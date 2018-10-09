using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    class University
    {
        public string Name { get; set; }

        readonly List<Student> students = new List<Student>();
        readonly List<Professor> professors = new List<Professor>();
        readonly List<Faculty> faculties = new List<Faculty>();
        readonly List<Laboratory> laboratories = new List<Laboratory>();
        readonly List<LectureHalls> lectureHalls = new List<LectureHalls>();
        readonly List<Employee<Laboratory>> empsLab = new List<Employee<Laboratory>>();
        readonly List<Employee<LectureHalls>> empsLectHalls = new List<Employee<LectureHalls>>();

        public int CountStudents { get => students.Count; }
        public int CountLaboratories { get => laboratories.Count; }
        public int CountLectureHalls { get => lectureHalls.Count; }
        public int CountFaculties { get => faculties.Count; }

        public University()
        {
            Student s1 = new Student("Alex", 3, "VN312");
            Student s2 = new Student("Bob", 2, "VN321");
            Student s3 = new Student("Michael", 1, "VT103");
            students.AddRange(new List<Student> { s1, s2, s3 });

            Professor p1 = new Professor("John");
            Professor p2 = new Professor("Kris");
            professors.AddRange(new List<Professor> { p1, p2 });

            Faculty f1 = new Faculty("KN");
            Faculty f2 = new Faculty("BIKS");
            faculties.AddRange(new List<Faculty> { f1, f2 });

            Laboratory lab1 = new Laboratory("LB1");
            Laboratory lab2 = new Laboratory("LB2");
            laboratories.AddRange(new List<Laboratory> { lab1, lab2 });

            LectureHalls lh1 = new LectureHalls("LecHalls1");
            LectureHalls lh2 = new LectureHalls("LecHalls2");
            lectureHalls.AddRange(new List<LectureHalls> { lh1, lh2 });

            Employee<LectureHalls> empLectureHalls1 = new Employee<LectureHalls>("Anna");
            Employee<LectureHalls> empLectureHalls2 = new Employee<LectureHalls>("Harry");
            empsLectHalls.AddRange(new List<Employee<LectureHalls>> { empLectureHalls1, empLectureHalls2 });

            Employee<Laboratory> empLab1 = new Employee<Laboratory>("Petter");
            Employee<Laboratory> empLab2 = new Employee<Laboratory>("Elizabeth");
            empsLab.AddRange(new List<Employee<Laboratory>> { empLab1, empLab2 });

        }


    }
}
