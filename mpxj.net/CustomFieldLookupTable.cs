using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CustomFieldLookupTable : ProxyList<org.mpxj.mpp.CustomFieldValueItem, CustomFieldValueItem>
    {
        public new org.mpxj.CustomFieldLookupTable JavaObject => (org.mpxj.CustomFieldLookupTable)base.JavaObject;

        internal CustomFieldLookupTable(ProxyManager proxyManager, org.mpxj.CustomFieldLookupTable javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public bool Enterprise
        {
            get => JavaObject.getEnterprise();
            set => JavaObject.setEnterprise(value);
        }

        public bool ShowIndent
        {
            get => JavaObject.getShowIndent();
            set => JavaObject.setShowIndent(value);
        }

        public bool ResourceSubstitutionEnabled
        {
            get => JavaObject.getResourceSubstitutionEnabled();
            set => JavaObject.setResourceSubstitutionEnabled(value);
        }

        public bool LeafOnly
        {
            get => JavaObject.getLeafOnly();
            set => JavaObject.setLeafOnly(value);
        }

        public bool AllLevelsRequired
        {
            get => JavaObject.getAllLevelsRequired();
            set => JavaObject.setAllLevelsRequired(value);
        }

        public bool OnlyTableValuesAllowed
        {
            get => JavaObject.getOnlyTableValuesAllowed();
            set => JavaObject.setOnlyTableValuesAllowed(value);
        }
    }
}

