using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UnitOfMeasureContainer : ProjectEntityContainer<org.mpxj.UnitOfMeasure, UnitOfMeasure>
    {
        public new org.mpxj.UnitOfMeasureContainer JavaObject => (org.mpxj.UnitOfMeasureContainer)base.JavaObject;

        internal UnitOfMeasureContainer(ProxyManager proxyManager, org.mpxj.UnitOfMeasureContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
