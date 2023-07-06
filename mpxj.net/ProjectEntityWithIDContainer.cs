using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectEntityWithIDContainer<M, N> : ProjectEntityContainer<M, N> where N : IJavaObjectProxy<M>
    {
        internal ProjectEntityWithIDContainer(ProxyManager proxyManager, net.sf.mpxj.ProjectEntityWithIDContainer javaObject) : base(proxyManager, javaObject) { }

        public new net.sf.mpxj.ProjectEntityWithIDContainer JavaObject { get => (net.sf.mpxj.ProjectEntityWithIDContainer)base.JavaObject; }

        public N GetByID(java.lang.Integer id)
        {
            return (N)_proxyManager.GenericProxyObject(JavaObject.getByID(id));
        }
    }
}

