using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentCodeContainer : ProjectEntityContainer<org.mpxj.ResourceAssignmentCode, ResourceAssignmentCode>
    {
        public new org.mpxj.ResourceAssignmentCodeContainer JavaObject => (org.mpxj.ResourceAssignmentCodeContainer)base.JavaObject;

        internal ResourceAssignmentCodeContainer(ProxyManager proxyManager, org.mpxj.ResourceAssignmentCodeContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
