using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostAccountContainer : ProjectEntityContainer<net.sf.mpxj.CostAccount, CostAccount>
    {
        public new net.sf.mpxj.CostAccountContainer JavaObject { get => (net.sf.mpxj.CostAccountContainer)base.JavaObject; }

        internal CostAccountContainer(ProxyManager proxyManager, net.sf.mpxj.CostAccountContainer javaObject) : base(proxyManager, javaObject) { }
    }
}
