namespace org.mpxj
{
	public class ProjectCalendarContainer : ProjectEntityContainer<net.sf.mpxj.ProjectCalendar, ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendarContainer JavaObject { get => (net.sf.mpxj.ProjectCalendarContainer)base.JavaObject; }

        internal ProjectCalendarContainer(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarContainer javaObject) : base(projectFile, javaObject) { }

        public ProjectCalendar Add()
        {
            return _projectFile.ProxyObject(JavaObject.add());
        }

        public ProjectCalendar AddDefaultBaseCalendar()
        {
            return _projectFile.ProxyObject(JavaObject.addDefaultBaseCalendar());
        }

        public ProjectCalendar AddDefaultDerivedCalendar()
        {
            return _projectFile.ProxyObject(JavaObject.addDefaultDerivedCalendar());
        }

        public ProjectCalendar FindOrCreateDefaultCalendar()
        {
            return _projectFile.ProxyObject(JavaObject.findOrCreateDefaultCalendar());
        }

        public ProjectCalendar GetByName(string calendarName)
        {
            return _projectFile.ProxyObject(JavaObject.getByName(calendarName));
        }
    }
}

