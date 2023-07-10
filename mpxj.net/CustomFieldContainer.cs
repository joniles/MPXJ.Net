﻿using System.Collections.Generic;
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

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(net.sf.mpxj.FieldTypeClass typeClass, string alias)
        {
            return JavaObject.getFieldTypeByAlias(typeClass, alias);
        }

        public IList<CustomField> GetCustomFieldsByFieldTypeClass(net.sf.mpxj.FieldTypeClass typeClass)
        {
            return _proxyManager.ProxyCustomFieldList(JavaObject.getCustomFieldsByFieldTypeClass(typeClass));
        }

        public int Size()
        {
            return JavaObject.size();
        }

        public net.sf.mpxj.mpp.CustomFieldValueItem GetCustomFieldValueItemByUniqueID(int uniqueID)
        {
            return JavaObject.getCustomFieldValueItemByUniqueID(uniqueID);
        }

        public net.sf.mpxj.mpp.CustomFieldValueItem GetCustomFieldValueItemByGuid(java.util.UUID guid)
        {
            return JavaObject.getCustomFieldValueItemByGuid(guid);
        }

        public void RegisterValue(net.sf.mpxj.mpp.CustomFieldValueItem item)
        {
            JavaObject.registerValue(item);
        }

        public void DeregisterValue(net.sf.mpxj.mpp.CustomFieldValueItem item)
        {
            JavaObject.deregisterValue(item);
        }
    }
}
