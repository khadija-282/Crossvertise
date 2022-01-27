using Crossversite.DBContext;
using Crossversite.IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.DataAccessLayer
{
    public class EventDetailDBManager : IEventDetailDBManager
    {
        private CrossversiteEntities context = new CrossversiteEntities();
        public List<DTO.EventDetail> GetEventDetails(int eventId)
        {
            var eventDetails= new List<DTO.EventDetail>();
            var list= context.EventDetails.Where(x=>x.EventId==eventId).ToList();
            foreach (var item in list)
            {
                eventDetails.Add(new DTO.EventDetail()
                {
                    AttendeeEmail = item.AttendeeEmail,
                    AttendeeName = item.AttendeeName,   
                    EventId = item.EventId,
                    Id  = item.Id
                });
            }
            return eventDetails;
        }
    }
}
