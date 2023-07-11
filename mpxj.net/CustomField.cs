using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomField : IJavaObjectProxy<net.sf.mpxj.CustomField>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CustomField JavaObject { get; }

        internal CustomField(ProxyManager proxyManager, net.sf.mpxj.CustomField javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public net.sf.mpxj.FieldType FieldType
        {
            get => JavaObject.getFieldType();
        }

        public net.sf.mpxj.CustomFieldLookupTable LookupTable
        {
            get => JavaObject.getLookupTable();
        }

        public GraphicalIndicator GraphicalIndicator
        {
            get => _proxyManager.ProxyObject(JavaObject.getGraphicalIndicator());
        }

        public string Alias
        {
            get => JavaObject.getAlias();
            set => JavaObject.setAlias(value);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public IList<CustomFieldValueMask> Masks
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.CustomFieldValueMask, CustomFieldValueMask>(JavaObject.getMasks());
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

