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
    public partial class MainForm : Form
    {

        List<University> universities = new List<University>();

        public MainForm()
        {
            InitializeComponent();

            Binding();
        }

        public void Binding()
        {
            dataGrid.DataSource = universities.ToList();
            dataGrid.Refresh();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniversity addUniversity = new AddUniversity();
            if (addUniversity.ShowDialog() == DialogResult.OK)
            {
                universities.Add(addUniversity.University);
                Binding();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;

            University choosenUn = (University)universities.FindById((int)dataGrid.SelectedRows[0].Cells[0].Value);

            EditUniversity editUniversity = new EditUniversity(choosenUn);

            if (editUniversity.ShowDialog() == DialogResult.OK)
            {
                universities.ChangeUniversityById(choosenUn.Id, editUniversity.GetUniversity);
                Binding();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MergeUniversities mergeUniversities = new MergeUniversities(universities);
            if (mergeUniversities.ShowDialog() == DialogResult.OK)
            {
                this.universities.Add(mergeUniversities.University);
                Binding();
            }
        }
    }
}
