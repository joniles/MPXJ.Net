using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceAssignmentContainer : ProjectEntityContainer<net.sf.mpxj.ResourceAssignment, ResourceAssignment>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ResourceAssignmentContainer JavaObject => (net.sf.mpxj.ResourceAssignmentContainer)base.JavaObject;

        internal ResourceAssignmentContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignmentContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields => ProxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}
