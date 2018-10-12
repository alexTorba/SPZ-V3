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
    public partial class AddPC : Form
    {

        Computer computer = new Computer();

        internal Computer Computer
        {
            get
            {
                if (DialogResult == DialogResult.OK)
                    return computer;

                return null;
            }
        }

        public AddPC()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            computer.Name = nameTextBox.Text;
            computer.PrepareToWork = onRadioButton.Checked;

            DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
