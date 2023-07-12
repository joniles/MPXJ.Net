using org.mpxj.proxy;

namespace org.mpxj
{
    public class AvailabilityTable : ProxyList<net.sf.mpxj.Availability, Availability>
    {
        public new net.sf.mpxj.AvailabilityTable JavaObject { get => (net.sf.mpxj.AvailabilityTable)base.JavaObject; }

        internal AvailabilityTable(ProxyManager proxyManager, net.sf.mpxj.AvailabilityTable javaObject) : base(proxyManager, javaObject) { }

        public Availability GetEntryByDate(java.time.LocalDateTime date)
        {
            return _proxyManager.ProxyObject(JavaObject.getEntryByDate(date));
        }
    }
}
