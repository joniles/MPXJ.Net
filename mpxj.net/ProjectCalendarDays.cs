using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarDays : IJavaObjectProxy<net.sf.mpxj.ProjectCalendarDays>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectCalendarDays JavaObject { get; }

        internal ProjectCalendarDays(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarDays javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public readonly net.sf.mpxj.LocalTimeRange DefaultWorkingMorning = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_MORNING;

        public readonly net.sf.mpxj.LocalTimeRange DefaultWorkingAfternoon = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_AFTERNOON;

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public ProjectCalendarHours GetCalendarHours(java.time.DayOfWeek day)
        {
            return _proxyManager.ProxyObject(JavaObject.getCalendarHours(day));
        }

        public void AddDefaultCalendarHours()
        {
            JavaObject.addDefaultCalendarHours();
        }

        public void AddDefaultCalendarDays()
        {
            JavaObject.addDefaultCalendarDays();
        }

        public void AddDefaultCalendarHours(java.time.DayOfWeek day)
        {
            JavaObject.addDefaultCalendarHours(day);
        }

        public ProjectCalendarHours AddCalendarHours(java.time.DayOfWeek day)
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendarHours(day));
        }

        public void RemoveCalendarHours(java.time.DayOfWeek day)
        {
            JavaObject.removeCalendarHours(day);
        }

        public DayType? GetCalendarDayType(java.time.DayOfWeek day)
        {
            return JavaObject.getCalendarDayType(day).ConvertType();
        }

        public void SetWorkingDay(java.time.DayOfWeek day, bool working)
        {
            JavaObject.setWorkingDay(day, working);
        }

        public void SetCalendarDayType(java.time.DayOfWeek day, DayType type)
        {
            JavaObject.setCalendarDayType(day, type.ConvertType());
        }
    }
}