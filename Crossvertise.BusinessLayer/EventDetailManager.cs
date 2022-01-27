using Crossversite.IBusinessLayer;
using Crossversite.IDataAccessLayer;
using Crossvertise.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.BusinessLayer
{
    public class EventDetailManager : IEventDetailManager
    {
        IEventDetailDBManager eventDetailManager;
        public EventDetailManager(IEventDetailDBManager _eventDetailManager)
        {
            eventDetailManager = _eventDetailManager;
        }
        public List<EventDetail> GetEventDetailsByEventId(int eventId)
        {
            return eventDetailManager.GetEventDetails(eventId);
        }
    }
}
