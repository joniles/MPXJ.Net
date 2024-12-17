using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceCodeContainer : ProjectEntityContainer<net.sf.mpxj.ResourceCode, ResourceCode>
    {
        public new net.sf.mpxj.ResourceCodeContainer JavaObject => (net.sf.mpxj.ResourceCodeContainer)base.JavaObject;

        internal ResourceCodeContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
