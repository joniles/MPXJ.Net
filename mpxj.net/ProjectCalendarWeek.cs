using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCalendarWeek : ProjectCalendarDays, IJavaObjectProxy<net.sf.mpxj.ProjectCalendarWeek>
    {
        public new net.sf.mpxj.ProjectCalendarWeek JavaObject => (net.sf.mpxj.ProjectCalendarWeek)base.JavaObject;

        internal ProjectCalendarWeek(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarWeek javaObject) : base(proxyManager, javaObject) { }

        public DateOnlyRange DateRange
        {
            get => _proxyManager.ProxyObject(JavaObject.getDateRange());
            set => JavaObject.setDateRange(value?.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}
