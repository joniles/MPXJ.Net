using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CostAccountContainer : ProjectEntityContainer<net.sf.mpxj.CostAccount, CostAccount>
    {
        public new net.sf.mpxj.CostAccountContainer JavaObject => (net.sf.mpxj.CostAccountContainer)base.JavaObject;

        internal CostAccountContainer(ProxyManager proxyManager, net.sf.mpxj.CostAccountContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
