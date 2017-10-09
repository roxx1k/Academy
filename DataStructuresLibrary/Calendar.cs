using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    public class Calendar
    {

        public class CalendarEvent
        {
            public DateTime Time { get; set; }
            public string Description { get; set; }
            
        }

        private List<CalendarEvent> events { get; set; }
        private int Eventcount { get; set; }
        

        public Calendar()
        {
            events = new List<CalendarEvent>();
            Eventcount = 0;
        }

        public void CreateEvent(CalendarEvent myEvent)
        {
            
        }

        public void RemoveEvent(CalendarEvent myEvent)
        {

        }

        public void Clear()
        {


        }

        public bool IsEmpty()
        {
            return Eventcount == 0;
        }



    }
}
