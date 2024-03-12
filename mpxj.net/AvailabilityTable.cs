using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class AvailabilityTable : ProxyList<net.sf.mpxj.Availability, Availability>
    {
        public new net.sf.mpxj.AvailabilityTable JavaObject => (net.sf.mpxj.AvailabilityTable)base.JavaObject;

        internal AvailabilityTable(ProxyManager proxyManager, net.sf.mpxj.AvailabilityTable javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public Availability GetEntryByDate(DateTime date) => _fromJava(JavaObject.getEntryByDate(date.ConvertType()));
    }
}
