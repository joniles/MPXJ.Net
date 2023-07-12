using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarHours : ProxyList<net.sf.mpxj.LocalTimeRange, LocalTimeRange>
    {
        internal ProjectCalendarHours(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarHours javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public override string ToString()
        {
            return JavaObject.ToString();
        }
    }
}