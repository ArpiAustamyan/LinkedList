using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList<int>;

namespace LinkedList
{
    public class BigInteger
    {
        private LinkedList<int> bigInt = new LinkedList<int>();

        private BigInteger() { }
        public BigInteger(int value)
        {
            if (value == 0)
                bigInt.AddLast(0);
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
                    newBigInt.bigInt.AddLast((arg2.bigInt.GetFirst() + current)%10);
                    current = (arg1.bigInt.GetFirst() + arg2.bigInt.GetFirst()) / 10;
                    arg2.bigInt.AddLast(arg2.bigInt.RemoveFirst());
                }
                else
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() + current)%10);
                    current = (arg1.bigInt.GetFirst() + arg2.bigInt.GetFirst()) / 10;
                    arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
                }
            }
            if (current != 0)
                newBigInt.bigInt.AddLast(current);
            return newBigInt;
        }

        static public BigInteger Subtract(BigInteger arg1, BigInteger arg2)
        {
            BigInteger newBigInt = new BigInteger();
            int current = 0;
            int k = 0;
            for (int i = 0; i < arg2.bigInt.Count; i++)
            {
                if (arg1.bigInt.GetFirst() >= arg2.bigInt.GetFirst())
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() - current - arg2.bigInt.GetFirst()));
                    current = 0;
                    if (arg1.bigInt.GetFirst() == arg2.bigInt.GetFirst())
                        k++;
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
                if (arg1.bigInt.GetFirst() >= current)
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() - current));
                    current = 0;
                }
                else
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() + 10 - current));
                    current = 1;
                }
                arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
            }
            if (k == newBigInt.bigInt.Count)
            {
                for (int i = 1; i < newBigInt.bigInt.Count; i++)
                    newBigInt.bigInt.RemoveFirst();
            }
            if (newBigInt.bigInt.Count != 1)
            {
                newBigInt.bigInt.Reverce();
                while (newBigInt.bigInt.GetFirst() == 0)
                    newBigInt.bigInt.RemoveFirst();
                newBigInt.bigInt.Reverce();
            }

            return newBigInt;

        }

        static public BigInteger Mul(BigInteger arg1, BigInteger arg2)
        {
            BigInteger currect = new BigInteger(0);
            BigInteger newBigInt = new BigInteger();
            int carry;
            for (int j = 0; j < arg2.bigInt.Count; j++)
            {
                int num = arg2.bigInt.GetFirst();
                carry = 0;
                for (int i = 0; i < arg1.bigInt.Count; i++)
                {
                    newBigInt.bigInt.AddLast((arg1.bigInt.GetFirst() * num + carry) % 10);
                    carry = (((arg1.bigInt.GetFirst() * num) + carry) / 10);
                    arg1.bigInt.AddLast(arg1.bigInt.RemoveFirst());
                }
                if (carry != 0)
                    newBigInt.bigInt.AddLast(carry);
                currect = BigInteger.Add(currect, newBigInt);
                newBigInt = BigInteger.Subtract(newBigInt, newBigInt);
                //newBigInt.bigInt.RemoveFirst();
                arg2.bigInt.AddLast(arg2.bigInt.RemoveFirst());

            }

            return currect;
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
