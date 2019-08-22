using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;

namespace LinkedList
{
    public class QueueList
    {
        private LinkedList list=new LinkedList();

        public void Enqueue(int value)
        {
            list.AddLast(value);
        }
        public int Dequeue()
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
        public void Show()
        {
            list.Show();
        }
    }
}
