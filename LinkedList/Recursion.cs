using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Recursion
    {
        public static int BinarySearch(int[] arr, int value)
        {

            return BinarySearchIndex(arr, value, 0, arr.Length - 1);
        }
        public static int BinarySearchIndex(int[] arr, int value, int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine("There arent such element");
                return -1;
            }
            else if (arr[(end + start) / 2] == value)
            {
                return (end + start) / 2;
            }
            else if (arr[(end + start) / 2] > value)
                return BinarySearchIndex(arr, value, start, (end + start) / 2 - 1);
            return BinarySearchIndex(arr, value, (end + start) / 2 + 1, end);
        }

        public static int BinaryCode(int value)
        {
            if (value / 2 == 0)
            {
                return value;
            }
            return BinaryCode(value / 2) * 10 + (value % 2);
        }

        public static int Fibonacci(int count)
        {
            return FibonacciArg(0, 1, count);
        }
        public static int FibonacciArg(int first, int second, int count)
        {
            if (count == 0)
            {
                return first;
            }
            return FibonacciArg(second, second + first, --count);
        }

        public static StackList<string> Hanoi(StackList<string> first, StackList<string> mid, StackList<string> final, int count)
        {
            if (count == 0)
            {
                return null;
            }
            Hanoi(first, final, mid, count - 1);
            final.Push(first.Pop());
            Hanoi(mid, first, final, count - 1);
            return final;
        }
    }
}
