using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;

namespace LinkedList
{
    public class StackList
    {
        private LinkedList list;

        public void Push(int value)
        {
            list.AddFirst(value);
        }
        public int Pop()
        {
            return list.RemoveFirst();
        }
        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
        public int Peek()
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
    }
}
