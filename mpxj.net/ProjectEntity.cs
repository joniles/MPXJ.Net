using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectEntity
	{
		internal readonly ProxyManager _proxyManager;

		public ProjectFile Parent => _proxyManager.ProjectFile;

		internal ProjectEntity(ProxyManager proxyManager)
		{
			_proxyManager = proxyManager;
		}
	}
}

