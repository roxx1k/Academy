using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    public class DatePriorityQueue
    {
        public class Record
        {
            public DateTime Time { get; set; }
            public String Message { get; set; }
            public Record(DateTime time, String message)
            {
                Time = time;
                Message = message;
            }
        }

        private ParametricBothLinkedList<Record> records;

        public DatePriorityQueue()
        {
            records = new ParametricBothLinkedList<Record>();
        }

        public void Insert(DateTime time, String msg)
        {
            ParametricBothLinkedList<Record>.Node first = records.AccessFirst();
            if (first == null)
            {
                records.InsertFirst(new Record(time, msg));
            }
            else
            {
                ParametricBothLinkedList<Record>.Node temp = records.AccessAfter(first);
                while(time < temp.Data.Time)
                {
                    temp = records.AccessAfter(temp);
                }

                if (first.Data.Time < temp.Data.Time)
                {

                }   
            }
            
        }

        public void PrintQueue()
        {
            if (records.IsEmpty())
            {
                Console.WriteLine("No Events planned");
            }
            else
            {
                ParametricBothLinkedList<Record>.Node first = records.AccessFirst();
            }
        }



    }
}
