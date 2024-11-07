using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCalendarHours : ProxyList<net.sf.mpxj.LocalTimeRange, TimeOnlyRange>
    {
        internal ProjectCalendarHours(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarHours javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public override string ToString() => JavaObject.ToString();
    }
}