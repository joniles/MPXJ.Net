using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CustomFieldValueItem : IJavaObjectProxy<net.sf.mpxj.mpp.CustomFieldValueItem>
    {
        public net.sf.mpxj.mpp.CustomFieldValueItem JavaObject { get; }

        internal CustomFieldValueItem(net.sf.mpxj.mpp.CustomFieldValueItem javaObject)
        {
            JavaObject = javaObject;
        }

        public CustomFieldValueItem(int uniqueID)
        {
            JavaObject = new net.sf.mpxj.mpp.CustomFieldValueItem(uniqueID.ConvertType());
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

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

        public int? ParentUniqueID
        {
            get => JavaObject.getParentUniqueID().ConvertType();
            set => JavaObject.setParentUniqueID(value.ConvertType());
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
