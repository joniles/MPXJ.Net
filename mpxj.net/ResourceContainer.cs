using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceContainer : ProjectEntityWithIDContainer<org.mpxj.Resource, Resource>
	{
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.ResourceContainer JavaObject => (org.mpxj.ResourceContainer)base.JavaObject;

        internal ResourceContainer(ProxyManager proxyManager, org.mpxj.ResourceContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Resource Add() => _proxyManager.ProxyObject(JavaObject.add());

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<org.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (org.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<org.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}
