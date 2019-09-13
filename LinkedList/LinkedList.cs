using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    public class LinkedList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;
        private int count = 0;

        public int Count { get => count; private set => count = value; }

        public LinkedList() { }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Count == 0)
            {
                tail = newNode;
            }
            else
            {
                newNode.next = head;
            }
            head = newNode;
            Count++;
        }
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = tail.next;
            }

            Count++;
        }
        public void Insert(T value, int index)
        {
            Node<T> previousNode = head;
            Node<T> curNode = head.next;

            if (index == 1)
            {
                AddFirst(value);
                return;
            }
            if ((index - 1) <= Count)
            {
                Node<T> newNode = new Node<T>(value);
                while (index != 2)
                {
                    previousNode = previousNode.next;
                    curNode = curNode.next;
                    index--;
                }
                previousNode.next = newNode;
                newNode.next = curNode;
                Count++;
            }
        }
        public void Reverce()
        {
            if (Count == 1)
                return;
            int curCount = Count;
            Node<T> prevNode = head;
            Node<T> curNode = head.next;
            Node<T> nextNode = curNode.next;
            prevNode.next = null;
            tail = prevNode;
            while (curCount != 2)
            {
                curNode.next = prevNode;
                prevNode = curNode;
                curNode = nextNode;
                nextNode = nextNode.next;
                curCount--;
            }
            curNode.next = prevNode;
            head = curNode;
        }
        public T GetFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty ");
                return default;
            }
            return head.Value;
        }
        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty ");
                return default;
            }
            Node<T> ptr = head;
            head = head.next;
            Count--;
            return ptr.Value;
        }
        public void RemoveItem(T value)
        {
            Node<T> previousNode = head;
            Node<T> curNode = head.next;
            int curCount = Count;
            while (curCount != 0)
            {
                if (curNode.Value.CompareTo(value) == 0)
                {
                    previousNode.next = curNode.next;
                    Count--;
                    curCount -= 2;
                }
                else
                {
                    previousNode = previousNode.next;
                    curCount--;
                }
                curNode = curNode.next;
            }
            if (head.Value.CompareTo(value) == 0)
            {
                RemoveFirst();
            }
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        public void Show()
        {
            Node<T> ptr = head;
            int curCount = Count;
            if (IsEmpty())
                Console.WriteLine("List is empty");
            while (curCount != 0)
            {
                Console.Write(ptr.Value + "\t");
                ptr = ptr.next;
                curCount--;
            }
            Console.WriteLine();
        }

    }
}
