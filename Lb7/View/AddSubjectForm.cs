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
    public partial class AddSubjectForm : Form, IAddSubjectForm
    {
        public AddSubjectForm()
        {
            InitializeComponent();

            AddSubjectFormPresenter addStudentFormPresenter = new AddSubjectFormPresenter(this);
        }

        public string subjectName => nameTextBox.Text;

        public event EventHandler SaveButton;

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButton?.Invoke(sender, e);
            DialogResult = DialogResult.OK;
        }
    }
}
