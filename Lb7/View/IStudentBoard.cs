using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb7.View
{
    interface IStudentBoard
    {
        int SutdentId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        IList<int> GetCurrentMarks { get; }
        object GridDataSource { get; set; }
        event EventHandler FormLoad;
        event EventHandler ClosingForm;
    }
}
