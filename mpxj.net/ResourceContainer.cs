using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Resource, Resource>
	{
        public new net.sf.mpxj.ResourceContainer JavaObject { get => (net.sf.mpxj.ResourceContainer)base.JavaObject; }

        internal ResourceContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceContainer javaObject) : base(proxyManager, javaObject) { }

        public Resource Add()
        {
            return _proxyManager.ProxyObject(JavaObject.add());
        }

        public void UpdateStructure()
        {
            JavaObject.updateStructure();
        }

        public java.util.Set PopulatedFields
        {
            get => JavaObject.getPopulatedFields();
        }

        public IList<CustomField> CustomFields
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(JavaObject.getCustomFields());
        }

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(string alias)
        {
            return JavaObject.getFieldTypeByAlias(alias);
        }
    }
}
