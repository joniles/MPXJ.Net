using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class ProjectCalendarDays : IJavaObjectProxy<net.sf.mpxj.ProjectCalendarDays>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectCalendarDays JavaObject { get; }

        internal ProjectCalendarDays(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarDays javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public readonly TimeOnlyRange DefaultWorkingMorning = new TimeOnlyRange(net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_MORNING);

        public readonly TimeOnlyRange DefaultWorkingAfternoon = new TimeOnlyRange(net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_AFTERNOON);

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public ProjectCalendarHours GetCalendarHours(DayOfWeek day)
        {
            return _proxyManager.ProxyObject(JavaObject.getCalendarHours(day.ConvertType()));
        }

        public void AddDefaultCalendarHours()
        {
            JavaObject.addDefaultCalendarHours();
        }

        public void AddDefaultCalendarDays()
        {
            JavaObject.addDefaultCalendarDays();
        }

        public void AddDefaultCalendarHours(DayOfWeek day)
        {
            JavaObject.addDefaultCalendarHours(day.ConvertType());
        }

        public ProjectCalendarHours AddCalendarHours(DayOfWeek day)
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendarHours(day.ConvertType()));
        }

        public void RemoveCalendarHours(DayOfWeek day)
        {
            JavaObject.removeCalendarHours(day.ConvertType());
        }

        public DayType? GetCalendarDayType(DayOfWeek day)
        {
            return JavaObject.getCalendarDayType(day.ConvertType()).ConvertType();
        }

        public void SetWorkingDay(DayOfWeek day, bool working)
        {
            JavaObject.setWorkingDay(day.ConvertType(), working);
        }

        public void SetCalendarDayType(DayOfWeek day, DayType type)
        {
            JavaObject.setCalendarDayType(day.ConvertType(), type.ConvertType());
        }
    }
}