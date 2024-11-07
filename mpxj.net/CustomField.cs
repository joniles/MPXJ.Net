using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CustomField : IJavaObjectProxy<net.sf.mpxj.CustomField>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CustomField JavaObject { get; }

        internal CustomField(ProxyManager proxyManager, net.sf.mpxj.CustomField javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public IFieldType FieldType => _proxyManager.ProxyObject(JavaObject.getFieldType());

        public CustomFieldLookupTable LookupTable => _proxyManager.ProxyObject(JavaObject.getLookupTable());

        public GraphicalIndicator GraphicalIndicator => _proxyManager.ProxyObject(JavaObject.getGraphicalIndicator());

        public string Alias
        {
            get => JavaObject.getAlias();
            set => JavaObject.setAlias(value);
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public IList<CustomFieldValueMask> Masks => _proxyManager.ProxyList<net.sf.mpxj.CustomFieldValueMask, CustomFieldValueMask>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getMasks());

        public override string ToString() => JavaObject.toString();
    }
}

