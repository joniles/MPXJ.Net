using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class ResourceFieldLists
    {
        private static IList<ResourceField> ProxyArray(org.mpxj.ResourceField[] array)
        {
            return new ProxyList<org.mpxj.ResourceField, ResourceField>(f => (ResourceField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.ResourceField)f.JavaObject, array);
        }

        public static readonly IList<ResourceField> CustomFields = new ProxyList<org.mpxj.ResourceField, ResourceField>(f => (ResourceField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.ResourceField)f.JavaObject, org.mpxj.common.ResourceFieldLists.CUSTOM_FIELDS);
        public static readonly IList<ResourceField> BaselineBudgetCosts = ProxyArray(org.mpxj.common.ResourceFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<ResourceField> BaselineBudgeWorks = ProxyArray(org.mpxj.common.ResourceFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<ResourceField> BaselineCosts = ProxyArray(org.mpxj.common.ResourceFieldLists.BASELINE_COSTS);
        public static readonly IList<ResourceField> BaselineWorks = ProxyArray(org.mpxj.common.ResourceFieldLists.BASELINE_WORKS);
        public static readonly IList<ResourceField> CustomCost = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_COST);
        public static readonly IList<ResourceField> CustomDate = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_DATE);
        public static readonly IList<ResourceField> CustomDuration = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_DURATION);
        public static readonly IList<ResourceField> CustomDurationUnits = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<ResourceField> CustomFinish = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_FINISH);
        public static readonly IList<ResourceField> CustomFlag = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_FLAG);
        public static readonly IList<ResourceField> CustomNumber = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_NUMBER);
        public static readonly IList<ResourceField> CustomOutlineCose = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_OUTLINE_CODE);
        public static readonly IList<ResourceField> CustomOutlineCodeIndex = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_OUTLINE_CODE_INDEX);
        public static readonly IList<ResourceField> CustomStart = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_START);
        public static readonly IList<ResourceField> CustomText = ProxyArray(org.mpxj.common.ResourceFieldLists.CUSTOM_TEXT);
        public static readonly IList<ResourceField> EnterpriseCustomCost = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<ResourceField> EnterpriseCustomDate = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<ResourceField> EnterpriseCustomDuration = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<ResourceField> EnterpriseCustomFlag = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<ResourceField> EnterpriseCustomNumber = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<ResourceField> EnterpriseCustomText = ProxyArray(org.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_TEXT);
    }
}
