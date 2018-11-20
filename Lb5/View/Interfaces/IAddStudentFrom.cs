using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lb5.View
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

		DialogResult ShowDialog();
	}
}
