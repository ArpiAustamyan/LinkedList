using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.StackList;

namespace LinkedList
{
    public static class Iterative
    {
        public static int Index(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i+1])
                    continue;
                return i ;
            }
            return - 1;
        }

        public static int MissingNum(int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                num += arr[i];
            }
            return (arr.Length + 1) * (arr.Length + 2) / 2 - num;
        }

        public static int Fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }
            int num1 = 0;
            int num2 = 1;
            int k;
            while (num != 1)
            {
                k = num1;
                num1 = num2;
                num2 += k;
                num--;
            }
            return num2;
        }

        public static int BinarySearch(int[] arr, int value)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end + 1) / 2;
                if (value == arr[mid])
                {
                    return mid;
                }
                else if (value < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            Console.WriteLine("There arent such element");
            return -1;
        }
        public static void Triangle(int val)
        {
            int i, j, k;
            for (i = 0; i < val; i++)
            {
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
        }
        public static void emptyTriangle(int val)
        {
            int i, j, k;
            for (i = 0; i < val; i++)
            {
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
                        if (t == val - 2)
                            break;
                    }
                    if (k == (val - i) || k == (val + i))
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

    }
}
