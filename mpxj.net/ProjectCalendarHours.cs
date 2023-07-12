using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarHours : DeepProxyList<net.sf.mpxj.LocalTimeRange, LocalTimeRange>
    {
        internal ProjectCalendarHours(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarHours javaObject) : base(proxyManager, javaObject) { }

        public override string ToString()
        {
            return JavaObject.ToString();
        }
    }
}