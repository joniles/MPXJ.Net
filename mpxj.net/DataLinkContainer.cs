using org.mpxj.proxy;

namespace org.mpxj
{
    public class DataLinkContainer : ProxyEnumerable<DataLink>, IJavaObjectProxy<net.sf.mpxj.DataLinkContainer>
    {
        public new net.sf.mpxj.DataLinkContainer JavaObject { get => (net.sf.mpxj.DataLinkContainer)base.JavaObject; }

        internal DataLinkContainer(ProxyManager proxyManager, net.sf.mpxj.DataLinkContainer javaObject) : base(proxyManager, javaObject) { }
    }
}
