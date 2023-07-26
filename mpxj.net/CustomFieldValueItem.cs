using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldValueItem : IJavaObjectProxy<net.sf.mpxj.mpp.CustomFieldValueItem>
    {
        public net.sf.mpxj.mpp.CustomFieldValueItem JavaObject { get; }

        internal CustomFieldValueItem(net.sf.mpxj.mpp.CustomFieldValueItem javaObject)
        {
            JavaObject = javaObject;
        }

        public CustomFieldValueItem(java.lang.Integer uniqueID)
        {
            JavaObject = new net.sf.mpxj.mpp.CustomFieldValueItem(uniqueID);
        }

        public java.lang.Integer UniqueID => JavaObject.getUniqueID();

        public object Value
        {
            get => JavaObject.getValue();
            set => JavaObject.setValue(value);
        }

        public string Description
        {
            get => JavaObject.getDescription();
            set => JavaObject.setDescription(value);
        }

        public java.lang.Integer Parent
        {
            get => JavaObject.getParent();
            set => JavaObject.setParent(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public CustomFieldValueDataType? Type
        {
            get => JavaObject.getType().ConvertType();
            set => JavaObject.setType(value.ConvertType());
        }

        public bool Collapsed
        {
            get => JavaObject.getCollapsed();
            set => JavaObject.setCollapsed(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}
