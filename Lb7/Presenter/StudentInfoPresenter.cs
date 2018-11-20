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
        readonly IStudentBoard studentInfo;
        public StudentInfoPresenter(IStudentBoard studentInfo)
        {
            this.studentInfo = studentInfo;

            studentInfo.FormLoad += StudentInfo_FormLoad;
            studentInfo.ClosingForm += StudentInfo_ClosingForm;
        }

        private void StudentInfo_ClosingForm(object sender, EventArgs e)
        {
            EFGenericRepository.SaveChanges();
        }

        private void StudentInfo_FormLoad(object sender, EventArgs e)
        {
            var student = EFGenericRepository.FindById<Students>(studentInfo.SutdentId);

            studentInfo.FirstName = student.FirstName;
            studentInfo.LastName = student.LastName;
            studentInfo.MiddleName = student.MiddleName;

            var marks = from s in EFGenericRepository.Get<Students>().Where(st => st.Id == student.Id)
                        join m in EFGenericRepository.Get<Marks>() on s.Id equals m.IdSt
                        select m;

            studentInfo.GridDataSource = marks.ToList();
        }
    }
}
