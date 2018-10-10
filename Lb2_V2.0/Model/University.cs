using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2_V2._0
{
    public class University : IEqualityComparer<University>
    {
        public string Name { get; set; }

        public int CountFaculty { get; set; }
        public int CountLaboratories { get; set; }
        public int CountStudents { get; set; }
        public int CountLectureHalls { get; set; }
        public int CountProfessors { get; set; }
        public int CountEmployee { get; set; }

        public int Id { get; set; }

        #region Ctors

        public University()
        {
            Id = GetRandomId(321);
        }

        private static int GetRandomId(int seed)
        {
            return new Random((int)DateTime.Now.Ticks + seed).Next(0, 100000);
        }

        public University(string name, int countFaculty, int countLaboratories,
            int countStudents, int countLectureHalls, int countProfessors, int countEmployee) : this()
        {
            Name = name;
            CountFaculty = countFaculty;
            CountLaboratories = countLaboratories;
            CountStudents = countStudents;
            CountLectureHalls = countLectureHalls;
            CountProfessors = countProfessors;
            CountEmployee = countEmployee;
        }

        public University(University university)
        {
            Name = university.Name;
            CountFaculty = university.CountFaculty;
            CountLaboratories = university.CountLaboratories;
            CountStudents = university.CountStudents;
            CountLectureHalls = university.CountLectureHalls;
            CountProfessors = university.CountProfessors;
            CountEmployee = university.CountEmployee;
            Id = university.Id;
        }

        #endregion

        #region Methods

        public void AddStudent(int students)
        {
            CountStudents += students;
        }

        public void RemoveStudent(int students)
        {
            CountStudents -= students;
        }

        public void AddLaboratories(int labs)
        {
            CountLaboratories += labs;
        }

        public void RemoveLaboratories(int labs)
        {
            CountLaboratories -= labs;
        }

        public void AddLectureHalls(int labs)
        {
            CountLectureHalls += labs;
        }

        public void RemoveLectureHalls(int labs)
        {
            CountLectureHalls -= labs;
        }

        public void AddEmployee(int emp)
        {
            CountEmployee += emp;
        }

        public void RemoveEmployee(int emp)
        {
            CountEmployee -= emp;
        }

        public void AddProfessors(int pro)
        {
            CountProfessors += pro;
        }

        public void RemoveProfessors(int pro)
        {
            CountProfessors -= pro;
        }

        #endregion

        #region IEqualityComparer<University>

        public bool Equals(University x, University y)
        {
            if (x == null || y == null)
                return false;

            if (x == y)
                return true;

            if (x.Name == y.Name &&
               x.CountStudents == y.CountStudents &&
               x.CountProfessors == y.CountProfessors &&
               x.CountLectureHalls == y.CountLectureHalls &&
               x.CountLaboratories == y.CountLaboratories &&
               x.CountFaculty == y.CountFaculty &&
               x.CountEmployee == y.CountEmployee)
                return true;

            return false;
        }

        public int GetHashCode(University obj)
        {
            return Id ^ obj.Id;
        }

        #endregion

        public static University operator +(University first, University second)
        {

            University rezult = new University
            {
                Name = first.Name + second.Name,
                CountEmployee = first.CountEmployee + second.CountEmployee,
                CountFaculty = first.CountFaculty + second.CountFaculty,
                CountLaboratories = first.CountLaboratories + second.CountLaboratories,
                CountLectureHalls = first.CountLectureHalls + second.CountLectureHalls,
                CountProfessors = first.CountProfessors + second.CountProfessors,
                CountStudents = first.CountStudents + second.CountStudents,
                Id = GetRandomId(123) ^ GetRandomId(355)
        };

            return rezult;
        }
    }
}
