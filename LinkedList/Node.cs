using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node(int newValue=0, Node newNode=null)
        {
            value = newValue;
            next = newNode;
        }
    }
}
