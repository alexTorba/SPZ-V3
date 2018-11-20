using Lb7.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb7.View
{
    public partial class AddStudentForm : Form, IAddStudentFrom
    {
        public AddStudentForm()
        {
            InitializeComponent();

            AddStudentFormPresenter addStudentFormPresenter = new AddStudentFormPresenter(this);
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

        public IList<int> GetCurrentMarks => throw new NotImplementedException();

        public object GridDataSource
        {
            get => dataGridView.DataSource;
            set => dataGridView.DataSource = value;
        }

        public event EventHandler FormLoad;
        public event EventHandler SaveClick;

        #endregion

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            FormLoad?.Invoke(sender, e);
            dataGridView.Columns["IdSt"].Visible = false;
            dataGridView.Columns["IdSub"].Visible = false;
            dataGridView.Columns["Students"].Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(sender, e);
            MessageBox.Show("Added student was successful !");
            DialogResult = DialogResult.OK;
        }

    }
}
