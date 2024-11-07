using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public abstract class ProjectEntity
	{
		internal readonly ProxyManager _proxyManager;
		protected net.sf.mpxj.AbstractFieldContainer JavaObject { get; }

		public ProjectFile Parent => _proxyManager.ProxyObject(JavaObject.getParentFile());

		internal ProjectEntity(ProxyManager proxyManager, net.sf.mpxj.AbstractFieldContainer javaObject)
		{
			_proxyManager = proxyManager;
            JavaObject = javaObject;
        }
	}
}

