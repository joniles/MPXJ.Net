using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCodeContainer : ProjectEntityContainer<net.sf.mpxj.ActivityCode, ActivityCode>
    {
        public new net.sf.mpxj.ActivityCodeContainer JavaObject => (net.sf.mpxj.ActivityCodeContainer)base.JavaObject;

        internal ActivityCodeContainer(ProxyManager proxyManager, net.sf.mpxj.ActivityCodeContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
