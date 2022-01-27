using Crossvertise.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossversite.IBusinessLayer
{
    public interface IEventDetailManager
    {
        List<EventDetail> GetEventDetailsByEventId(int eventId);
    }
}
