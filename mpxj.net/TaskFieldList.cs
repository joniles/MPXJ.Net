using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class TaskFieldList
    {
        private static IList<TaskField> ProxyArray(net.sf.mpxj.TaskField[] array)
        {
            return new ProxyList<net.sf.mpxj.TaskField, TaskField>(f => (TaskField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.TaskField)f.JavaObject, array);
        }

        public static readonly IList<TaskField> CustomFields = new ProxyList<net.sf.mpxj.TaskField, TaskField>(f => (TaskField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.TaskField)f.JavaObject, net.sf.mpxj.common.TaskFieldLists.CUSTOM_FIELDS);
        public static readonly IList<TaskField> BaselineBudgetCosts = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_BUDGET_COSTS);
        public static readonly IList<TaskField> BaselineBudgetWorks = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_BUDGET_WORKS);
        public static readonly IList<TaskField> BaselineCosts = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_COSTS);
        public static readonly IList<TaskField> BaselineDurations = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_DURATIONS);
        public static readonly IList<TaskField> BaselineEstimatedDurations = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_DURATIONS);
        public static readonly IList<TaskField> BaselineEstimatedFinishes = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_FINISHES);
        public static readonly IList<TaskField> BaselineEstimatedStarts = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_ESTIMATED_STARTS);
        public static readonly IList<TaskField> BaselineFinishes = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_FINISHES);
        public static readonly IList<TaskField> BaselineFixedCostAccruals = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_FIXED_COST_ACCRUALS);
        public static readonly IList<TaskField> BaselineFixedCosts = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_FIXED_COSTS);
        public static readonly IList<TaskField> BaselineStarts = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_STARTS);
        public static readonly IList<TaskField> BaselineWorks = ProxyArray(net.sf.mpxj.common.TaskFieldLists.BASELINE_WORKS);
        public static readonly IList<TaskField> CustomCost = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_COST);
        public static readonly IList<TaskField> CustomDate = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_DATE);
        public static readonly IList<TaskField> CustomDuration = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_DURATION);
        public static readonly IList<TaskField> CustomDurationUnits = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_DURATION_UNITS);
        public static readonly IList<TaskField> CustomFinish = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_FINISH);
        public static readonly IList<TaskField> CustomFlag = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_FLAG);
        public static readonly IList<TaskField> CustomNumber = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_NUMBER);
        public static readonly IList<TaskField> CustomOutlineCode = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_OUTLINE_CODE);
        public static readonly IList<TaskField> CustomOutlineCodeIndex = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_OUTLINE_CODE_INDEX);
        public static readonly IList<TaskField> CustomStart = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_START);
        public static readonly IList<TaskField> CustomText = ProxyArray(net.sf.mpxj.common.TaskFieldLists.CUSTOM_TEXT);
        public static readonly IList<TaskField> EnterpriseCustomCost = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_COST);
        public static readonly IList<TaskField> EnterpriseCustomDate = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_DATE);
        public static readonly IList<TaskField> EnterpriseCustomDuration = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_DURATION);
        public static readonly IList<TaskField> EnterpriseCustomFlag = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_FLAG);
        public static readonly IList<TaskField> EnterpriseCustomNumber = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_NUMBER);
        public static readonly IList<TaskField> EnterpriseCustomText = ProxyArray(net.sf.mpxj.common.TaskFieldLists.ENTERPRISE_CUSTOM_TEXT);
    }
}
