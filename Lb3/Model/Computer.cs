using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3
{
    class Computer
    {
        public string Name { get; set; }
        public List<UsersTask> Tasks { get; set; }
        public int CountOfTasks { get => Tasks.Count; }
        public bool PrepareToWork { get; set; }

        public static bool operator ==(Computer first, Computer second)
        {
            if (first == second)
                return true;

            if (first.Tasks.SequenceEqual(second.Tasks) &&
               first.CountOfTasks == second.CountOfTasks &&
               first.PrepareToWork == second.PrepareToWork)
                return true;

            return false;
        }

        public static bool operator !=(Computer first, Computer second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            var computer = obj as Computer;
            return computer != null &&
                   Name == computer.Name &&
                   EqualityComparer<List<UsersTask>>.Default.Equals(Tasks, computer.Tasks) &&
                   CountOfTasks == computer.CountOfTasks &&
                   PrepareToWork == computer.PrepareToWork;
        }

        public override int GetHashCode()
        {
            var hashCode = -936242408;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<UsersTask>>.Default.GetHashCode(Tasks);
            hashCode = hashCode * -1521134295 + CountOfTasks.GetHashCode();
            hashCode = hashCode * -1521134295 + PrepareToWork.GetHashCode();
            return hashCode;
        }

    }
}
