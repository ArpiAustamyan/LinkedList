using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;
using static LinkedList.StackArray;
using static LinkedList.QueueArray;
using static LinkedList.BigInteger;
using static LinkedList.Recursion;
using static LinkedList.Iterative;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine( "Linked List example" + "\n");
            LinkedList List = new LinkedList();
            List.AddFirst(45);
            List.AddFirst(22);
            List.AddFirst(34);
            List.AddFirst(1);
            List.AddFirst(22);
            List.AddFirst(58);
            List.AddFirst(22);
            List.AddLast(64);
            List.Show();

            Console.WriteLine("\n");
            List.RemoveItem(22);
            List.Show();

            Console.WriteLine("\n");
            List.Insert(22, 4);
            List.Insert(22, 1);
            List.Show();

            Console.WriteLine("\n");
            List.Reverce();
            List.Show();

            Console.WriteLine("\n"+"Stack Array example"+"\n");
            StackArray st = new StackArray();
            st.Push(5);
            st.Push(54);
            st.Push(111);
            st.Push(2);
            st.Push(8);
            st.Push(3);
            st.Show();
            Console.WriteLine("\n");
            st.Pop();
            st.Show();
            Console.WriteLine("\n");
            st.Reverce();
            st.Show();


            Console.Read();
        }
    }
}
