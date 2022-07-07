using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpapplication
{
    public class Event
    {
        public int EventId;
        public int CreateEvent()
        {
            Console.WriteLine("Event Created");
            return 0;
        }
        public void selectEvent()
        {
            Console.WriteLine("Events selected");
        }
    }
}
