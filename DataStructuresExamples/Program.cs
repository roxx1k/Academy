using DataStructuresLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            BothWayLinkedList list = new BothWayLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(4);
            list.InsertFirst(3);
            list.InsertLast(0);
            BothWayLinkedList.Node last= list.AccessLast();
            list.InsertAfter(last, 6);
            list.InsertBefore(list.AccessFirst(), 11);
            //list.EraseFirst();
            //list.EraseLast();
            BothWayLinkedList.Node someNode = list.AccessFirst().Next;
            list.EraseAfter(someNode);
            list.EraseBefore(someNode);

            bool isEmpty = list.IsEmpty();
            uint size = list.Size;


        }
    }
}
