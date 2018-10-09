using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    class Employee<T> : ICollection<T> where T : class
    {
        public string Name { get; set; }
        private readonly List<T> audience = new List<T>();

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(string name, params T[] audience) : this(name)
        {
            this.audience.AddRange(audience);
        }

        public int Count => audience.Count;

        public bool IsReadOnly => false;

        public void Add(T auditory)
        {
            if (Count < 2)
                audience.Add(auditory);
            else throw new ArgumentOutOfRangeException("Staff can have up to 2 audience");
        }

        public void Clear()
        {
            audience.Clear();
        }

        public bool Contains(T auditory)
        {
            return audience.Contains(auditory);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            audience.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T auditory in audience)
                yield return auditory;
        }

        public bool Remove(T audience)
        {
            return this.audience.Remove(audience);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (T auditory in audience)
                yield return auditory;
        }
    }
}
