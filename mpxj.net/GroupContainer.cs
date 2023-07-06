using org.mpxj.proxy;

namespace org.mpxj
{
    public class GroupContainer : ShallowProxyList<net.sf.mpxj.Group>, IJavaObjectProxy<net.sf.mpxj.GroupContainer>
    {
        public new net.sf.mpxj.GroupContainer JavaObject { get => (net.sf.mpxj.GroupContainer)base.JavaObject; }

        internal GroupContainer(net.sf.mpxj.GroupContainer javaObject) : base(javaObject) { }

        public net.sf.mpxj.Group GetByName(string name)
        {
            return JavaObject.getByName(name);
        }
    }
}
