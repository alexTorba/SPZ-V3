using System;
using System.Windows.Forms;

using Lb5.Presenter;

namespace Lb5.View
{
	public partial class AddSubjectForm : Form, IAddSubjectForm
	{
		public AddSubjectForm()
		{
			InitializeComponent();
		}

		public string SubjectName => nameTextBox.Text;

		public event EventHandler SaveButton;

		private void saveButton_Click( object sender, EventArgs e )
		{
			SaveButton?.Invoke( sender, e );
			DialogResult = DialogResult.OK;
		}
	}
}
