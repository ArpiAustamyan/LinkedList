using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.Node; 

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int count=0;

        public int Count { get => count; private set => count = value; }

        public LinkedList() { }

        public void AddFirst(int value)
        {         
            Node newNode = new Node(value);
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
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
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
        public void Insert(int value,int index)
        {
            Node previousNode = head;
            Node curNode = head.next;

            if (index == 1)
            {
                AddFirst(value);
                return;
            }
            if ((index-1)<= Count)
            {
                Node newNode = new Node(value);
                while(index!=2)
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
            Node prevNode = head;
            Node curNode = head.next;
            Node nextNode = curNode.next;
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
        public int GetFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty ");
                return 0;
            }
            return head.value;        
        }
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("IsEmpty ");
                return 0;
            }
            Node ptr=head;
            head = head.next;
            Count--;
            return ptr.value;
        }
        public void RemoveItem(int value)
        {

            Node previousNode = head;
            Node curNode = head.next;
            int curCount = Count;
            while (curCount != 0)
            {
                if (curNode.value == value)
                {
                    previousNode.next = curNode.next;
                    Count--;
                    curCount-=2;
                }
                else
                {
                    previousNode = previousNode.next;
                    curCount--;
                }
                curNode = curNode.next;
            }         
            if (head.value == value)
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
            Node ptr = head;
            int curCount=Count;
            if (IsEmpty())
                Console.WriteLine("List is empty");
            while (curCount!=0)
            {
                Console.Write(ptr.value + "\t");
                ptr = ptr.next;
                curCount--;
            }
            Console.WriteLine();

        }

    }
}
