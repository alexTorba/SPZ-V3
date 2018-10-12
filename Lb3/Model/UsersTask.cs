using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lb3
{
    public class UsersTask
    {
        public string Name { get; set; }
        /// <summary>
        /// Value in seconds
        /// </summary>
        public DateTime LeadTime { get; set; }
        public DateTime DateOfCcompletion { get; set; }
        public bool IsDone { get; set; }
        public string AdditionalInfomatoins { get; set; }

        public UsersTask()
        {

        }

        public UsersTask(UsersTask usersTask)
        {
            Name = usersTask.Name;
            LeadTime = usersTask.LeadTime;
            DateOfCcompletion = usersTask.DateOfCcompletion;
            IsDone = usersTask.IsDone;
            AdditionalInfomatoins = usersTask.AdditionalInfomatoins;
        }

        private int GetTimeToExecuteTask()
        {
            return new Random((int)DateTime.Now.Ticks).Next(0, 15);
        }

        public void ExecuteTask()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < GetTimeToExecuteTask(); i++)
            {
                Thread.Sleep(10);
            }
            stopwatch.Start();

            LeadTime = new DateTime().AddMilliseconds(stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            DateOfCcompletion = DateTime.Now;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var task = obj as UsersTask;
            return task != null &&
                   Name == task.Name &&
                   LeadTime == task.LeadTime &&
                   DateOfCcompletion == task.DateOfCcompletion &&
                   IsDone == task.IsDone &&
                   AdditionalInfomatoins == task.AdditionalInfomatoins;
        }

        public override int GetHashCode()
        {
            var hashCode = -1765437687;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + LeadTime.GetHashCode();
            hashCode = hashCode * -1521134295 + DateOfCcompletion.GetHashCode();
            hashCode = hashCode * -1521134295 + IsDone.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AdditionalInfomatoins);
            return hashCode;
        }
    }
}
