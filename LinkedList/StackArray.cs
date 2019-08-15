using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StackArray
    {
        private int []arr=new int[1000];
        private int count;
        public int Count { get => count; private set => count = value; }

        public void Push(int value)
        {
            if (Count == 1000)
            {
                Console.WriteLine("Is full");
                return;
            }
            arr[Count] = value;
            Count++;
        }
        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("IsEmpty:");
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
            return arr[Count - 1];
        }
        public void Reverce()
        {
            int curCount = Count;
            int current;
            for (int i = 0; i <= curCount/2; i++)
            {
                current = arr[i];
                arr[i] = arr[--curCount];
                arr[curCount] = current;
            }
        }
        public void Show()
        {
            for (int i = Count-1; i >=0 ; i--)
            {
                Console.Write(arr[i]+"\t");
            }
        }
    }
}
