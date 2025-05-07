using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class EpsNode
    {
        internal ProxyManager ProxyManager { get; }
        public org.mpxj.EpsNode JavaObject { get; }

        internal EpsNode(ProxyManager proxyManager, org.mpxj.EpsNode javaObject)
        {
            ProxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueId => JavaObject.getUniqueID().ConvertType();

        public int? ParentUniqueId => JavaObject.getParentUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public string ShortName => JavaObject.getShortName();
        
        public IList<EpsNode> ChildEpsNodes => new ProxyList<org.mpxj.EpsNode, EpsNode>(n => ProxyManager.ProxyObject(n), n => n.JavaObject, JavaObject.getChildEpsNodes());
        
        public IList<EpsProjectNode> EpsProjectNodes => new ProxyList<org.mpxj.EpsProjectNode, EpsProjectNode>(n => ProxyManager.ProxyObject(n), n => n.JavaObject, JavaObject.getEpsProjectNodes());
    }
}