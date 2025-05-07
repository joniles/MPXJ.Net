using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentContainer : ProjectEntityContainer<org.mpxj.ResourceAssignment, ResourceAssignment>
    {
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.ResourceAssignmentContainer JavaObject => (org.mpxj.ResourceAssignmentContainer)base.JavaObject;

        internal ResourceAssignmentContainer(ProxyManager proxyManager, org.mpxj.ResourceAssignmentContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<org.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (org.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<org.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}
