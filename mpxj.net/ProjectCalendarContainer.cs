using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class ProjectCalendarContainer : ProjectEntityContainer<org.mpxj.ProjectCalendar, ProjectCalendar>
    {
        public new org.mpxj.ProjectCalendarContainer JavaObject => (org.mpxj.ProjectCalendarContainer)base.JavaObject;

        internal ProjectCalendarContainer(ProxyManager proxyManager, org.mpxj.ProjectCalendarContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public ProjectCalendar Add() => _fromJava(JavaObject.add());

        public ProjectCalendar AddDefaultBaseCalendar() => _fromJava(JavaObject.addDefaultBaseCalendar());

        public ProjectCalendar AddDefaultDerivedCalendar() => _fromJava(JavaObject.addDefaultDerivedCalendar());

        public ProjectCalendar FindOrCreateDefaultCalendar() => _fromJava(JavaObject.findOrCreateDefaultCalendar());

        public ProjectCalendar GetByName(string calendarName) => _fromJava(JavaObject.getByName(calendarName));
    }
}

