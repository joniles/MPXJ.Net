using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class LocationContainer : ProjectEntityContainer<org.mpxj.Location, Location>
    {
        public new org.mpxj.LocationContainer JavaObject => (org.mpxj.LocationContainer)base.JavaObject;

        internal LocationContainer(ProxyManager proxyManager, org.mpxj.LocationContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
