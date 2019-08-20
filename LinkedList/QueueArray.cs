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

        private int inE=-1;
        private int outE = -1;
        public void Enqueue(int value)
        {
            if (inE == outE && inE != -1)
            {
                Console.WriteLine("Is full");
                return;
            }
            else if (inE + 1 == 1000)
            {
                arr[inE % 1000] = value;
                inE = 0;
            }
            else
            {
                arr[inE] = value;
                inE++;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty");
                return 0;
            }
            Count--;
            int k = outE;
            if (Count == 0)
                outE = -1;
            else if (outE + 1 == 1000)
                outE = 0;
            else
                outE++;
            return arr[k];
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        public int Peek()
        {
            return arr[outE];
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
