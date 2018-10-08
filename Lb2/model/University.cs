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


    }
}
