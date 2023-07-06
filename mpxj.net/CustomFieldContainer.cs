using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldContainer : ShallowProxyEnumerable<net.sf.mpxj.CustomField>, IJavaObjectProxy<net.sf.mpxj.CustomFieldContainer>
    {
        public new net.sf.mpxj.CustomFieldContainer JavaObject { get => (net.sf.mpxj.CustomFieldContainer)base.JavaObject; }

        internal CustomFieldContainer(net.sf.mpxj.CustomFieldContainer javaObject) : base(javaObject) { }

        public net.sf.mpxj.CustomField Get(net.sf.mpxj.FieldType field)
        {
            return JavaObject.get(field);
        }

        public net.sf.mpxj.CustomField GetOrCreate(net.sf.mpxj.FieldType field)
        {
            return JavaObject.getOrCreate(field);
        }

        public net.sf.mpxj.CustomField Add(net.sf.mpxj.FieldType field)
        {
            return JavaObject.add(field);
        }

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(net.sf.mpxj.FieldTypeClass typeClass, string alias)
        {
            return JavaObject.getFieldTypeByAlias(typeClass, alias);
        }

        public java.util.List GetCustomFieldsByFieldTypeClass(net.sf.mpxj.FieldTypeClass typeClass)
        {
            return JavaObject.getCustomFieldsByFieldTypeClass(typeClass);
        }

        public int Size()
        {
            return JavaObject.size();
        }

        public net.sf.mpxj.mpp.CustomFieldValueItem GetCustomFieldValueItemByUniqueID(int uniqueID)
        {
            return JavaObject.getCustomFieldValueItemByUniqueID(uniqueID);
        }

        public net.sf.mpxj.mpp.CustomFieldValueItem GetCustomFieldValueItemByGuid(java.util.UUID guid)
        {
            return JavaObject.getCustomFieldValueItemByGuid(guid);
        }

        public void RegisterValue(net.sf.mpxj.mpp.CustomFieldValueItem item)
        {
            JavaObject.registerValue(item);
        }

        public void DeregisterValue(net.sf.mpxj.mpp.CustomFieldValueItem item)
        {
            JavaObject.deregisterValue(item);
        }
    }
}
