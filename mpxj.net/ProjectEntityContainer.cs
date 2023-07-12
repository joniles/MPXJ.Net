using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectEntityContainer<M, N> : ProxyList<M, N>, IProjectEntityContainer<N>, IJavaObjectProxy<net.sf.mpxj.ProjectEntityContainer> where N : IJavaObjectProxy<M>
	{
        public new net.sf.mpxj.ProjectEntityContainer JavaObject { get => (net.sf.mpxj.ProjectEntityContainer)base.JavaObject; }

        internal ProjectEntityContainer(ProxyManager proxyManager, net.sf.mpxj.ProjectEntityContainer javaObject) : base(proxyManager, javaObject) { }

        public N GetByUniqueID(java.lang.Integer id)
        {
            return (N)_proxyManager.GenericProxyObject(JavaObject.getByUniqueID(id));    
        }
    }
}
