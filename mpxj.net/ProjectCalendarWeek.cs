using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCalendarWeek : ProjectCalendarDays, IJavaObjectProxy<org.mpxj.ProjectCalendarWeek>
    {
        public new org.mpxj.ProjectCalendarWeek JavaObject => (org.mpxj.ProjectCalendarWeek)base.JavaObject;

        internal ProjectCalendarWeek(ProxyManager proxyManager, org.mpxj.ProjectCalendarWeek javaObject) : base(proxyManager, javaObject) { }

        public DateOnlyRange DateRange
        {
            get => _proxyManager.ProxyObject(JavaObject.getDateRange());
            set => JavaObject.setDateRange(value?.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}
