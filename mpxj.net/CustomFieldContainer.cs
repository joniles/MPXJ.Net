using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldContainer : ProxyEnumerable<net.sf.mpxj.CustomField, CustomField>, IJavaObjectProxy<net.sf.mpxj.CustomFieldContainer>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.CustomFieldContainer JavaObject => (net.sf.mpxj.CustomFieldContainer)base.JavaObject;

        internal CustomFieldContainer(ProxyManager proxyManager, net.sf.mpxj.CustomFieldContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public CustomField Get(net.sf.mpxj.FieldType field)
        {
            return _fromJava(JavaObject.get(field));
        }

        public CustomField GetOrCreate(net.sf.mpxj.FieldType field)
        {
            return _fromJava(JavaObject.getOrCreate(field));
        }

        public CustomField Add(net.sf.mpxj.FieldType field)
        {
            return _fromJava(JavaObject.add(field));
        }

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(FieldTypeClass typeClass, string alias)
        {
            return JavaObject.getFieldTypeByAlias(typeClass.ConvertType(), alias);
        }

        public IList<CustomField> GetCustomFieldsByFieldTypeClass(net.sf.mpxj.FieldTypeClass typeClass)
        {
            return _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFieldsByFieldTypeClass(typeClass));
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
            return _proxyManager.ProxyObject(JavaObject.getCustomFieldValueItemByGuid(guid.ToJava()));
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
