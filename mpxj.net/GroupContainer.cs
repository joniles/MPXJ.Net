using org.mpxj.proxy;

namespace org.mpxj
{
    public class GroupContainer : ProxyList<net.sf.mpxj.Group, Group>
    {
        public new net.sf.mpxj.GroupContainer JavaObject { get => (net.sf.mpxj.GroupContainer)base.JavaObject; }

        internal GroupContainer(ProxyManager proxyManager, net.sf.mpxj.GroupContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public Group GetByName(string name)
        {
            return _fromJava(JavaObject.getByName(name));
        }
    }
}
