using Crossversite.IBusinessLayer;
using Crossvertise.DTO;
using log4net;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crossvertise.Controllers
{
    public class EventsController : Controller
    {
        IEventManager eventManager;
        IEventDetailManager eventDetailManager;
        IMonthManager monthManager;
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public EventsController(IEventManager _eventManager, IMonthManager _monthManager, IEventDetailManager _eventDetailManager)
        {
            eventManager = _eventManager;
            monthManager = _monthManager;
            eventDetailManager = _eventDetailManager;
        }
        public ActionResult Index()
        {
            var model = new EventViewModel();
            try
            {
                model.Months = monthManager.GetMonths();
            }
            catch (Exception ex)
            {
                _log.Error("Index View-> " + ex.Message);
            }
            return View(model);
        }
        public ActionResult GetEvents(int? month)
        {
            var model = new List<Event>();
            try
            {
                model = month.HasValue ? eventManager.GetEvents(month.Value) : eventManager.GetEvents(0);
            }
            catch (Exception ex)
            {
                _log.Error("Get Events View-> " + ex.Message);
            }
            return View(model);
        }
        public ActionResult GetEventDetails(int? eventId)
        {
            var model = new Event();
            try
            {
                model = eventManager.GetEventById(eventId.Value);
                model.Details.AddRange(eventDetailManager.GetEventDetailsByEventId(eventId.Value));
            }
            catch (Exception ex)
            {
                _log.Error("Get Events Details View-> " + ex.Message);
            }
            return View(model);
        }

    }
}