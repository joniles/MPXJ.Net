using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimescaleHelper : IJavaObjectProxy<org.mpxj.common.TimescaleHelper>
    {
        public org.mpxj.common.TimescaleHelper JavaObject { get; } = new org.mpxj.common.TimescaleHelper();

        //public IList<DateTimeRange> CreateTimescale(DateTime startDate, int count, TimescaleUnits units) => JavaObject.createTimescale(startDate.ConvertType(), count, units.ConvertType());
        //public IList<DateTimeRange> CreateTimescale(DateTime startDate, DateTime endDate, TimescaleUnits units)
        //WeekStartDay
    }
}