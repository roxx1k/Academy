using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Child { get; set; }
            public Node Sibling { get; set; }
        }

        Node root;
        public uint Size { get; private set; }

        public Tree()
        {
            Size = 0;
            root = null;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void AddRoot(int data)
        {
            if (root == null)
            {
                Node item = new Node() { Data = data, Child = null, Sibling = null };
                root = item;
                Size++;
            }
        }

        public void AddChild(Node root, int data)
        {
            Node temp = root;
            if (root != null)
            {
                Node newNode = new Node() { Data = data, Child = null, Sibling = null };
                if (root.Child == null)
                {
                    root.Child = newNode;
                }
                else
                {
                    AddChild(root.Child, data);
                }

                Size++;
            }
        }

        public void AddSibling()
        {
            throw new NotImplementedException();
        }

        public Node GetRoot()
        {
            return this.root;
        }
    }
}
