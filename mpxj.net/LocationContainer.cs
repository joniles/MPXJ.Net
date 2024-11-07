using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class LocationContainer : ProjectEntityContainer<net.sf.mpxj.Location, Location>
    {
        public new net.sf.mpxj.LocationContainer JavaObject => (net.sf.mpxj.LocationContainer)base.JavaObject;

        internal LocationContainer(ProxyManager proxyManager, net.sf.mpxj.LocationContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
