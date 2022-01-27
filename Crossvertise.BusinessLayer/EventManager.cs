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
    public class EventManager : IEventManager
    {
        IEventDBManager eventManager;
        public EventManager(IEventDBManager _eventManager)
        {
            eventManager = _eventManager;
        }
        public List<Event> GetEvents(int month)
        {
            return month>0 && month<=12 ?eventManager.GetEvents().Where(x=>x.EventAt.Month==month).ToList() : new List<Event>();
        }
        public  Event GetEventById(int Id)
        {
            return  eventManager.GetEvents().Where(x => x.Id == Id).FirstOrDefault() ;
        }
    }
}
