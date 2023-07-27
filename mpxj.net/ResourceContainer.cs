using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Resource, Resource>
	{
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ResourceContainer JavaObject => (net.sf.mpxj.ResourceContainer)base.JavaObject;

        internal ResourceContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Resource Add() => _proxyManager.ProxyObject(JavaObject.add());

        public void UpdateStructure() => JavaObject.updateStructure();

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (net.sf.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}
