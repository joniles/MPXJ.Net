using System;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class ProjectCalendarDays : IJavaObjectProxy<org.mpxj.ProjectCalendarDays>
    {
        internal readonly ProxyManager _proxyManager;
        public org.mpxj.ProjectCalendarDays JavaObject { get; }

        internal ProjectCalendarDays(ProxyManager proxyManager, org.mpxj.ProjectCalendarDays javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public static readonly TimeOnlyRange DefaultWorkingMorning = new TimeOnlyRange(org.mpxj.ProjectCalendarDays.DEFAULT_WORKING_MORNING);

        public static readonly TimeOnlyRange DefaultWorkingAfternoon = new TimeOnlyRange(org.mpxj.ProjectCalendarDays.DEFAULT_WORKING_AFTERNOON);

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public ProjectCalendarHours[] CalendarHours => JavaObject.getCalendarHours().ToList().Select(l => _proxyManager.ProxyObject(l)).ToArray();

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

        public DayType?[] CalendarDayTypes => JavaObject.getCalendarDayTypes().ToList().Select(l => l.ConvertType()).ToArray();

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