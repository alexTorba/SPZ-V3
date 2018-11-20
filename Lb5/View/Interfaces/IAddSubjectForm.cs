using System;
using System.Windows.Forms;

namespace Lb5.View
{
	interface IAddSubjectForm
	{
		string SubjectName { get; }

		event EventHandler SaveButton;

		DialogResult ShowDialog();
	}
}
