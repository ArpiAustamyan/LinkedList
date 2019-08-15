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
        private Node Head;
        private Node Tail;
        private int Count;
        public LinkedList()
        {
            Count = 0;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (Count == 0)
            {
                Tail = newNode;
                Head = newNode;
            }
            else
            {
                newNode.next = Head;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.next = newNode;
                Tail = Tail.next;
            }
            
            Count++;
        }
        public void Insert(int value,int index)
        {
            Node previousNode = Head;
            Node curNode = Head.next;

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
            int [] reverceArr = new int[Count];
            Node curNode = Head;
            int i = 0;
            while(curNode != null)
            {
                reverceArr[i] = curNode.value;
                curNode = curNode.next;
                i++;
            }
            Array.Reverse((Array)reverceArr);
            curNode = Head;
            i = 0;
            while (curNode != null)
            {
                curNode.value=reverceArr[i] ;
                curNode = curNode.next;
                i++;
            }

        }
        public void RemoveFirst()
        {
            Head = Head.next;
            Count--;
        }
        public void RemoveItem(int value)
        {

            Node previousNode = Head;
            Node curNode = Head.next;
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
            if (Head.value == value)
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
            Node ptr = Head;
            int curCount=Count;
            if (IsEmpty())
                Console.WriteLine("List is empty");
            while (curCount!=0)
            {
                Console.Write(ptr.value + "\t");
                ptr = ptr.next;
                curCount--;
            }

        }

    }
}
