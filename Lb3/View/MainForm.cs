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
            this.pcTasksListBox.DrawItem += Base_DrawItem;
            this.pcTasksListBox.Sorted = false;
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

                if (!computerManager.TasksDictionary.ContainsKey(usersTask.GetHashCode()))
                {
                    computerManager.TasksDictionary.Add(usersTask.GetHashCode(), usersTask);
                    taskListBox.DataSource = computerManager.TasksDictionary.Values.ToList();
                }
                else MessageBox.Show("Task whith the same values has already been added !");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            computerManager.TasksDictionary.Clear();
            taskListBox.DataSource = null;
        }

        /// <summary>
        /// Use when lists change their length to redraw the values of reality
        /// </summary>
        /// <param name="pcTasks">Tasks list of computer</param>
        /// <param name="tasksList">General tasks list</param>
        private void RefreshLists(List<UsersTask> pcTasks, List<UsersTask> tasksList)
        {
            if (pcTasks != null)
                pcTasksListBox.DataSource = pcTasks.ToList();

            if (tasksList != null)
                taskListBox.DataSource = tasksList.ToList();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            UsersTask usersTask = taskListBox.SelectedItem as UsersTask;

            if (usersTask == null) return;

            if (computerManager.TasksDictionary.Count != 0)
                computerManager.TasksDictionary.Remove(usersTask.GetHashCode());

            Computer computer = pcComboBox.SelectedItem as Computer;

            if (!(computer is null))
            {
                computer.Tasks.Add(usersTask);
                RefreshLists(computer.Tasks.ToList(), computerManager.TasksDictionary.Values.ToList());
            }
            else MessageBox.Show("You should choose/add computer !");

        }

        private void pcComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox computers = sender as ComboBox;
            Computer computer = computers.SelectedValue as Computer;

            pcTasksListBox.DataSource = computer.Tasks?.ToList();
        }

        private void ShowInfoOfDoneTask(UsersTask usersTask)
        {
            string taskInfo =
                    $"Task - {usersTask.Name + Environment.NewLine}" +
                    $"Lead time - {usersTask.LeadTime.Millisecond + "ms" + Environment.NewLine}" +
                    $"Date of completion - {usersTask.DateOfCompletion + Environment.NewLine}" +
                    $"Additional info - {usersTask.AdditionalInfomatoins}";
            MessageBox.Show(taskInfo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ((Computer)pcComboBox.SelectedItem).Tasks.Remove(usersTask);
            RefreshLists(((Computer)pcComboBox.SelectedItem).Tasks, null);
        }

        private void pcTasksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListBox listBox = sender as ListBox;
            UsersTask usersTask = listBox.SelectedItem as UsersTask;

            //if task was done - show info and delete task from listBox
            if (usersTask.TaskState == TaskStatus.TaskIsDone)
            {
                ShowInfoOfDoneTask(usersTask);
                return;
            }

            //check the state of computer, if its turn on change state of stateTask and ExecuteTask
            if(!usersTask.PrepareToExecute(((Computer)pcComboBox.SelectedItem).PrepareToWork))
            {
                MessageBox.Show("Turn on the Computer !");
                return;
            }

            listBox.DrawItem -= Base_DrawItem;
            listBox.DrawItem += ExecuteTask_DrawItem;

            //force the listbox to redraw itself (change color and task status)
            listBox.Refresh();
            usersTask.ExecuteTask();


            listBox.DrawItem -= ExecuteTask_DrawItem;
            listBox.DrawItem += Base_DrawItem;

            //force the listbox to redraw itself (change color and task status)
            listBox.Refresh();
        }

        private void Base_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawHandler(sender, e, Color.CadetBlue, Color.White);
        }

        private void ExecuteTask_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawHandler(sender, e, Color.Green, Color.White);
        }

        private void DrawHandler(object sender, DrawItemEventArgs e, Color backCol, Color textCol)
        {
            ListBox listBox = sender as ListBox;

            Color backColor = this.BackColor;
            Color textColor = this.ForeColor;

            if (listBox.Items.Count != 0)
            {
                var txt = listBox.GetItemText(listBox.Items[e.Index]);

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    backColor = backCol;
                    textColor = textCol;
                }

                using (var brush = new SolidBrush(backColor))
                    e.Graphics.FillRectangle(brush, e.Bounds);
                TextRenderer.DrawText(e.Graphics, txt, listBox.Font, e.Bounds, textColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }

        private void taskListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            EditTask editTask = new EditTask((UsersTask)listBox.SelectedItem);
            if (editTask.ShowDialog() == DialogResult.OK)
                RefreshLists(null, computerManager.TasksDictionary.Values.ToList());
        }

        private void pcComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ComboBox checkBox = sender as ComboBox;
            var c = checkBox.SelectedItem as Computer;
            MessageBox.Show(c.Name);

        }


        private void pcComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboBox checkBox = sender as ComboBox;
                EditPcForm editPcForm = new EditPcForm((Computer)checkBox.SelectedItem);
                if (editPcForm.ShowDialog() == DialogResult.OK)
                    pcComboBox.DataSource = computerManager.Computers.ToList();
            }
        }
    }
}
