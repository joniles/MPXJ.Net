using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ShiftContainer : ProjectEntityContainer<net.sf.mpxj.Shift, Shift>
    {
        public new net.sf.mpxj.ShiftContainer JavaObject => (net.sf.mpxj.ShiftContainer)base.JavaObject;

        internal ShiftContainer(ProxyManager proxyManager, net.sf.mpxj.ShiftContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
