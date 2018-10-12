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
    public partial class MainForm : Form
    {

        ComputerManager computerManager = new ComputerManager();

        public MainForm()
        {
            InitializeComponent();
        }


        private void addPCButton_Click(object sender, EventArgs e)
        {
            AddPC addPC = new AddPC();
            if (addPC.ShowDialog() == DialogResult.OK)
            {
                computerManager.AddComputer(addPC.Computer);
                pcComboBox.DataSource = computerManager.Computers.ToList();
            }

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            if (addTask.ShowDialog() == DialogResult.OK)
            {
                UsersTask usersTask = addTask.UsersTask;
                computerManager.TasksDictionary.Add(usersTask.GetHashCode(), usersTask);
                taskListBox.DataSource = computerManager.TasksDictionary.Values.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taskListBox.DataSource = null;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }
    }
}
