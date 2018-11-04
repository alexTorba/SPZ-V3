using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lb7.View;
using Lb7.Model;

namespace Lb7.Presenter
{
    class StudentInfoPresenter
    {
        readonly IStudentInfo studentInfo;
        public StudentInfoPresenter(IStudentInfo studentInfo)
        {
            this.studentInfo = studentInfo;

            studentInfo.FormLoad += StudentInfo_FormLoad;
        }

        private void StudentInfo_FormLoad(object sender, EventArgs e)
        {
            var student = DataManager.GetStudents().FindById(studentInfo.SutdentId);

            studentInfo.FirstName = student.FirstName;
            studentInfo.LastName = student.LastName;
            studentInfo.MiddleName = student.MiddleName;

            var query = from s in DataManager.GetStudents().Where(st=>st.Id == student.Id)
                        join m in DataManager.GetMarks() on s.Id equals m.IdSt
                        join sub in DataManager.GetSubjects() on m.IdSub equals sub.Id
                        select new
                        {
                            Subject = sub.Name,
                            Mark = m.Value
                        };

            studentInfo.GridDataSource = query.ToList();

        }
    }
}
