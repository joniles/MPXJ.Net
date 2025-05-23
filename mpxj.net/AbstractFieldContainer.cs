﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class AbstractFieldContainer : ProjectEntity, IFieldContainer
    {
        internal AbstractFieldContainer(ProxyManager proxyManager, org.mpxj.AbstractFieldContainer javaObject) : base(proxyManager, javaObject) { }

        public new org.mpxj.FieldContainer JavaObject => base.JavaObject;

        public void Set(IFieldType field, object value) => JavaObject.set(field.JavaObject, value.GenericJavaObject());

        public object Get(IFieldType field) => _proxyManager.GenericProxyObject(JavaObject.get(field.JavaObject));

        public object GetCachedValue(IFieldType field) => _proxyManager.GenericProxyObject(JavaObject.getCachedValue(field.JavaObject));

        // TODO: implement if required
        // public void AddFieldListener(IFieldListener listener)
        // public void RemoveFieldListener(IFieldListener listener)
    }
}