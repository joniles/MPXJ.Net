using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RoleCodeContainer : ProjectEntityContainer<net.sf.mpxj.RoleCode, RoleCode>
    {
        public new net.sf.mpxj.RoleCodeContainer JavaObject => (net.sf.mpxj.RoleCodeContainer)base.JavaObject;

        internal RoleCodeContainer(ProxyManager proxyManager, net.sf.mpxj.RoleCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
