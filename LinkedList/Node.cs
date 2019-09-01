using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class Node<T> where T: System.IComparable
    {
        private T value;
        public Node<T> next;

        public T Value { get => value; set => this.value = value; }

        public Node(T newValue, Node<T> newNode = null)
        {
            Value = newValue;
            next = newNode;
        }

    }
}
