using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class TaskFieldList
    {
        private static IList<TaskField> ProxyArray(org.mpxj.TaskField[] array)
        {
            return new ProxyList<org.mpxj.TaskField, TaskField>(f => (TaskField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.TaskField)f.JavaObject, array);
        }

        public static readonly IList<TaskField> CustomFields = new ProxyList<org.mpxj.TaskField, TaskField>(f => (TaskField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.TaskField)f.JavaObject, org.mpxj.common.TaskFieldLists.CUSTOM_FIELDS);
        public static readonly IList<TaskField> BaselineBudgetCosts = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<TaskField> BaselineBudgetWorks = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<TaskField> BaselineCosts = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_COSTS);
        public static readonly IList<TaskField> BaselineDurations = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_DURATIONS);
        public static readonly IList<TaskField> BaselineEstimatedDurations = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_DURATIONS);
        public static readonly IList<TaskField> BaselineEstimatedFinishes = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_FINISHES);
        public static readonly IList<TaskField> BaselineEstimatedStarts = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_STARTS);
        public static readonly IList<TaskField> BaselineFinishes = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_FINISHES);
        public static readonly IList<TaskField> BaselineFixedCostAccruals = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_FIXED_COST_ACCRUALS);
        public static readonly IList<TaskField> BaselineFixedCosts = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_FIXED_COSTS);
        public static readonly IList<TaskField> BaselineStarts = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_STARTS);
        public static readonly IList<TaskField> BaselineWorks = ProxyArray(org.mpxj.common.TaskFieldLists.BASELINE_WORKS);
        public static readonly IList<TaskField> CustomCost = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_COST);
        public static readonly IList<TaskField> CustomDate = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_DATE);
        public static readonly IList<TaskField> CustomDuration = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_DURATION);
        public static readonly IList<TaskField> CustomDurationUnits = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<TaskField> CustomFinish = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_FINISH);
        public static readonly IList<TaskField> CustomFlag = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_FLAG);
        public static readonly IList<TaskField> CustomNumber = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_NUMBER);
        public static readonly IList<TaskField> CustomOutlineCode = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_OUTLINE_CODE);
        public static readonly IList<TaskField> CustomOutlineCodeIndex = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_OUTLINE_CODE_INDEX);
        public static readonly IList<TaskField> CustomStart = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_START);
        public static readonly IList<TaskField> CustomText = ProxyArray(org.mpxj.common.TaskFieldLists.CUSTOM_TEXT);
        public static readonly IList<TaskField> EnterpriseCustomCost = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<TaskField> EnterpriseCustomDate = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<TaskField> EnterpriseCustomDuration = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<TaskField> EnterpriseCustomFlag = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<TaskField> EnterpriseCustomNumber = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<TaskField> EnterpriseCustomText = ProxyArray(org.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_TEXT);
    }
}
