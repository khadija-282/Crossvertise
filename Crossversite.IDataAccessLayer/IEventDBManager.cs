﻿
using Crossvertise.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossversite.IDataAccessLayer
{
    public interface IEventDBManager
    {
        List<Event> GetEvents();
    }
}
