using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lb7.Presenter;

namespace Lb7.View
{
    public partial class StudentInfoForm : Form, IStudentInfo
    {
        public StudentInfoForm(int id)
        {
            InitializeComponent();

            SutdentId = id;

            StudentInfoPresenter studentInfoPresenter = new StudentInfoPresenter(this);

        }

        public int SutdentId { get; }

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

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}
