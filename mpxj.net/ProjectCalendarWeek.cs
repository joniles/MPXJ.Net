using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarWeek : ProjectCalendarDays, IJavaObjectProxy<net.sf.mpxj.ProjectCalendarWeek>
    {
        public new net.sf.mpxj.ProjectCalendarWeek JavaObject { get => (net.sf.mpxj.ProjectCalendarWeek)base.JavaObject; }

        internal ProjectCalendarWeek(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarWeek javaObject) : base(proxyManager, javaObject) { }

        public net.sf.mpxj.LocalDateRange DateRange
        {
            get => JavaObject.getDateRange();
            set => JavaObject.setDateRange(value);
        }

        public java.util.List ConvertToRecurringExceptions(ProjectCalendar calendar)
        {
            return JavaObject.convertToRecurringExceptions(calendar.JavaObject);
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }
    }
}
