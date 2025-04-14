using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RoleCodeContainer : ProjectEntityContainer<org.mpxj.RoleCode, RoleCode>
    {
        public new org.mpxj.RoleCodeContainer JavaObject => (org.mpxj.RoleCodeContainer)base.JavaObject;

        internal RoleCodeContainer(ProxyManager proxyManager, org.mpxj.RoleCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
