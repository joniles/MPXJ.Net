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

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields => ProxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(string alias) => JavaObject.getFieldTypeByAlias(alias);
    }
}
