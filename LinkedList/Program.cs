using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.Sorting;

namespace LinkedList
{
    class Program
    {
 
        public static void Main(string[] args)
        {
            //int[] a = { 3, 6, 4, 8, 5, 1, 9 , 2 };

            //MinHeap h = new MinHeap(a);
            //h.RemoveMin();
            //h.RemoveMin();
            //h.RemoveMin();

            //h.Add(2);
            //h.Print();
            //Console.WriteLine();
            //MinHeap pa = new MinHeap(8);
            //pa.Add(3);
            //pa.Add(6);
            //pa.Add(4);
            //pa.Add(8);
            //pa.Add(5);
            //pa.Add(1);
            //pa.Add(9);
            //pa.Add(2);

            //pa.Print();
            //int[] a = { 3, 6, 4, 8, 5, 1, 9, 2, 2, 5, 6, 5, 5, 7, 7, 7 };
            //CountingSort(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}



            //int[] a = { 3, 6, 4, 8, 5, 1, 9, 2 };
            //MergeSort(a,0,7);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            //BinarySearchTree bt = new BinarySearchTree();

            //bt.Add(5);
            //bt.Add(3);
            //bt.Add(1);
            //bt.Add(4);
            //bt.Add(6);
            //bt.Add(7);
            //bt.Add(8);
            //bt.Add(9);
       
            //bt.Print();
            //bt.Delete(5);
            //bt.Print();


            //StackList st = new StackList();
            //st.Push(5);
            //st.Push(4);
            //st.Push(3);
            //st.Push(2);
            //st.Push(1);
            //StackList mid = new StackList();
            //StackList final = new StackList();
            //final = Recursion.Hanoi(st, mid, final, 5);
            //final.Show();
            //st.Show();
            //mid.Show();

            //Console.WriteLine(Iterative.Fibonacci(6));
            //Console.WriteLine(Recursion.Fibonacci(6));
            //Console.WriteLine(Recursion.Fibonacci(0));
            //Console.WriteLine(Recursion.Fibonacci(1));

            //int[] arr = { 888,555, 2255,-33, 48, 56 };
            //Console.WriteLine(Recursion.BinarySearch(arr, 33));
            //Console.WriteLine(Iterative.BinarySearch(arr, 5));

            //Console.WriteLine(Iterative.Index(arr));

            //int[] arr = {2,3,4,5,6,7,8,9 };
            //Console.WriteLine(Iterative.MissingNum(arr));

            //Console.WriteLine(Recursion.BinaryCode(5));
            //Console.WriteLine(Recursion.BinaryCode(8));

            //BigInteger arg1 = new BigInteger(1234);

            //arg1.Show();
            //Console.WriteLine("");
            //BigInteger arg2 = new BigInteger(234);
            //arg2.Show();
            //Console.WriteLine("");

            //BigInteger arg34 = BigInteger.Add(arg2, arg1);
            //arg34.Show();
            ////////Console.WriteLine("");
            ////BigInteger arg4 = BigInteger.Mul(arg2, arg1);
            ////arg4.Show();

            //BigInteger arg3 = BigInteger.Subtract(arg1, arg2);
            //arg3.Show();
            // rec(7, 0);
            //int val = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine( "Linked List example" + "\n");
            //LinkedList List = new LinkedList();
            //List.AddFirst(45);
            //List.AddFirst(22);
            //List.AddFirst(34);
            //List.AddFirst(1);
            //List.AddFirst(22);
            //List.AddFirst(58);
            //List.AddFirst(22);
            //List.AddLast(64);
            //List.Show();

            //Console.WriteLine("\n");
            //List.RemoveItem(22);
            //List.Show();

            //Console.WriteLine("\n");
            //List.Insert(22, 4);
            //List.Insert(22, 1);
            //List.Show();

            //Console.WriteLine("\n");
            //List.Reverce();
            //List.Show();

            //Console.WriteLine("\n"+"Stack Array example"+"\n");
            //StackArray st = new StackArray();
            //st.Push(5);
            //st.Push(54);
            //st.Push(111);
            //st.Push(2);
            //st.Push(8);
            //st.Push(3);
            //st.Show();
            //Console.WriteLine("\n");
            //st.Pop();
            //st.Show();
            //Console.WriteLine("\n");
            //st.Reverce();
            //st.Show();


            Console.Read();
        }

        //public static void rec(int val, int n)
        //{
        //    if (n == val)
        //    {
        //        return;
        //    }
        //    // mulS(val, n);
        //    emptyTri(val, n);
        //    rec(val, n + 1);
        //}
        //public static void mulS(int val, int i)
        //{

        //    int j, k;
        //    for (j = 1; j <= val - i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (k = (val - i); k <= (val); k++)
        //    {
        //        Console.Write("* ");
        //    }

        //    Console.WriteLine("");

        //}
        //public static void emptyTri(int val, int i)
        //{
        //    int j, k;
        //    for (j = 1; j <= val - i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    int t = 0;
        //    for (k = (val - i); k <= (val + i); k++)
        //    {
        //        if (i == val - 1)
        //        {
        //            Console.Write("* ");
        //            t++;
        //            if (t == val)
        //                break;
        //        }
        //        else if (k == (val - i) || k == (val + i))
        //            Console.Write("* ");
        //        else
        //            Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //}


        //static public BigInteger Div(BigInteger arg1, BigInteger arg2)
        //{
        //    BigInteger newBigInt = new BigInteger();
        //    arg1.bigInt.Reverce();
        //    int carry = 0;
        //    int current = 0;
        //    for (int i = 0; i < arg1.bigInt.Count; i++)
        //    {
        //        if (arg1.bigInt.GetFirst() % == 0)
        //        {

        //        }
        //    }
        //    return newBigInt;
        //}

    }
}
