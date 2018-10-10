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
    public partial class AddUniversity : Form
    {

        University university;

        internal University University
        {
            get
            {
                if (university != null)
                    return university;
                return null;
            }
            private set => university = value;
        }

        public AddUniversity()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTextBox.Text) &&
                employeesNumericUpDown.Value != 0 &&
                facultyesNumericUpDown.Value != 0 &&
                laboratoriesNumericUpDown.Value != 0 &&
                lectureHallsNumericUpDown.Value != 0 &&
                professorsNumericUpDown.Value != 0 &&
                studentsNumericUpDown.Value != 0)
            {

                University = new University
                {
                    Name = nameTextBox.Text,
                    CountEmployee = (int)employeesNumericUpDown.Value,
                    CountFaculty = (int)facultyesNumericUpDown.Value,
                    CountLaboratories = (int)laboratoriesNumericUpDown.Value,
                    CountLectureHalls = (int)lectureHallsNumericUpDown.Value,
                    CountProfessors = (int)professorsNumericUpDown.Value,
                    CountStudents = (int)studentsNumericUpDown.Value
                };
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Values can't be empty !");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void professorsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown professors = sender as NumericUpDown;

            if (!((studentsNumericUpDown.Value - (10 * (professorsNumericUpDown.Value - 1))) > 0))
            {
                MessageBox.Show("Proffessor can have up to 10 students");
                if (professors.Value >= 1)
                    professors.DownButton();
            }

        }

        private void employeesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown employee = sender as NumericUpDown;

            if (!((laboratoriesNumericUpDown.Value + lectureHallsNumericUpDown.Value) - (2 * (employee.Value - 1)) > 0))
            {
                MessageBox.Show("Employee can have up to 2 audience");
                if (employee.Value >= 1)
                    employee.DownButton();
            }
        }
    }
}
