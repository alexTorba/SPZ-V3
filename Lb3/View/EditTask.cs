using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb3
{
    public partial class EditTask : Form
    {
        UsersTask usersTask;

        public EditTask()
        {
            InitializeComponent();
        }

        public EditTask(UsersTask usersTask) : this()
        {
            this.usersTask = usersTask;
            nameTextBox.Text = usersTask.Name;
            infoTextBox.Text = usersTask.AdditionalInfomatoins;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            usersTask.Name = nameTextBox.Text;
            usersTask.AdditionalInfomatoins = infoTextBox.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
