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
    public partial class StudentInfoForm : Form, IStudentBoard
    {
        List<int> marks = new List<int>();

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

        public IList<int> GetCurrentMarks => marks;


        public event EventHandler FormLoad;
        public event EventHandler ClosingForm;

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
            dataGridView.Columns["IdSt"].Visible = false;
            dataGridView.Columns["IdSub"].Visible = false;
            dataGridView.Columns["Students"].Visible = false;
        }

        private void StudentInfoForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ClosingForm?.Invoke(sender, e);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.CurrentCell.ReadOnly = false;
        }
    }
}
