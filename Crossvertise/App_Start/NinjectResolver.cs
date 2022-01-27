using Crossversite.IBusinessLayer;
using Crossversite.IDataAccessLayer;
using Crossvertise.BusinessLayer;
using Crossvertise.DataAccessLayer;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crossvertise.App_Start
{
    

    namespace MvcNInject.App_Start
    {
        public class NinjectResolver : System.Web.Mvc.IDependencyResolver
        {
            private readonly IKernel _kernel;

            public NinjectResolver()
            {
                _kernel = new StandardKernel();
                AddBindings();
            }

            public object GetService(Type serviceType)
            {
                return _kernel.TryGet(serviceType);
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                return _kernel.GetAll(serviceType);
            }

            private void AddBindings()
            {
                this._kernel.Bind<IEventManager>().To<EventManager>(); // Registering Types    
                this._kernel.Bind<IEventDetailManager>().To<EventDetailManager>(); // Registering Types    
                this._kernel.Bind<IMonthManager>().To<MonthManager>(); // Registering Types    

                this._kernel.Bind<IEventDBManager>().To<EventDBManager>(); // Registering Types    
                this._kernel.Bind<IEventDetailDBManager>().To<EventDetailDBManager>(); // Registering Types    
            }
        }

    }
}