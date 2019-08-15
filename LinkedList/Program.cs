using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList List = new LinkedList();
            Console.WriteLine(List.IsEmpty());
            List.AddFirst(45);
            List.AddFirst(22);
            List.AddFirst(34);
            List.AddFirst(1);
            List.AddFirst(22);
            List.AddFirst(58);
            List.AddFirst(22);
            List.AddLast(64);

            Console.WriteLine(List.IsEmpty()+"\n"); 
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


            Console.Read();
        }
    }
}
