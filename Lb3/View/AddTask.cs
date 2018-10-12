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
    public partial class AddTask : Form
    {
        UsersTask usersTask = new UsersTask();

        public UsersTask UsersTask
        {
            get
            {
                if (DialogResult == DialogResult.OK)
                    return usersTask;

                return null;
            }
        }

        public AddTask()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            usersTask.Name = nameTextBox.Text;
            usersTask.AdditionalInfomatoins = infoTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
