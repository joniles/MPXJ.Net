using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectCalendarContainer : ProjectEntityContainer<net.sf.mpxj.ProjectCalendar, ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendarContainer JavaObject { get => (net.sf.mpxj.ProjectCalendarContainer)base.JavaObject; }

        internal ProjectCalendarContainer(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarContainer javaObject) : base(proxyManager, javaObject) { }

        public ProjectCalendar Add()
        {
            return _proxyManager.ProxyObject(JavaObject.add());
        }

        public ProjectCalendar AddDefaultBaseCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.addDefaultBaseCalendar());
        }

        public ProjectCalendar AddDefaultDerivedCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.addDefaultDerivedCalendar());
        }

        public ProjectCalendar FindOrCreateDefaultCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.findOrCreateDefaultCalendar());
        }

        public ProjectCalendar GetByName(string calendarName)
        {
            return _proxyManager.ProxyObject(JavaObject.getByName(calendarName));
        }
    }
}

