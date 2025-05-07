using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCalendarHours : ProxyList<org.mpxj.LocalTimeRange, TimeOnlyRange>
    {
        internal ProjectCalendarHours(ProxyManager proxyManager, org.mpxj.ProjectCalendarHours javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public override string ToString() => JavaObject.ToString();
    }
}