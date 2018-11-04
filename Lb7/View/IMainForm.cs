using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.View
{
    interface IMainForm
    {
        event EventHandler LoadForm;
        object StudentGridDataSource { get; set; }
        object SubjectGridDataSource { get; set; }
    }
}
