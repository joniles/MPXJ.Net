﻿using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CustomFieldContainer : ProxyEnumerable<org.mpxj.CustomField, CustomField>, IJavaObjectProxy<org.mpxj.CustomFieldContainer>
    {
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.CustomFieldContainer JavaObject => (org.mpxj.CustomFieldContainer)base.JavaObject;

        internal CustomFieldContainer(ProxyManager proxyManager, org.mpxj.CustomFieldContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public CustomField Get(IFieldType field) => _fromJava(JavaObject.get(field.JavaObject));

        public CustomField GetOrCreate(IFieldType field) => _fromJava(JavaObject.getOrCreate(field.JavaObject));

        public CustomField Add(IFieldType field) => _fromJava(JavaObject.add(field.JavaObject));

        public IFieldType GetFieldTypeByAlias(FieldTypeClass typeClass, string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(typeClass.ConvertType(), alias));

        public IList<CustomField> GetCustomFieldsByFieldTypeClass(FieldTypeClass typeClass) => _proxyManager.ProxyList<org.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFieldsByFieldTypeClass(typeClass.ConvertType()));

        public int Size => JavaObject.size();

        public CustomFieldValueItem GetCustomFieldValueItemByUniqueID(int? uniqueId) => uniqueId == null ? null : _proxyManager.ProxyObject(JavaObject.getCustomFieldValueItemByUniqueID(uniqueId.Value));

        public CustomFieldValueItem GetCustomFieldValueItemByGuid(Guid? guid) => guid == null ? null : _proxyManager.ProxyObject(JavaObject.getCustomFieldValueItemByGuid(guid.ConvertType()));
    }
}
