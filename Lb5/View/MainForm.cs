using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb5
{
    public partial class MainForm : Form
    {
        BindingList<Student> students = new BindingList<Student>();

        public MainForm()
        {
            InitializeComponent();

            //bindingSource.DataSource = students;
            //dataGridView.DataSource = bindingSource;
        }

        private void CreateSubjectForDataGrid(List<Subject> subjects)
        {
            foreach (Subject subject in subjects)
            {
                int i = dataGridView.Columns.Add(subject.Name, subject.Name);
                dataGridView.Rows.Insert(i, (object)subject.Mark);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            students.Add(new Student("Alex", "Torba", "Olegovich")
            {
                subjects = new List<Subject>
                {
                    new Subject("Mathematics", 75),
                    new Subject("English", 76)
                }
            });

            students.Add(new Student("Valera", "Tchupikov", "Vlademerovich")
            {
                subjects = new List<Subject>
                {
                    new Subject("Mathematics", 60),
                    new Subject("English", 75)
                }
            });

            CreateSubjectForDataGrid(this.students[0].subjects);

        }


    }
}
