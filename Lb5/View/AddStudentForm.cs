using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Lb5.Presenter;

namespace Lb5.View
{
	public partial class AddStudentForm : Form, IAddStudentFrom
	{
		public AddStudentForm()
		{
			InitializeComponent();
		}

		#region IStudent

		public string FirstName
		{
			get => firstNameTextBox.Text;
			set => firstNameTextBox.Text = value;
		}
		public string LastName
		{
			get => lastNameTextBox.Text;
			set => lastNameTextBox.Text = value;
		}
		public string MiddleName
		{
			get => middleNameTextBox.Text;
			set => middleNameTextBox.Text = value;
		}
		public object GridDataSource
		{
			get => dataGridView.DataSource;
			set => dataGridView.DataSource = value;
		}

		public event EventHandler FormLoad;
		public event EventHandler SaveClick;

		#endregion

		private void AddStudentForm_Load( object sender, EventArgs e )
		{
			FormLoad?.Invoke( sender, e );
		}

		private void saveButton_Click( object sender, EventArgs e )
		{
			SaveClick?.Invoke( sender, e );
			MessageBox.Show( "Added student was successful !" );
			DialogResult = DialogResult.OK;
		}
	}
}
