using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class EpsProjectNode
    {
        internal ProxyManager ProxyManager { get; }
        public net.sf.mpxj.EpsProjectNode JavaObject { get; }

        internal EpsProjectNode(ProxyManager proxyManager, net.sf.mpxj.EpsProjectNode javaObject)
        {
            ProxyManager = proxyManager;
            JavaObject = javaObject;
        }
        
        public int? UniqueId => JavaObject.getUniqueID().ConvertType();

        public int? ParentEpsUniqueId => JavaObject.getParentEpsUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public string ShortName => JavaObject.getShortName();
    }
}