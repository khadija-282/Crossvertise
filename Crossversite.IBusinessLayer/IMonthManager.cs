using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossversite.IBusinessLayer
{
    public interface IMonthManager
    {
        Dictionary<int, string> GetMonths();
    }
}
