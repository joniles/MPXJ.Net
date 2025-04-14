using MPXJ.Net.Proxy;
using System;

namespace MPXJ.Net
{
	public class Availability: IJavaObjectProxy<org.mpxj.Availability>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.Availability JavaObject { get; }

        internal Availability(ProxyManager proxyManager, org.mpxj.Availability javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public Availability(DateTime? start, DateTime? end, double? units)
        {
            JavaObject = new org.mpxj.Availability(start.ConvertType(), end.ConvertType(), units.ConvertType());
        }

        public DateTimeRange Range => _proxyManager.ProxyObject(JavaObject.getRange());

        public double? Units => JavaObject.getUnits().ConvertType();
    }
}

