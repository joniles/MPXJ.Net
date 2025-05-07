using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class WorkContourContainer : ProjectEntityContainer<org.mpxj.WorkContour, WorkContour>
    {
        public new org.mpxj.WorkContourContainer JavaObject => (org.mpxj.WorkContourContainer)base.JavaObject;

        internal WorkContourContainer(ProxyManager proxyManager, org.mpxj.WorkContourContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
