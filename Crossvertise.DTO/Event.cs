using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.DTO
{
    public class Event
    {
        public Event()
        {
            Details = new List<EventDetail>();
        }
        public long Id { get; set; }
        public string Name { get; set; }

        public DateTime EventAt { get; set; }
        public string EventAtstr { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public List<EventDetail> Details { get; set; }
    }
}
