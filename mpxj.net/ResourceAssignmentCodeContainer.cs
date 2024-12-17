using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentCodeContainer : ProjectEntityContainer<net.sf.mpxj.ResourceAssignmentCode, ResourceAssignmentCode>
    {
        public new net.sf.mpxj.ResourceAssignmentCodeContainer JavaObject => (net.sf.mpxj.ResourceAssignmentCodeContainer)base.JavaObject;

        internal ResourceAssignmentCodeContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignmentCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
