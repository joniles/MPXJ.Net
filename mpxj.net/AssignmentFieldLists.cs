using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class AssignmentFieldLists
    {
        private static IList<AssignmentField> ProxyArray(net.sf.mpxj.AssignmentField[] array)
        {
            return new ProxyList<net.sf.mpxj.AssignmentField, AssignmentField>(f => (AssignmentField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.AssignmentField)f.JavaObject, array);
        }

        public static readonly IList<AssignmentField> CustomFields = new ProxyList<net.sf.mpxj.AssignmentField, AssignmentField>(f => (AssignmentField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.AssignmentField)f.JavaObject, net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_FIELDS);
        public static readonly IList<AssignmentField> BaselineBudgetCosts = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<AssignmentField> BaselineBudgetWorks = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<AssignmentField> BaselineCosts = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_COSTS);
        public static readonly IList<AssignmentField> BaselineFinishes = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_FINISHES);
        public static readonly IList<AssignmentField> BaselineStarts = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_STARTS);
        public static readonly IList<AssignmentField> BaselineWorks = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.BASELINE_WORKS);
        public static readonly IList<AssignmentField> BaselineCustomCost = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_COST);
        public static readonly IList<AssignmentField> BaselineCustomDate = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_DATE);
        public static readonly IList<AssignmentField> CustomDuration = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_DURATION);
        public static readonly IList<AssignmentField> CustomDurationUnits = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<AssignmentField> CustomFinish = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_FINISH);
        public static readonly IList<AssignmentField> CustomFlag = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_FLAG);
        public static readonly IList<AssignmentField> CustomNumber = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_NUMBER);
        public static readonly IList<AssignmentField> CustomStart = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_START);
        public static readonly IList<AssignmentField> CustomText = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.CUSTOM_TEXT);
        public static readonly IList<AssignmentField> EnterpriseCustomCost = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<AssignmentField> EnterpriseCustomDate = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<AssignmentField> EnterpriseCustomDuration = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<AssignmentField> EnterpriseCustomFlag = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<AssignmentField> EnterpriseCustomNumber = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<AssignmentField> EnterpriseCustomText = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_TEXT);
        public static readonly IList<AssignmentField> EnterpriseResourceMultiValue = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_RESOURCE_MULTI_VALUE);
        public static readonly IList<AssignmentField> EnterpriseResourceOutlineCode = ProxyArray(net.sf.mpxj.common.AssignmentFieldLists.ENTERPRISE_RESOURCE_OUTLINE_CODE);
    }
}
