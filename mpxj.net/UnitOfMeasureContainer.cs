using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UnitOfMeasureContainer : ProjectEntityContainer<net.sf.mpxj.UnitOfMeasure, UnitOfMeasure>
    {
        public new net.sf.mpxj.UnitOfMeasureContainer JavaObject { get => (net.sf.mpxj.UnitOfMeasureContainer)base.JavaObject; }

        internal UnitOfMeasureContainer(ProxyManager proxyManager, net.sf.mpxj.UnitOfMeasureContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
