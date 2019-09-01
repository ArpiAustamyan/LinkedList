using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BinarySearchTree:BinaryTree
    {
        public new void Add(int value)  
        {
            NodeTree newItem = new NodeTree(value);
            base.Add(newItem);
            if (newItem.parent != null && newItem.parent.parent != null)
            {
                NodeTree ptr = newItem.parent.parent;
                if (ptr.left.bal - ptr.right.bal >= 2 || ptr.left.bal - ptr.right.bal <= -2)
                    Balance(newItem);
            }
        }
        public void Balance(NodeTree item)
        {
            NodeTree ptr = item.parent.parent;
            {
                item.parent = ptr.parent;
                ptr.parent.left = item;
            }
        }
    }
}
