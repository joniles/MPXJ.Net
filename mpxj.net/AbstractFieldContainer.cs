using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class AbstractFieldContainer : IFieldContainer
    {
        public org.mpxj.FieldContainer JavaObject { get; }
        internal readonly ProxyManager _proxyManager;

        internal AbstractFieldContainer(ProxyManager proxyManager, org.mpxj.AbstractFieldContainer javaObject)
        {
            JavaObject = javaObject;
            _proxyManager = proxyManager;
        }
        
        public void Set(IFieldType field, object value) => JavaObject.set(field.JavaObject, value.GenericJavaObject());

        public object Get(IFieldType field) => _proxyManager.GenericProxyObject(JavaObject.get(field.JavaObject));

        public object GetCachedValue(IFieldType field) => _proxyManager.GenericProxyObject(JavaObject.getCachedValue(field.JavaObject));

        public IList<Duration> GetTimephasedDurationValues(IFieldType field, IList<DateTimeRange> ranges, TimeUnit units) => _proxyManager.ProxyList<org.mpxj.Duration, Duration>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedDurationValues(field.JavaObject, ranges.ConvertType(), units.ConvertType()));
        
        public IList<double?> GetTimephasedNumericValues(IFieldType field, IList<DateTimeRange> ranges) => _proxyManager.ProxyList<java.lang.Number, double?>(m => m.ConvertType(), value => value.ConvertType(), JavaObject.getTimephasedNumericValues(field.JavaObject, ranges.ConvertType()));

        // TODO: implement if required
        // public void AddFieldListener(IFieldListener listener)
        // public void RemoveFieldListener(IFieldListener listener)
    }
}