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
    public partial class EditPcForm : Form
    {
        Computer computer;

        public EditPcForm()
        {
            InitializeComponent();
        }

        public EditPcForm(Computer computer) : this()
        {
            this.computer = computer;
            nameTextBox.Text = this.computer.Name;
            onRadioButton.Checked = this.computer.PrepareToWork;
            offRadioButton.Checked = !this.computer.PrepareToWork;
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
