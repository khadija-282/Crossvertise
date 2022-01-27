
using Crossversite.DBContext;
using Crossversite.IDataAccessLayer;
using Crossvertise.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.DataAccessLayer
{
    public class EventDBManager : IEventDBManager
    {
        private CrossversiteEntities context= new CrossversiteEntities();
        public List<DTO.Event> GetEvents()
        {
            var events = new List<DTO.Event>();
            var list = context.Events.ToList();
            foreach (var e in list)
            {
                events.Add(new DTO.Event()
                {
                    Description = e.Description,
                    EventAt = e.DateTime,
                    EventAtstr=e.DateTime.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture),
                    Id = e.Id,
                    Name = e.Name,
                    Organizer = e.CreatedBy,
                    CreatedAt=e.CreatedOn
                });
            }
            return events;
        }
    }
}
