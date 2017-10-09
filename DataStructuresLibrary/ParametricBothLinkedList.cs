using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace DataStructuresLibrary
{
    public class ParametricBothLinkedList<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

        }

        private Node first;
        private Node last;
        public uint Size { get; private set; }

        public ParametricBothLinkedList()
        {
            first = null;
            last = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        //add first item
        public void InsertFirst(T value)
        {
            Node node = new Node() { Data = value, Next = null, Previous = null };
            if (first != null)
            {
                node.Next = first;
                first.Previous = node;
            }
            else
            {
                last = node;
            }
            first = node;
            Size++;
        }

        //insert last item
        public void InsertLast(T value)
        {
            Node node = new Node() { Data = value, Next = null, Previous = null };
            if (first != null)
            {
                last.Next = node;
                node.Previous = last;
            }
            else
            {
                first = node;
            }
            last = node;
            Size++;

        }

        //insert after
        public void InsertAfter(Node previousNode, T value)
        {
            if (previousNode == null) throw new ArgumentNullException();

            Node node = new Node() { Data = value, Previous = previousNode, Next = previousNode.Next };
            if (previousNode.Next != null)
            {
                node.Next.Previous = node;
            }
            else
            {
                last = node;
            }
            previousNode.Next = node;
            Size++;
        }

        //insert before
        public void InsertBefore(Node afterNode, T value)
        {
            if (afterNode == null) throw new ArgumentNullException();

            Node node = new Node() { Data = value, Previous = afterNode.Previous, Next = afterNode };
            if (afterNode.Previous != null)
            {
                node.Previous.Next = node;
            }
            else
            {
                first = node;
            }
            afterNode.Previous = node;
            Size++;
        }


        //access first item
        public Node AccessFirst()
        {
            return first;

        }

        //access last item
        public Node AccessLast()
        {
            return last;

        }

        public Node AccessAfter(Node previousNode)
        {
            if (previousNode == null)
            {
                throw new ArgumentNullException();
            }
            return previousNode.Next;
        }

        public Node AccessBefore(Node afterNode)
        {
            if (afterNode == null)
            {
                throw new ArgumentNullException();
            }
            return afterNode.Previous;
        }

        public Node EraseFirst()
        {
            Node erased = first;
            if (first != null) //empty
            {

                Size--;
                if (first.Next == null) //only one node
                {
                    first = null;
                    last = null;
                }
                else //more than 1 node
                {
                    //muj postup
                    //Node ret = first;
                    //first.Next.Previous = null;
                    //first = first.Next;
                    //return ret;

                    first = first.Next;
                    first.Previous = null;
                }
                erased.Next = null;
            }
            return erased;

        }

        public Node EraseLast()
        {
            Node erased = last;
            if (last != null)
            {
                Size--;
                if (last.Previous == null) // 1 node
                {
                    first = null;
                    last = null;
                }
                else // more than 1 node
                {
                    last = last.Previous;
                    last.Next = null;
                }
                erased.Previous = null;
            }

            return erased;

        }

        public Node EraseAfter(Node previousNode)
        {
            if (previousNode == null) //null argument
            {
                throw new ArgumentNullException();
            }
            Node erased = previousNode.Next;
            if (previousNode.Next != null) //erased node exists
            {
                Size--;
                if (previousNode.Next == last) //erased was last node
                {
                    last = previousNode;
                    previousNode.Next = null;
                }
                else // erased wasn't last node
                {
                    previousNode.Next = previousNode.Next.Next;
                    previousNode.Next.Previous = previousNode;
                    erased.Next = null;
                }
                erased.Previous = null;
            }
            return erased;
        }


        public Node EraseBefore(Node afterNode)
        {
            if (afterNode == null)
            {
                throw new ArgumentNullException();
            }
            Node erased = afterNode.Previous;
            if (afterNode.Previous != null) //erased node exists
            {
                Size--;
                if (afterNode.Previous == first) //erased was first node
                {
                    first = afterNode;
                    afterNode.Previous = null;
                }
                else // erased item wasn't the first node
                {
                    afterNode.Previous = afterNode.Previous.Previous;
                    afterNode.Previous.Next = afterNode;
                    erased.Previous = null;
                }
                erased.Next = null;
            }
            return erased;

        }


        public override bool Equals(object obj)
        {
            if (!(obj is ParametricBothLinkedList<T>)) return false;

            ParametricBothLinkedList<T> second = (ParametricBothLinkedList<T>)obj;

            return base.Equals(obj);
        }

        public override string ToString()
        {
            if (first == null) return "Empty structure!";
            return first.Data.ToString();
            
        }

        
    }
}



