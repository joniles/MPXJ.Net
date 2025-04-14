using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCodeContainer : ProjectEntityContainer<org.mpxj.ActivityCode, ActivityCode>
    {
        public new org.mpxj.ActivityCodeContainer JavaObject => (org.mpxj.ActivityCodeContainer)base.JavaObject;

        internal ActivityCodeContainer(ProxyManager proxyManager, org.mpxj.ActivityCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
