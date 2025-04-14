using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class AvailabilityTable : ProxyList<org.mpxj.Availability, Availability>
    {
        public new org.mpxj.AvailabilityTable JavaObject => (org.mpxj.AvailabilityTable)base.JavaObject;

        internal AvailabilityTable(ProxyManager proxyManager, org.mpxj.AvailabilityTable javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Availability GetEntryByDate(DateTime date) => _fromJava(JavaObject.getEntryByDate(date.ConvertType()));
    }
}
