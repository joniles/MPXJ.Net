using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectCalendarContainer : ProjectEntityContainer<net.sf.mpxj.ProjectCalendar, ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendarContainer JavaObject => (net.sf.mpxj.ProjectCalendarContainer)base.JavaObject;

        internal ProjectCalendarContainer(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public ProjectCalendar Add() => _fromJava(JavaObject.add());

        public ProjectCalendar AddDefaultBaseCalendar() => _fromJava(JavaObject.addDefaultBaseCalendar());

        public ProjectCalendar AddDefaultDerivedCalendar() => _fromJava(JavaObject.addDefaultDerivedCalendar());

        public ProjectCalendar FindOrCreateDefaultCalendar() => _fromJava(JavaObject.findOrCreateDefaultCalendar());

        public ProjectCalendar GetByName(string calendarName) => _fromJava(JavaObject.getByName(calendarName));
    }
}

