using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3
{
    class ComputerManager
    {
        public BindingList<Computer> Computers { get; set; }
        public Dictionary<int, UsersTask> TasksDictionary { get; set; }
        public int CountOfComputers { get => Computers.Count; }
        public int NumberOfJobs { get; set; }
        public bool AvailabilityOfRouter { get; set; }
        public string WiFiPassword { get; set; }

        public ComputerManager()
        {
            Computers = new BindingList<Computer>();
            TasksDictionary = new Dictionary<int, UsersTask>();
        }

        #region Methods

        public void AssignTaskToComputer(UsersTask usersTask, Computer computer)
        {
            UsersTask task = TasksDictionary.First(t => t.Key == usersTask.GetHashCode()).Value;

            Computer comp = Computers.First(c => c.Equals(computer));

            comp.Tasks.Add(task);
        }

        public void RemoveTaskFromComputer(UsersTask usersTask, Computer computer)
        {
            UsersTask task = TasksDictionary.First(t => t.Key == usersTask.GetHashCode()).Value;

            Computer comp = Computers.First(c => c.Equals(computer));

            comp.Tasks.Remove(task);
        }

        public void AddComputer(Computer computer)
        {
            Computers.Add(computer);
        }

        public void RemoveComputer(Computer computer)
        {
            Computers.Remove(computer);
        }

        public void InstallRouter()
        {
            AvailabilityOfRouter = true;
        }

        public void DeinstallRouter()
        {
            AvailabilityOfRouter = false;
        }

        public void AddTask(UsersTask task)
        {
            TasksDictionary.Add(task.GetHashCode(), task);
        }

        public void RemoveTask(UsersTask task)
        {
            TasksDictionary.Remove(task.GetHashCode());
        }

        public bool СomparisonPfComputers(Computer first, Computer second)
        {
            return first.Equals(second);
        }

        #endregion
    }
}
