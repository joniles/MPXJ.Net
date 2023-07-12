using org.mpxj.proxy;

namespace org.mpxj
{
    public class WorkContourContainer : ProjectEntityContainer<net.sf.mpxj.WorkContour, WorkContour>
    {
        public new net.sf.mpxj.WorkContourContainer JavaObject { get => (net.sf.mpxj.WorkContourContainer)base.JavaObject; }

        internal WorkContourContainer(ProxyManager proxyManager, net.sf.mpxj.WorkContourContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
