using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentContainer : ProjectEntityContainer<net.sf.mpxj.ResourceAssignment, ResourceAssignment>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ResourceAssignmentContainer JavaObject => (net.sf.mpxj.ResourceAssignmentContainer)base.JavaObject;

        internal ResourceAssignmentContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignmentContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (net.sf.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}
