using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarWeek : ProjectCalendarDays, IJavaObjectProxy<net.sf.mpxj.ProjectCalendarWeek>
    {
        public new net.sf.mpxj.ProjectCalendarWeek JavaObject => (net.sf.mpxj.ProjectCalendarWeek)base.JavaObject;

        internal ProjectCalendarWeek(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarWeek javaObject) : base(proxyManager, javaObject) { }

        public LocalDateRange DateRange
        {
            get => _proxyManager.ProxyObject(JavaObject.getDateRange());
            set => JavaObject.setDateRange(value.JavaObject);
        }

        public IList<ProjectCalendarException> ConvertToRecurringExceptions(ProjectCalendar calendar)
        {
            return _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.convertToRecurringExceptions(calendar.JavaObject));
        }

        public override string ToString() => JavaObject.toString();
    }
}
