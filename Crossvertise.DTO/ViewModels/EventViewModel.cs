using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.DTO
{
    public class EventViewModel
    {
        public EventViewModel()
        {
            Events=new List<Event>();
        }
        public List<Event> Events { get; set; }
        public Dictionary<int,string> Months { get; set; }
    }
}
