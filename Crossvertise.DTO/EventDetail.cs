using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.DTO
{
    public class EventDetail
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string AttendeeName { get; set; }
        public string AttendeeEmail { get; set; }
    }
}
