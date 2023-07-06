using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: ProjectEntityContainer
    public class CostAccountContainer : ShallowProxyList<net.sf.mpxj.CostAccount>, IJavaObjectProxy<net.sf.mpxj.CostAccountContainer>
    {
        public new net.sf.mpxj.CostAccountContainer JavaObject { get => (net.sf.mpxj.CostAccountContainer)base.JavaObject; }

        internal CostAccountContainer(net.sf.mpxj.CostAccountContainer javaObject) : base(javaObject) { }
    }
}
