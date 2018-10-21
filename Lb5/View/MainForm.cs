using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb5
{
    public partial class MainForm : Form
    {
        BindingList<Student> students = new BindingList<Student>();

        BindingSource binding = new BindingSource();

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
                Subjects = new BindingList<Subject>
                {
                    new Subject("Mathematics", 75),
                    new Subject("English", 76)
                }
            });

            students.Add(new Student("Valera", "Tchupikov", "Vlademerovich")
            {
                Subjects = new BindingList<Subject>
                {
                    new Subject("Mathematics", 60),
                    new Subject("English", 75)
                }
            });

            binding.DataSource = students;
            dataGridView.DataSource = binding;
            
        }

        //private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    MessageBox.Show(dataGridView.Rows[e.RowIndex].DataBoundItem.ToString());

        //    if ((dataGridView.Rows[e.RowIndex].DataBoundItem != null) &&
        //      (dataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
        //    {
        //        e.Value = BindProperty(
        //                      dataGridView.Rows[e.RowIndex].DataBoundItem,
        //                      dataGridView.Columns[e.ColumnIndex].DataPropertyName
        //                    );
        //    }
        //}

        //private string BindProperty(object property, string propertyName)
        //{
        //    string retValue = "";

        //    if (propertyName.Contains("."))
        //    {
        //        PropertyInfo[] arrayProperties;
        //        string leftPropertyName;

        //        leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
        //        arrayProperties = property.GetType().GetProperties();

        //        foreach (PropertyInfo propertyInfo in arrayProperties)
        //        {
        //            if (propertyInfo.Name == leftPropertyName)
        //            {
        //                retValue = BindProperty(
        //                  propertyInfo.GetValue(property, null),
        //                  propertyName.Substring(propertyName.IndexOf(".") + 1));
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Type propertyType;
        //        PropertyInfo propertyInfo;

        //        propertyType = property.GetType();
        //        propertyInfo = propertyType.GetProperty(propertyName);
        //        retValue = propertyInfo.GetValue(property, null).ToString();
        //    }

        //    return retValue;
        //}
    }
}
