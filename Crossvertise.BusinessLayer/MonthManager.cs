using Crossversite.IBusinessLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossvertise.BusinessLayer
{
    public class MonthManager : IMonthManager
    {
        public Dictionary<int, string> GetMonths()
        {
            var count = 1;
            var Months = new Dictionary<int, string>();
            foreach (var i in DateTimeFormatInfo.CurrentInfo.MonthNames)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    Months.Add(count, i);
                    count++;

                }
            }
            return Months;
        }
    }
}
