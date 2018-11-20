using System;
using System.Windows.Forms;

namespace Lb5.View
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
		event EventHandler AddSubject;
		event EventHandler AddStudent;
		event EventHandler EditStudent;

		DialogResult ShowDialog();
	}
}
