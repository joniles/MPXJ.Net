using MPXJ.Net.Proxy;
using System;

namespace MPXJ.Net
{
	public class Availability: IJavaObjectProxy<net.sf.mpxj.Availability>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Availability JavaObject { get; }

        internal Availability(ProxyManager proxyManager, net.sf.mpxj.Availability javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public Availability(DateTime? start, DateTime? end, double? units)
        {
            JavaObject = new net.sf.mpxj.Availability(start.ConvertType(), end.ConvertType(), units.ConvertType());
        }

        public DateTimeRange Range => _proxyManager.ProxyObject(JavaObject.getRange());

        public double? Units => JavaObject.getUnits().ConvertType();
    }
}

