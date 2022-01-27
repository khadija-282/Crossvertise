using Crossversite.IBusinessLayer;
using Crossversite.IDataAccessLayer;
using Crossvertise.BusinessLayer;
using Crossvertise.Controllers;
using Crossvertise.DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Crossvertise.UnitTest
{
    [TestClass]
    public class EventTestController
    {
        [TestMethod]
        public void TestIndexView()
        {
            IEventDBManager evMDB = new EventDBManager();
            IEventDetailDBManager evDMDB = new EventDetailDBManager();

            IEventManager evM = new EventManager(evMDB);
            IEventDetailManager evDM = new EventDetailManager(evDMDB);
            IMonthManager moM = new MonthManager();

            var controller = new EventsController(evM, moM, evDM);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
        [TestMethod]
        public void TestEventsView()
        {
            IEventDBManager evMDB = new EventDBManager();
            IEventDetailDBManager evDMDB = new EventDetailDBManager();

            IEventManager evM = new EventManager(evMDB);
            IEventDetailManager evDM = new EventDetailManager(evDMDB);
            IMonthManager moM = new MonthManager();

            var controller = new EventsController(evM, moM, evDM);
            var result = controller.GetEvents(1) as ViewResult;
            Assert.AreEqual("GetEvents", result.ViewName);

        }
        [TestMethod]
        public void TestEventDetailView()
        {
            IEventDBManager evMDB = new EventDBManager();
            IEventDetailDBManager evDMDB = new EventDetailDBManager();

            IEventManager evM = new EventManager(evMDB);
            IEventDetailManager evDM = new EventDetailManager(evDMDB);
            IMonthManager moM = new MonthManager();

            var controller = new EventsController(evM, moM, evDM);
            var result = controller.GetEventDetails(1) as ViewResult;
            Assert.AreEqual("GetEventDetails", result.ViewName);

        }
    }
}
