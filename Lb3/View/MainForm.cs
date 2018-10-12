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

        private void clearButton_Click(object sender, EventArgs e)
        {
            taskListBox.DataSource = null;
        }

        private void RefreshLists(List<UsersTask> pcTasks, List<UsersTask> tasksList)
        {
            pcTasksListBox.DataSource = pcTasks.ToList();
            taskListBox.DataSource = tasksList.ToList();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            UsersTask usersTask = taskListBox.SelectedItem as UsersTask;

            if (computerManager.TasksDictionary.Count != 0)
                computerManager.TasksDictionary.Remove(usersTask.GetHashCode());

            Computer computer = pcComboBox.SelectedItem as Computer;

            computer.Tasks.Add(usersTask); 

            RefreshLists(computer.Tasks, computerManager.TasksDictionary.Values.ToList());

        }

        private void pcComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox computers = sender as ComboBox;
            Computer computer = computers.SelectedValue as Computer;

            pcTasksListBox.DataSource = computer.Tasks?.ToList();
        }

        private void pcTasksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("pcTasksListBox_MouseDoubleClick ");
        }
    }
}
