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

        public CustomField Get(IFieldType field)
        {
            return _fromJava(JavaObject.get(field.JavaObject));
        }

        public CustomField GetOrCreate(IFieldType field)
        {
            return _fromJava(JavaObject.getOrCreate(field.JavaObject));
        }

        public CustomField Add(IFieldType field)
        {
            return _fromJava(JavaObject.add(field.JavaObject));
        }

        public IFieldType GetFieldTypeByAlias(FieldTypeClass typeClass, string alias)
        {
            return _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(typeClass.ConvertType(), alias));
        }

        public IList<CustomField> GetCustomFieldsByFieldTypeClass(FieldTypeClass typeClass)
        {
            return _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFieldsByFieldTypeClass(typeClass.ConvertType()));
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
