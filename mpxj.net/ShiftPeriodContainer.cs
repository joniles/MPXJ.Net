using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ShiftPeriodContainer : ProjectEntityContainer<net.sf.mpxj.ShiftPeriod, ShiftPeriod>
    {
        public new net.sf.mpxj.ShiftPeriodContainer JavaObject => (net.sf.mpxj.ShiftPeriodContainer)base.JavaObject;

        internal ShiftPeriodContainer(ProxyManager proxyManager, net.sf.mpxj.ShiftPeriodContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
