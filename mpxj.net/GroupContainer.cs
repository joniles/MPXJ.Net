using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GroupContainer : ProxyList<net.sf.mpxj.Group, Group>
    {
        public new net.sf.mpxj.GroupContainer JavaObject => (net.sf.mpxj.GroupContainer)base.JavaObject;

        internal GroupContainer(ProxyManager proxyManager, net.sf.mpxj.GroupContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Group GetByName(string name) => _fromJava(JavaObject.getByName(name));
    }
}
