using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceCodeContainer : ProjectEntityContainer<org.mpxj.ResourceCode, ResourceCode>
    {
        public new org.mpxj.ResourceCodeContainer JavaObject => (org.mpxj.ResourceCodeContainer)base.JavaObject;

        internal ResourceCodeContainer(ProxyManager proxyManager, org.mpxj.ResourceCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
