using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldLookupTable : ProxyList<net.sf.mpxj.mpp.CustomFieldValueItem, CustomFieldValueItem>
    {
        public new net.sf.mpxj.CustomFieldLookupTable JavaObject => (net.sf.mpxj.CustomFieldLookupTable)base.JavaObject;

        internal CustomFieldLookupTable(ProxyManager proxyManager, net.sf.mpxj.CustomFieldLookupTable javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public Guid? GUID
        {
            get => JavaObject.getGUID().FromJava();
            set => JavaObject.setGUID(value.ToJava());
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

