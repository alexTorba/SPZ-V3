using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.View
{
    interface IStudentInfo
    {
        int SutdentId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }


        object GridDataSource { get; set; }
        event EventHandler FormLoad;
    }
}
