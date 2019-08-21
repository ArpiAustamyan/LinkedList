using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;

namespace LinkedList
{
    public class BigInteger
    {
        private LinkedList bigInt = new LinkedList();

        private BigInteger() { }
        public BigInteger(int value)
        {
            while (value != 0)
            {
                bigInt.AddLast((value % 10));
                value /= 10;
            }

        }
        static public BigInteger Add(BigInteger arg1, BigInteger arg2)
        {
            BigInteger newBigInt = new BigInteger();
            int current = 0;
            int count1 = arg1.bigInt.Count;
            int count2 = arg2.bigInt.Count;

            if (arg1.bigInt.Count > arg2.bigInt.Count)
            {
                int k = count1;
                count1 = count2;
                count2 = k;
            }

            int first = arg1.bigInt.GetFirst();

            for (int i = 0; i < count1; i++)
            {
                newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() + arg2.bigInt.GetFirst()) % 10 + current);
                current = (arg1.bigInt.GetFirst() + arg2.bigInt.GetFirst()) / 10;
                arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
                arg2.bigInt.AddLast(arg2.bigInt.RemoveFirst());
            }
            for (int i = count1; i < count2; i++)
            {
                if (arg1.bigInt.Count == count1)
                {
                    newBigInt.bigInt.AddLast(arg2.bigInt.GetFirst() + current);
                    current = 0;
                }
                else
                {
                    newBigInt.bigInt.AddLast(arg1.bigInt.GetFirst() + current);
                    current = 0;
                }
            }
            newBigInt.bigInt.AddLast(current);
            return newBigInt;
        }

        static public BigInteger Subtract(BigInteger arg1, BigInteger arg2)
        {
            BigInteger newBigInt = new BigInteger();
            int current = 0;
            if (arg1.bigInt.Count < arg2.bigInt.Count)
            {
                Console.WriteLine("Subtract cant be done:");
                return newBigInt;
            }
            for (int i = 0; i < arg1.bigInt.Count && i < arg2.bigInt.Count; i++)
            {
                if ((arg1.bigInt.GetFirst() - arg2.bigInt.GetFirst()) > 0)
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() - current - arg2.bigInt.GetFirst()));
                    current = 0;
                }
                else
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() + 10 - current - arg2.bigInt.GetFirst()));
                    current = 1;
                }
                arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
                arg2.bigInt.AddLast(arg2.bigInt.RemoveFirst());
            }

            for (int i = arg2.bigInt.Count; i < arg1.bigInt.Count; i++)
            {
                newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() - current));
                current = 0;
                arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
            }
            return newBigInt;

        }

        public void Show()
        {
            if (bigInt == null)
                return;
            bigInt.Reverce();
            bigInt.Show();
            bigInt.Reverce();
        }
    }
}
