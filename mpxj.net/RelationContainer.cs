using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RelationContainer : ProjectEntityContainer<net.sf.mpxj.Relation, Relation>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.RelationContainer JavaObject => (net.sf.mpxj.RelationContainer)base.JavaObject;

        internal RelationContainer(ProxyManager proxyManager, net.sf.mpxj.RelationContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }
    }
}
