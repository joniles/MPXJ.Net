using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class AssignmentFieldLists
    {
        private static IList<AssignmentField> ProxyArray(org.mpxj.AssignmentField[] array)
        {
            return new ProxyList<org.mpxj.AssignmentField, AssignmentField>(f => (AssignmentField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.AssignmentField)f.JavaObject, array);
        }

        public static readonly IList<AssignmentField> CustomFields = new ProxyList<org.mpxj.AssignmentField, AssignmentField>(f => (AssignmentField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.AssignmentField)f.JavaObject, org.mpxj.common.AssignmentFieldLists.CUSTOM_FIELDS);
        public static readonly IList<AssignmentField> BaselineBudgetCosts = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<AssignmentField> BaselineBudgetWorks = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<AssignmentField> BaselineCosts = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_COSTS);
        public static readonly IList<AssignmentField> BaselineFinishes = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_FINISHES);
        public static readonly IList<AssignmentField> BaselineStarts = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_STARTS);
        public static readonly IList<AssignmentField> BaselineWorks = ProxyArray(org.mpxj.common.AssignmentFieldLists.BASELINE_WORKS);
        public static readonly IList<AssignmentField> BaselineCustomCost = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_COST);
        public static readonly IList<AssignmentField> BaselineCustomDate = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_DATE);
        public static readonly IList<AssignmentField> CustomDuration = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_DURATION);
        public static readonly IList<AssignmentField> CustomDurationUnits = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<AssignmentField> CustomFinish = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_FINISH);
        public static readonly IList<AssignmentField> CustomFlag = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_FLAG);
        public static readonly IList<AssignmentField> CustomNumber = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_NUMBER);
        public static readonly IList<AssignmentField> CustomStart = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_START);
        public static readonly IList<AssignmentField> CustomText = ProxyArray(org.mpxj.common.AssignmentFieldLists.CUSTOM_TEXT);
        public static readonly IList<AssignmentField> EnterpriseCustomCost = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<AssignmentField> EnterpriseCustomDate = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<AssignmentField> EnterpriseCustomDuration = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<AssignmentField> EnterpriseCustomFlag = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<AssignmentField> EnterpriseCustomNumber = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<AssignmentField> EnterpriseCustomText = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_CUSTOM_TEXT);
        public static readonly IList<AssignmentField> EnterpriseResourceMultiValue = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_RESOURCE_MULTI_VALUE);
        public static readonly IList<AssignmentField> EnterpriseResourceOutlineCode = ProxyArray(org.mpxj.common.AssignmentFieldLists.ENTERPRISE_RESOURCE_OUTLINE_CODE);
    }
}
