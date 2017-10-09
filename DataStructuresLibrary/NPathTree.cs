using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    public class NPathTree<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Parent { get; set; }
            public IList<Node> Children { get; set; }

            public Node()
            {
                Children = new List<Node>();
            }

            public Node(T value, Node parent)
            {
                Value = value;
                Parent = parent;
                Children = new List<Node>();
            }
            
            //public void AddChild(Node item)
            //{
            //    Children.Add(item);
            //}
            
        }

        private Node root;

        //public void InitExample()
        //{
        //    //root
        //    //root = new Node() { Value = 'a', Parent = null };
        //    root = new Node('a', null);

        //    //1st level
        //    Node bNode = new Node() { Value = 'b', Parent = root };
        //    Node cNode = new Node() { Value = 'c', Parent = root };
        //    root.Children.Add(bNode);
        //    root.Children.Add(cNode);

        //    //2nd level
        //    Node dNode = new Node() { Value = 'd', Parent = bNode };
        //    Node eNode = new Node() { Value = 'e', Parent = bNode };
        //    Node fNode = new Node() { Value = 'f', Parent = cNode };
        //    bNode.Children.Add(dNode);
        //    bNode.Children.Add(eNode);
        //    cNode.Children.Add(fNode);

        //    //3rd level
        //    Node gNode = new Node() { Value = 'g', Parent = dNode };
        //    Node hNode = new Node() { Value = 'h', Parent = dNode };
        //    Node iNode = new Node() { Value = 'i', Parent = fNode };
        //    Node jNode = new Node() { Value = 'j', Parent = fNode };
        //    Node kNode = new Node() { Value = 'k', Parent = fNode };
        //    dNode.Children.Add(gNode);
        //    dNode.Children.Add(hNode);
        //    fNode.Children.Add(iNode);
        //    fNode.Children.Add(jNode);
        //    fNode.Children.Add(kNode);
            
        //}

        public void WidthPrint()
        {
            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();

                queue.Enqueue(root);
                StringBuilder sb = new StringBuilder();

                while (queue.Count > 0)
                {
                    Node ret = queue.Dequeue();
                    sb.Append(ret.Value + " ");
                    foreach (Node item in ret.Children)
                    {
                        queue.Enqueue(item);
                    }
                    //Console.Write(ret.Value.ToString());
                }
                sb.Remove(sb.Length - 1, 1); //remove last character
                String result = sb.ToString();
                Console.WriteLine(result);
                //Console.WriteLine("a b c d e f g h i j k");

            }
            else
            {
                Console.WriteLine("The structure is empty, there is no ROOT!");
                return;
            }
            
        }


    }
}
