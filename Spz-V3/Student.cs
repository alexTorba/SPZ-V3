using System;
using System.Collections.Generic;

namespace Lb1
{
    public enum Subjects
    {
        PhysicalCulture,
        Mathematics,
        Physics,
        Programming,
        SystemModeling,
        ComputerArchitecture,
        Philosophy,
        Databases,
        English,
        Logic,
        InternetTechnologies
    }

    public class Student
    {
        string name;
        public string Name
        {
            get => name;
            set
            {
                if (value.IsEmptyOrContainNumber())
                    throw new ArgumentException("name can't have spaces or numbers");
                else name = value;
            }
        }

        string recordBook;
        public string RecordBook
        {
            get => recordBook; set
            {
                if (value.Contains(" "))
                    throw new ArgumentException("Record book can't have a spaces");
                else recordBook = value;
            }
        }


        int course;
        public int Course { get => course; set => course = value; }

        public double AvaragePoint
        {
            get
            {
                double avaragePoint = 0;
                foreach (KeyValuePair<Subjects, int> mark in Marks)
                {
                    avaragePoint += mark.Value;
                }
                return avaragePoint / Marks.Count;
            }
        }


        private Dictionary<Subjects, int> marks;
        public Dictionary<Subjects, int> Marks
        {
            get => marks;
            set
            {
                foreach (var mark in value.Values)
                {
                    if (mark > 100 && mark < 0)
                        throw new ArgumentException("mark have to be in the range from 0 to 100 ");
                }
                marks = value;
            }
        }

        public int this[Subjects index]
        {
            get => this.marks[index];
            set => this.marks[index] = value;
        }

        public Student()
        {
            this.Marks = new Dictionary<Subjects, int>()
            {
                {Subjects.ComputerArchitecture, 0 },
                {Subjects.Databases, 0 },
                {Subjects.English, 0 },
                {Subjects.InternetTechnologies, 0 },
                {Subjects.Logic, 0 },
                {Subjects.Mathematics, 0 },
                {Subjects.Philosophy, 0 },
                {Subjects.PhysicalCulture, 0 },
                {Subjects.Physics, 0 },
                {Subjects.Programming, 0 },
                {Subjects.SystemModeling, 0 }
            };
        }

        public Student(string name, int cource, string recordBook) : this()
        {
            Name = name;
            RecordBook = recordBook;
            Course = cource;
        }

        public int[] EqualsMarks(Student secondStudent)
        {
            List<int> rezult = new List<int>();

            for (int i = 0; i < secondStudent.Marks.Count; i++)
            {
                int diff = secondStudent.Marks[(Subjects)i] - this.Marks[(Subjects)i];

                rezult.Add(diff);
            }
            return rezult.ToArray();
        }

        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"{Name} {Course} {recordBook}, AvaragePoint: {AvaragePoint}";
        }
    }
}
