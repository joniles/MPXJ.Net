using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCodeContainer : ProjectEntityContainer<net.sf.mpxj.ProjectCode, ProjectCode>
    {
        public new net.sf.mpxj.ProjectCodeContainer JavaObject => (net.sf.mpxj.ProjectCodeContainer)base.JavaObject;

        internal ProjectCodeContainer(ProxyManager proxyManager, net.sf.mpxj.ProjectCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
