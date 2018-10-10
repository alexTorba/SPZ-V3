using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2_V2._0
{
    public partial class MergeUniversities : Form
    {
        University university;
        public University University
        {
            get
            {
                if (DialogResult == DialogResult.OK)
                    return university;

                return null;
            }
        }

        List<University> universities;

        public MergeUniversities()
        {
            InitializeComponent();
        }

        public MergeUniversities(List<University> universities) : this()
        {
            this.universities = universities;

            firstListBox.DataSource = universities.GetNamesUniverstyes();
            secondListBox.DataSource = universities.GetNamesUniverstyes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            University first = this.universities.FindByName(firstListBox.SelectedValue.ToString());
            University second = this.universities.FindByName(secondListBox.SelectedValue.ToString());

            this.university = first + second;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
