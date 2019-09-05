using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StackList<T> where T : IComparable
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T value)
        {
            list.AddFirst(value);
        }
        public T Pop()
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
