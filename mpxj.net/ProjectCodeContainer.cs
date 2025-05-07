using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCodeContainer : ProjectEntityContainer<org.mpxj.ProjectCode, ProjectCode>
    {
        public new org.mpxj.ProjectCodeContainer JavaObject => (org.mpxj.ProjectCodeContainer)base.JavaObject;

        internal ProjectCodeContainer(ProxyManager proxyManager, org.mpxj.ProjectCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
