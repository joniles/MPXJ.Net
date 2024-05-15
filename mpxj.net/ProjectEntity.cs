using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public abstract class ProjectEntity
	{
		internal readonly ProxyManager _proxyManager;

		public ProjectFile Parent => _proxyManager.ProjectFile;

		internal ProjectEntity(ProxyManager proxyManager)
		{
			_proxyManager = proxyManager;
		}
	}
}

