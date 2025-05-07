using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CostAccountContainer : ProjectEntityContainer<org.mpxj.CostAccount, CostAccount>
    {
        public new org.mpxj.CostAccountContainer JavaObject => (org.mpxj.CostAccountContainer)base.JavaObject;

        internal CostAccountContainer(ProxyManager proxyManager, org.mpxj.CostAccountContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
