using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    class Professor : ICollection<Student>
    {
        public string Name { get; set; }
        private readonly List<Student> students = new List<Student>();

        public Professor(string name)
        {
            Name = name;
        }

        public Professor(string name, params Student[] students) : this(name)
        {
            this.students.AddRange(students);
        }

        public int Count => this.students.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Student student)
        {
            if (Count < 10)
                students.Add(student);
            else throw new ArgumentOutOfRangeException("professor can have up to 10 students");
        }

        public void Clear()
        {
            this.students.Clear();
        }

        public bool Contains(Student student)
        {
            return students.Contains(student);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            students.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (Student student in students)
                yield return student;
        }

        public bool Remove(Student student)
        {
            return students.Remove(student);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Student student in students)
                yield return student;
        }

    }
}
