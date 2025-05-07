using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ShiftContainer : ProjectEntityContainer<org.mpxj.Shift, Shift>
    {
        public new org.mpxj.ShiftContainer JavaObject => (org.mpxj.ShiftContainer)base.JavaObject;

        internal ShiftContainer(ProxyManager proxyManager, org.mpxj.ShiftContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
