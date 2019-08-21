using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Recursion
    {

        public static void rec(int val, int n)
        {
            if (n == val)
            {
                return;
            }
            // mulS(val, n);
            emptyTri(val, n);
            rec(val, n + 1);
        }
        public static void mulS(int val, int i)
        {

            int j, k;
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = (val - i); k <= (val); k++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("");

        }
        public static void emptyTri(int val, int i)
        {
            int j, k;
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            int t = 0;
            for (k = (val - i); k <= (val + i); k++)
            {
                if (i == val - 1)
                {
                    Console.Write("* ");
                    t++;
                    if (t == val)
                        break;
                }
                else if (k == (val - i) || k == (val + i))
                    Console.Write("* ");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static int BinarySearch(int[] arr, int value)
        {

            return BinarySearchIndex(arr, value, 0, arr.Length - 1, (arr.Length) / 2);
        }
        public static int BinarySearchIndex(int[] arr, int value, int start, int end, int mid)
        {
            if (start > end)
            {
                Console.WriteLine("There arent such element");
                return -1;
            }
            else if (arr[mid] == value)
            {
                return mid;
            }
            else if (arr[mid] > value)
                return BinarySearchIndex(arr, value, start, mid - 1, (mid + start - 1) / 2);
            return BinarySearchIndex(arr, value, mid + 1, end, (mid + end + 1) / 2);
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
            return FibonacciArg(0, 1, count, 0);
        }
        public static int FibonacciArg(int first,int second,int count,int value)
        {
            if (count == 0)
            {
                return value;
            }
            value = second;
            return FibonacciArg(second, second + first, --count, value);
        }

    }
}
