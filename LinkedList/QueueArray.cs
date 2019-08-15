using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class QueueArray
    {
        private int[] arr = new int[1000];
        private int count = 0;

        public int Count { get => count; private set => count = value; }

        public void Enqueue(int value)
        {
            if (Count == 1000)
            {
                Console.WriteLine("Is full");
                return;
            }
            arr[Count] = value;
            Count++;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty");
                return 0;
            }
            Count--;
            return arr[Count];
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        public int Peek()
        {
            return arr[0];
        }
        public void Reverce()
        {
            int curCount = Count;
            int current;
            for (int i = 0; i <= curCount / 2; i++)
            {
                current = arr[i];
                arr[i] = arr[--curCount];
                arr[curCount] = current;
            }
        }
        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

    }
}
