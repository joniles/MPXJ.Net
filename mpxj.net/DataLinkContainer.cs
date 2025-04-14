using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class DataLinkContainer : ProxyList<org.mpxj.DataLink, DataLink>
    {
        public new org.mpxj.DataLinkContainer JavaObject => (org.mpxj.DataLinkContainer)base.JavaObject;

        internal DataLinkContainer(ProxyManager proxyManager, org.mpxj.DataLinkContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
