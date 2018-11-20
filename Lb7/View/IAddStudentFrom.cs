using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.View
{
    interface IAddStudentFrom
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        IList<int> GetCurrentMarks { get; }
        object GridDataSource { get; set; }

        event EventHandler FormLoad;
        event EventHandler SaveClick;
    }
}
