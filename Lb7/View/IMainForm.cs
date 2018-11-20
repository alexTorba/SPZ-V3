using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.View
{
    interface IMainForm
    {
        object StudentGridDataSource { get; set; }
        object SubjectGridDataSource { get; set; }

        object CurrentStudentRow { get; }
        object CurrentSubjectRow { get; }
        event EventHandler DeleteStudent;
        event EventHandler DeleteSubject;
        event EventHandler LoadForm;
        event EventHandler ClosingForm;
    }
}
