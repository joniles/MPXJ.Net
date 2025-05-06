using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RelationContainer : ProjectEntityContainer<org.mpxj.Relation, Relation>
    {
        public new org.mpxj.RelationContainer JavaObject => (org.mpxj.RelationContainer)base.JavaObject;

        internal RelationContainer(ProxyManager proxyManager, org.mpxj.RelationContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
