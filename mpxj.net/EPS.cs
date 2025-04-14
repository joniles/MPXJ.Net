using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class EPS
    {
        internal ProxyManager ProxyManager { get; }
        public org.mpxj.EPS JavaObject { get; }

        internal EPS(org.mpxj.EPS javaObject)
        {
            ProxyManager = new ProxyManager();
            JavaObject = javaObject;
        }

        public IList<EpsNode> EpsNodes => new ProxyList<org.mpxj.EpsNode, EpsNode>(n => ProxyManager.ProxyObject(n),
            n => n.JavaObject, JavaObject.getEpsNodes());

        public EpsNode RootEpsNode => ProxyManager.ProxyObject(JavaObject.getRootEpsNode());

        public EpsNode GetEpsNodeByUniqueId(int value) =>
            ProxyManager.ProxyObject(JavaObject.getEpsNodeByUniqueID(value.ConvertType()));

        public IList<EpsProjectNode> EpsProjectNodes =>
            new ProxyList<org.mpxj.EpsProjectNode, EpsProjectNode>(n => ProxyManager.ProxyObject(n),
                n => n.JavaObject, JavaObject.getEpsProjectNodes());

        public EpsProjectNode GetProjectNodeByUniqueId(int value) =>
            ProxyManager.ProxyObject(JavaObject.getProjectNodeByUniqueID(value.ConvertType()));
    }
}
