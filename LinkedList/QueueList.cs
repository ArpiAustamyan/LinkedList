using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class QueueList<T> where T : IComparable
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T value)
        {
            list.AddLast(value);
        }
        public T Dequeue()
        {
            return list.RemoveFirst();
        }
        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
        public T Peek()
        {
            return list.GetFirst();
        }
        public int Count()
        {
            return list.Count;
        }
        public void Reverce()
        {
            list.Reverce();
        }
        public void Show()
        {
            list.Show();
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
