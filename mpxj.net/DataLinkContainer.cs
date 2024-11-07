using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class DataLinkContainer : ProxyList<net.sf.mpxj.DataLink, DataLink>
    {
        public new net.sf.mpxj.DataLinkContainer JavaObject => (net.sf.mpxj.DataLinkContainer)base.JavaObject;

        internal DataLinkContainer(ProxyManager proxyManager, net.sf.mpxj.DataLinkContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
