using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GroupContainer : ProxyList<org.mpxj.Group, Group>
    {
        public new org.mpxj.GroupContainer JavaObject => (org.mpxj.GroupContainer)base.JavaObject;

        internal GroupContainer(ProxyManager proxyManager, org.mpxj.GroupContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Group GetByName(string name) => _fromJava(JavaObject.getByName(name));
    }
}
