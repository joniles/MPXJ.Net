using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldContainer : DeepProxyEnumerable<CustomField>, IJavaObjectProxy<net.sf.mpxj.CustomFieldContainer>
    {
        public new net.sf.mpxj.CustomFieldContainer JavaObject { get => (net.sf.mpxj.CustomFieldContainer)base.JavaObject; }

        internal CustomFieldContainer(ProxyManager proxyManager, net.sf.mpxj.CustomFieldContainer javaObject) : base(proxyManager, javaObject) { }

        public CustomField Get(net.sf.mpxj.FieldType field)
        {
            return _proxyManager.ProxyObject(JavaObject.get(field));
        }

        public CustomField GetOrCreate(net.sf.mpxj.FieldType field)
        {
            return _proxyManager.ProxyObject(JavaObject.getOrCreate(field));
        }

        public CustomField Add(net.sf.mpxj.FieldType field)
        {
            return _proxyManager.ProxyObject(JavaObject.add(field));
        }

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(FieldTypeClass typeClass, string alias)
        {
            return JavaObject.getFieldTypeByAlias(typeClass.ConvertType(), alias);
        }

        public IList<CustomField> GetCustomFieldsByFieldTypeClass(net.sf.mpxj.FieldTypeClass typeClass)
        {
            return _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(JavaObject.getCustomFieldsByFieldTypeClass(typeClass));
        }

        public int Size()
        {
            return JavaObject.size();
        }

        public CustomFieldValueItem GetCustomFieldValueItemByUniqueID(int uniqueID)
        {
            return _proxyManager.ProxyObject(JavaObject.getCustomFieldValueItemByUniqueID(uniqueID));
        }

        public CustomFieldValueItem GetCustomFieldValueItemByGuid(Guid guid)
        {
            return _proxyManager.ProxyObject(JavaObject.getCustomFieldValueItemByGuid(guid.ConvertType()));
        }

        public void RegisterValue(CustomFieldValueItem item)
        {
            JavaObject.registerValue(item.JavaObject);
        }

        public void DeregisterValue(CustomFieldValueItem item)
        {
            JavaObject.deregisterValue(item.JavaObject);
        }
    }
}
