using org.mpxj.proxy;

namespace org.mpxj
{
	public class Availability: IJavaObjectProxy<net.sf.mpxj.Availability>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Availability JavaObject { get; }

        internal Availability(ProxyManager proxyManager, net.sf.mpxj.Availability javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public LocalDateTimeRange Range => _proxyManager.ProxyObject(JavaObject.getRange());

        public double? Units => JavaObject.getUnits().ConvertType();
    }
}

