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
    public partial class EditUniversity : Form
    {
        University university;
        bool isLoad = false;
        public EditUniversity()
        {
            InitializeComponent();
        }

        public University GetUniversity
        {
            get
            {
                if (DialogResult == DialogResult.OK)
                    return university;
                return null;
            }
        }

        public EditUniversity(University university) : this()
        {
            //обьект, который будет меняться
            this.university = new University(university);
        }

        private void EditUniversity_Load(object sender, EventArgs e)
        {
            isLoad = true;

            nameTextBox.Text = university.Name;
            employeesNumericUpDown.Value = university.CountEmployee;
            facultyesNumericUpDown.Value = university.CountFaculty;
            laboratoriesNumericUpDown.Value = university.CountLaboratories;
            lectureHallsNumericUpDown.Value = university.CountLectureHalls;
            professorsNumericUpDown.Value = university.CountProfessors;
            studentsNumericUpDown.Value = university.CountStudents;

            isLoad = false;
        }

        private void employeesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown employee = sender as NumericUpDown;

            if (!((laboratoriesNumericUpDown.Value + lectureHallsNumericUpDown.Value) - (2 * (employee.Value - 1)) > 0) && !isLoad)
            {
                MessageBox.Show("Employee can have up to 2 audience");
                if (employee.Value >= 1)
                    employee.DownButton();
            }

            if (employee.Value > university.CountEmployee)
                university.AddEmployee((int)employee.Value - university.CountEmployee);
            else
                university.RemoveEmployee(university.CountEmployee - (int)employee.Value);
        }

        private void professorsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown professors = sender as NumericUpDown;

            if (!((studentsNumericUpDown.Value - (10 * (professorsNumericUpDown.Value - 1))) > 0) && !isLoad)
            {
                MessageBox.Show("Proffessor can have up to 10 students");
                if (professors.Value >= 1)
                    professors.DownButton();
            }

            if (professors.Value > university.CountProfessors)
                university.AddProfessors((int)professors.Value - university.CountProfessors);
            else
                university.RemoveProfessors(university.CountProfessors - (int)professors.Value);

        }

        private void laboratoriesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown lab = sender as NumericUpDown;

            if (lab.Value > university.CountLaboratories)
                university.AddLaboratories((int)lab.Value - university.CountLaboratories);
            else
                university.RemoveLaboratories(university.CountLaboratories - (int)lab.Value);
        }

        private void lectureHallsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown lect = sender as NumericUpDown;

            if (lect.Value > university.CountLectureHalls)
                university.AddLectureHalls((int)lect.Value - university.CountLectureHalls);
            else
                university.RemoveLectureHalls(university.CountLectureHalls - (int)lect.Value);
        }

        private void studentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown student = sender as NumericUpDown;

            if (student.Value > university.CountStudents)
                university.AddStudent((int)student.Value - university.CountStudents);
            else
                university.RemoveStudent(university.CountStudents - (int)student.Value);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
