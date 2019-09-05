using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MinHeap
    {
        private readonly int[] arr;
        private int size;
        private int count;

        public int Count { get => count; private set => count = value; }

        public MinHeap(int size)
        {
            arr = new int[size];
        }

        private int LeftChildIndex(int itemIndex)
        {
            return 2 * itemIndex + 1;
        }
        private int RightChildIndex(int itemIndex)
        {
            return 2 * itemIndex + 2;
        }
        private int ParentIndex(int itemIndex)
        {
            return (itemIndex - 1) / 2;
        }

        private bool HasLeftChild(int itemIndex) => LeftChildIndex(itemIndex) < size;
        private bool HasRightChild(int itemIndex) => RightChildIndex(itemIndex) < size;
        private bool IsRoot(int itemIndex) => itemIndex == 0;

        private int GetLeftChild(int itemIndex) => arr[LeftChildIndex(itemIndex)];
        private int GetRightChild(int itemIndex) => arr[RightChildIndex(itemIndex)];
        private int GetParent(int itemIndex) => arr[ParentIndex(itemIndex)];

        public int GetMin() => arr[0];

        private void HeapifyUp()
        {
            int index = Count - 1;
            while (!IsRoot(index) && arr[index] < GetParent(index))
            {
                int parentIndex = ParentIndex(index);
                int temp = arr[parentIndex];
                arr[parentIndex] = arr[index];
                arr[index] = temp;
                index = parentIndex;
            }
        }

        public void Add(int value)
        {
            if (Count == size)
            {
                Console.WriteLine("Is full");
            }
            arr[Count] = value;
            Count++;
            HeapifyUp();
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = LeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerIndex = RightChildIndex(index);
                }

                if (arr[smallerIndex] >= arr[index])
                {
                    break;
                }

                var temp = arr[smallerIndex];
                arr[smallerIndex] = arr[index];
                arr[index] = temp;
                index = smallerIndex;
            }
        }

        public int RemoveMin()
        {
            if (Count == 0)
            {
                Console.WriteLine("Is empty");
                return 0;
            }
            arr[0] = arr[Count - 1];
            Count--;
            HeapifyDown();
            return arr[Count];
        }

        public void Print()
        {
            if (Count != 0)
                for (int i = 0; i < Count; i++)
                    Console.Write(arr[i] + " ");
        }

    }
}
