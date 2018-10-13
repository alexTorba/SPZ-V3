using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lb3
{
    public enum TaskStatus
    {
        NotPerformed,
        TaskInProgress,
        TaskIsDone
    }

    public class UsersTask
    {
        public string Name { get; set; }
        /// <summary>
        /// Value in seconds
        /// </summary>
        public DateTime LeadTime { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public TaskStatus TaskState { get; private set; } = TaskStatus.NotPerformed;
        public string AdditionalInfomatoins { get; set; }

        public UsersTask()
        {

        }

        public UsersTask(UsersTask usersTask)
        {
            Name = usersTask.Name;
            LeadTime = usersTask.LeadTime;
            DateOfCompletion = usersTask.DateOfCompletion;
            TaskState = usersTask.TaskState;
            AdditionalInfomatoins = usersTask.AdditionalInfomatoins;
        }

        private int GetTimeToExecuteTask()
        {
            return new Random((int)DateTime.Now.Ticks).Next(10, 30);
        }

        public void PrepareToExecute()
        {
            TaskState = TaskStatus.TaskInProgress;
        }

        public void ExecuteTask()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < GetTimeToExecuteTask(); i++)
            {
                Thread.Sleep(100);
            }
            stopwatch.Stop();
            TaskState = TaskStatus.TaskIsDone;

            LeadTime = new DateTime().AddMilliseconds(stopwatch.Elapsed.TotalMilliseconds);
            DateOfCompletion = DateTime.Now;

            stopwatch.Reset();

        }

        public override string ToString()
        {
            if (TaskState == TaskStatus.TaskIsDone)
                return $"{Name}   {LeadTime.Millisecond}ms(done)";
            else if (TaskState == TaskStatus.TaskInProgress)
                return $"{Name}   (task in progress)";

            return $"{Name}";
        }

        public override bool Equals(object obj)
        {
            var task = obj as UsersTask;
            return task != null &&
                   Name == task.Name &&
                   LeadTime == task.LeadTime &&
                   DateOfCompletion == task.DateOfCompletion &&
                   TaskState == task.TaskState &&
                   AdditionalInfomatoins == task.AdditionalInfomatoins;
        }

        public override int GetHashCode()
        {
            var hashCode = -1765437687;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + LeadTime.GetHashCode();
            hashCode = hashCode * -1521134295 + DateOfCompletion.GetHashCode();
            hashCode = hashCode * -1521134295 + TaskState.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AdditionalInfomatoins);
            return hashCode;
        }

    }
}
