using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Lb7.View;
using Lb7.Model;

namespace Lb7.Presenter
{
    class AddStudentFormPresenter
    {
        readonly IAddStudentFrom addStudentBoard;
        Students student;
        List<Marks> marks;

        public AddStudentFormPresenter(IAddStudentFrom addStudentBoard)
        {
            this.addStudentBoard = addStudentBoard;

            this.addStudentBoard.FormLoad += Student_FormLoad;
            this.addStudentBoard.SaveClick += Student_SaveClick;
        }

        private void Student_SaveClick(object sender, EventArgs e)
        {
            student.FirstName = addStudentBoard.FirstName;
            student.LastName = addStudentBoard.LastName;
            student.MiddleName = addStudentBoard.MiddleName;
            student.Marks = marks;
            EFGenericRepository.Create(student);

            EFGenericRepository.SaveChanges();
        }

        private void Student_FormLoad(object sender, EventArgs e)
        {
            student = new Students { FirstName = "", LastName = "", MiddleName = "" };

            marks = new List<Marks>();
            foreach (var sub in EFGenericRepository.Get<Subjects>())
            {
                marks.Add(new Marks { Subjects = sub });
            }

            addStudentBoard.GridDataSource = marks.ToList();

        }
    }
}
