using org.mpxj.proxy;

namespace org.mpxj
{
    public class DataLinkContainer : ProxyEnumerable<net.sf.mpxj.DataLink, DataLink>, IJavaObjectProxy<net.sf.mpxj.DataLinkContainer>
    {
        public new net.sf.mpxj.DataLinkContainer JavaObject { get => (net.sf.mpxj.DataLinkContainer)base.JavaObject; }

        internal DataLinkContainer(ProxyManager proxyManager, net.sf.mpxj.DataLinkContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
