using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class ResourceFieldLists
    {
        private static IList<ResourceField> ProxyArray(net.sf.mpxj.ResourceField[] array)
        {
            return new ProxyList<net.sf.mpxj.ResourceField, ResourceField>(f => (ResourceField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.ResourceField)f.JavaObject, array);
        }

        public static readonly IList<ResourceField> CustomFields = new ProxyList<net.sf.mpxj.ResourceField, ResourceField>(f => (ResourceField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.ResourceField)f.JavaObject, net.sf.mpxj.common.ResourceFieldLists.CUSTOM_FIELDS);
        public static readonly IList<ResourceField> BaselineBudgetCosts = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<ResourceField> BaselineBudgeWorks = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<ResourceField> BaselineCosts = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.BASELINE_COSTS);
        public static readonly IList<ResourceField> BaselineWorks = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.BASELINE_WORKS);
        public static readonly IList<ResourceField> CustomCost = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_COST);
        public static readonly IList<ResourceField> CustomDate = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_DATE);
        public static readonly IList<ResourceField> CustomDuration = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_DURATION);
        public static readonly IList<ResourceField> CustomDurationUnits = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<ResourceField> CustomFinish = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_FINISH);
        public static readonly IList<ResourceField> CustomFlag = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_FLAG);
        public static readonly IList<ResourceField> CustomNumber = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_NUMBER);
        public static readonly IList<ResourceField> CustomOutlineCose = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_OUTLINE_CODE);
        public static readonly IList<ResourceField> CustomOutlineCodeIndex = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_OUTLINE_CODE_INDEX);
        public static readonly IList<ResourceField> CustomStart = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_START);
        public static readonly IList<ResourceField> CustomText = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.CUSTOM_TEXT);
        public static readonly IList<ResourceField> EnterpriseCustomCost = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<ResourceField> EnterpriseCustomDate = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<ResourceField> EnterpriseCustomDuration = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<ResourceField> EnterpriseCustomFlag = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<ResourceField> EnterpriseCustomNumber = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<ResourceField> EnterpriseCustomText = ProxyArray(net.sf.mpxj.common.ResourceFieldLists.ENTERPRISE_CUSTOM_TEXT);
    }
}
