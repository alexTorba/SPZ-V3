using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.View
{
    interface IAddSubjectForm
    {
        string subjectName { get; }
        event EventHandler SaveButton;
    }
}
