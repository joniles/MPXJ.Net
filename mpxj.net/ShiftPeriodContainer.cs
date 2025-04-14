using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ShiftPeriodContainer : ProjectEntityContainer<org.mpxj.ShiftPeriod, ShiftPeriod>
    {
        public new org.mpxj.ShiftPeriodContainer JavaObject => (org.mpxj.ShiftPeriodContainer)base.JavaObject;

        internal ShiftPeriodContainer(ProxyManager proxyManager, org.mpxj.ShiftPeriodContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
