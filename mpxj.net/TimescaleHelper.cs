using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimescaleHelper : IJavaObjectProxy<org.mpxj.common.TimescaleHelper>
    {
        private readonly ProxyManager _proxyManager = new ProxyManager();

        public DayOfWeek WeekStartDayOfWeek
        {
            get => JavaObject.getWeekStartDay().ConvertType().Value;
            set => JavaObject.setWeekStartDay(value.ConvertType());
        }
        
        public org.mpxj.common.TimescaleHelper JavaObject { get; } = new org.mpxj.common.TimescaleHelper();

        public IList<DateTimeRange> CreateTimescale(DateTime startDate, int count, TimescaleUnits units) => _proxyManager.ProxyList<org.mpxj.LocalDateTimeRange, DateTimeRange>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.createTimescale(startDate.ConvertType(), count, units.ConvertType()));
        
        public IList<DateTimeRange> CreateTimescale(DateTime startDate, DateTime endDate, TimescaleUnits units) => _proxyManager.ProxyList<org.mpxj.LocalDateTimeRange, DateTimeRange>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.createTimescale(startDate.ConvertType(), endDate.ConvertType(), units.ConvertType()));
    }
}