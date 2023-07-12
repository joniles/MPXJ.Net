using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
	public class ResourceAssignmentContainer : ProjectEntityContainer<net.sf.mpxj.ResourceAssignment, ResourceAssignment>
    {
        public new net.sf.mpxj.ResourceAssignmentContainer JavaObject { get => (net.sf.mpxj.ResourceAssignmentContainer)base.JavaObject; }

        internal ResourceAssignmentContainer(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignmentContainer javaObject) : base(proxyManager, javaObject) { }

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields
        //{
        //    get => ProxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(JavaObject.getPopulatedFields());
        //}

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

