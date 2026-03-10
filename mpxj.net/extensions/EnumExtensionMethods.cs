using System.Collections.Generic;
// ReSharper disable RedundantCast

namespace MPXJ.Net
{
    internal static class EnumExtensionMethods
    {
        internal static readonly Dictionary<org.mpxj.FieldType, IFieldType> FieldTypeDictionary = new Dictionary<org.mpxj.FieldType, IFieldType>();

        static EnumExtensionMethods()
        {
            RegisterFieldTypes(ProjectField.Values);
            RegisterFieldTypes(TaskField.Values);
            RegisterFieldTypes(ResourceField.Values);
            RegisterFieldTypes(AssignmentField.Values);
            RegisterFieldTypes(ConstraintField.Values);
        }


        private static void RegisterFieldTypes<T>(IEnumerable<T> fields) where T : IFieldType
        {
            foreach(var field in fields)
            {
                FieldTypeDictionary[field.JavaObject] = field;
            }
        }

        // DayType
        public static org.mpxj.DayType ConvertType(this DayType value)
        {
            return org.mpxj.DayType.getInstance((int)value);
        }

        public static org.mpxj.DayType ConvertType(this DayType? value)
        {
            return value == null ? null : org.mpxj.DayType.getInstance((int)value);
        }

        public static DayType? ConvertType(this org.mpxj.DayType value)
        {
            return value == null ? (DayType?)null : (DayType)value.getValue();
        }

        // TimeUnit
        public static org.mpxj.TimeUnit ConvertType(this TimeUnit value)
        {
            return org.mpxj.TimeUnit.getInstance((int)value);
        }

        public static org.mpxj.TimeUnit ConvertType(this TimeUnit? value)
        {
            return value == null ? null : org.mpxj.TimeUnit.getInstance((int)value);
        }

        public static TimeUnit? ConvertType(this org.mpxj.TimeUnit value)
        {
            return value == null ? (TimeUnit?)null : (TimeUnit)value.getValue();
        }

        // AccrueType
        public static org.mpxj.AccrueType ConvertType(this AccrueType value)
        {
            return org.mpxj.AccrueType.getInstance((int)value);
        }

        public static org.mpxj.AccrueType ConvertType(this AccrueType? value)
        {
            return value == null ? null : org.mpxj.AccrueType.getInstance((int)value);
        }

        public static AccrueType? ConvertType(this org.mpxj.AccrueType value)
        {
            return value == null ? (AccrueType?)null : (AccrueType)value.getValue();
        }

        // EarnedValueMethod
        public static org.mpxj.EarnedValueMethod ConvertType(this EarnedValueMethod value)
        {
            return org.mpxj.EarnedValueMethod.getInstance((int)value);
        }

        public static org.mpxj.EarnedValueMethod ConvertType(this EarnedValueMethod? value)
        {
            return value == null ? null : org.mpxj.EarnedValueMethod.getInstance((int)value);
        }

        public static EarnedValueMethod? ConvertType(this org.mpxj.EarnedValueMethod value)
        {
            return value == null ? (EarnedValueMethod?)null : (EarnedValueMethod)value.getValue();
        }

        // ActivityStatus
        public static org.mpxj.ActivityStatus ConvertType(this ActivityStatus value)
        {
            return org.mpxj.ActivityStatus.values()[(int)value];
        }

        public static org.mpxj.ActivityStatus ConvertType(this ActivityStatus? value)
        {
            return value == null ? null : org.mpxj.ActivityStatus.values()[(int)value];
        }

        public static ActivityStatus? ConvertType(this org.mpxj.ActivityStatus value)
        {
            return value == null ? (ActivityStatus?)null : (ActivityStatus)value.ordinal();
        }

        // FieldTypeClass
        public static org.mpxj.FieldTypeClass ConvertType(this FieldTypeClass value)
        {
            return org.mpxj.FieldTypeClass.values()[(int)value];
        }

        public static org.mpxj.FieldTypeClass ConvertType(this FieldTypeClass? value)
        {
            return value == null ? null : org.mpxj.FieldTypeClass.values()[(int)value];
        }

        public static FieldTypeClass? ConvertType(this org.mpxj.FieldTypeClass value)
        {
            return value == null ? (FieldTypeClass?)null : (FieldTypeClass)value.ordinal();
        }

        // CustomFieldValueDataType
        public static org.mpxj.CustomFieldValueDataType ConvertType(this CustomFieldValueDataType value)
        {
            return org.mpxj.CustomFieldValueDataType.values()[(int)value];
        }

        public static org.mpxj.CustomFieldValueDataType ConvertType(this CustomFieldValueDataType? value)
        {
            return value == null ? null : org.mpxj.CustomFieldValueDataType.values()[(int)value];
        }

        public static CustomFieldValueDataType? ConvertType(this org.mpxj.CustomFieldValueDataType value)
        {
            return value == null ? (CustomFieldValueDataType?)null : (CustomFieldValueDataType)value.ordinal();
        }

        // TestOperator
        public static org.mpxj.TestOperator ConvertType(this TestOperator value)
        {
            return org.mpxj.TestOperator.values()[(int)value];
        }

        public static org.mpxj.TestOperator ConvertType(this TestOperator? value)
        {
            return value == null ? null : org.mpxj.TestOperator.values()[(int)value];
        }

        public static TestOperator? ConvertType(this org.mpxj.TestOperator value)
        {
            return value == null ? (TestOperator?)null : (TestOperator)value.ordinal();
        }

        // ActivityCodeScope
        public static org.mpxj.ActivityCodeScope ConvertType(this ActivityCodeScope value)
        {
            return org.mpxj.ActivityCodeScope.values()[(int)value];
        }

        public static org.mpxj.ActivityCodeScope ConvertType(this ActivityCodeScope? value)
        {
            return value == null ? null : org.mpxj.ActivityCodeScope.values()[(int)value];
        }

        public static ActivityCodeScope? ConvertType(this org.mpxj.ActivityCodeScope value)
        {
            return value == null ? (ActivityCodeScope?)null : (ActivityCodeScope)value.ordinal();
        }

        // DataType
        public static org.mpxj.DataType ConvertType(this DataType value)
        {
            return org.mpxj.DataType.values()[(int)value];
        }

        public static org.mpxj.DataType ConvertType(this DataType? value)
        {
            return value == null ? null : org.mpxj.DataType.values()[(int)value];
        }

        public static DataType? ConvertType(this org.mpxj.DataType value)
        {
            return value == null ? (DataType?)null : (DataType)value.ordinal();
        }

        // BackgroundPattern
        public static org.mpxj.mpp.BackgroundPattern ConvertType(this BackgroundPattern value)
        {
            return org.mpxj.mpp.BackgroundPattern.values()[(int)value];
        }

        public static org.mpxj.mpp.BackgroundPattern ConvertType(this BackgroundPattern? value)
        {
            return value == null ? null : org.mpxj.mpp.BackgroundPattern.values()[(int)value];
        }

        public static BackgroundPattern? ConvertType(this org.mpxj.mpp.BackgroundPattern value)
        {
            return value == null ? (BackgroundPattern?)null : (BackgroundPattern)value.ordinal();
        }

        // CalendarType
        public static org.mpxj.CalendarType ConvertType(this CalendarType value)
        {
            return org.mpxj.CalendarType.values()[(int)value];
        }

        public static org.mpxj.CalendarType ConvertType(this CalendarType? value)
        {
            return value == null ? null : org.mpxj.CalendarType.values()[(int)value];
        }

        public static CalendarType? ConvertType(this org.mpxj.CalendarType value)
        {
            return value == null ? (CalendarType?)null : (CalendarType)value.ordinal();
        }

        // DateOrder
        public static org.mpxj.DateOrder ConvertType(this DateOrder value)
        {
            return org.mpxj.DateOrder.values()[(int)value];
        }

        public static org.mpxj.DateOrder ConvertType(this DateOrder? value)
        {
            return value == null ? null : org.mpxj.DateOrder.values()[(int)value];
        }

        public static DateOrder? ConvertType(this org.mpxj.DateOrder value)
        {
            return value == null ? (DateOrder?)null : (DateOrder)value.ordinal();
        }

        // ProjectTimeFormat
        public static org.mpxj.ProjectTimeFormat ConvertType(this ProjectTimeFormat value)
        {
            return org.mpxj.ProjectTimeFormat.values()[(int)value];
        }

        public static org.mpxj.ProjectTimeFormat ConvertType(this ProjectTimeFormat? value)
        {
            return value == null ? null : org.mpxj.ProjectTimeFormat.values()[(int)value];
        }

        public static ProjectTimeFormat? ConvertType(this org.mpxj.ProjectTimeFormat value)
        {
            return value == null ? (ProjectTimeFormat?)null : (ProjectTimeFormat)value.ordinal();
        }

        // ProjectDateFormat
        public static org.mpxj.ProjectDateFormat ConvertType(this ProjectDateFormat value)
        {
            return org.mpxj.ProjectDateFormat.values()[(int)value];
        }

        public static org.mpxj.ProjectDateFormat ConvertType(this ProjectDateFormat? value)
        {
            return value == null ? null : org.mpxj.ProjectDateFormat.values()[(int)value];
        }

        public static ProjectDateFormat? ConvertType(this org.mpxj.ProjectDateFormat value)
        {
            return value == null ? (ProjectDateFormat?)null : (ProjectDateFormat)value.ordinal();
        }

        // ScheduleFrom
        public static org.mpxj.ScheduleFrom ConvertType(this ScheduleFrom value)
        {
            return org.mpxj.ScheduleFrom.values()[(int)value];
        }

        public static org.mpxj.ScheduleFrom ConvertType(this ScheduleFrom? value)
        {
            return value == null ? null : org.mpxj.ScheduleFrom.values()[(int)value];
        }

        public static ScheduleFrom? ConvertType(this org.mpxj.ScheduleFrom value)
        {
            return value == null ? (ScheduleFrom?)null : (ScheduleFrom)value.ordinal();
        }


        // CurrencySymbolPosition
        public static org.mpxj.CurrencySymbolPosition ConvertType(this CurrencySymbolPosition value)
        {
            return org.mpxj.CurrencySymbolPosition.values()[(int)value];
        }

        public static org.mpxj.CurrencySymbolPosition ConvertType(this CurrencySymbolPosition? value)
        {
            return value == null ? null : org.mpxj.CurrencySymbolPosition.values()[(int)value];
        }

        public static CurrencySymbolPosition? ConvertType(this org.mpxj.CurrencySymbolPosition value)
        {
            return value == null ? (CurrencySymbolPosition?)null : (CurrencySymbolPosition)value.ordinal();
        }

        // TaskType
        public static org.mpxj.TaskType ConvertType(this TaskType value)
        {
            return org.mpxj.TaskType.values()[(int)value];
        }

        public static org.mpxj.TaskType ConvertType(this TaskType? value)
        {
            return value == null ? null : org.mpxj.TaskType.values()[(int)value];
        }

        public static TaskType? ConvertType(this org.mpxj.TaskType value)
        {
            return value == null ? (TaskType?)null : (TaskType)value.ordinal();
        }

        // FileVersion
        public static org.mpxj.FileVersion ConvertType(this FileVersion value)
        {
            return org.mpxj.FileVersion.values()[(int)value];
        }

        public static org.mpxj.FileVersion ConvertType(this FileVersion? value)
        {
            return value == null ? null : org.mpxj.FileVersion.values()[(int)value];
        }

        public static FileVersion? ConvertType(this org.mpxj.FileVersion value)
        {
            return value == null ? (FileVersion?)null : (FileVersion)value.ordinal();
        }

        // CodePage
        public static org.mpxj.CodePage ConvertType(this CodePage value)
        {
            return org.mpxj.CodePage.values()[(int)value];
        }

        public static org.mpxj.CodePage ConvertType(this CodePage? value)
        {
            return value == null ? null : org.mpxj.CodePage.values()[(int)value];
        }

        public static CodePage? ConvertType(this org.mpxj.CodePage value)
        {
            return value == null ? (CodePage?)null : (CodePage)value.ordinal();
        }

        // CriticalActivityType
        public static org.mpxj.CriticalActivityType ConvertType(this CriticalActivityType value)
        {
            return org.mpxj.CriticalActivityType.values()[(int)value];
        }

        public static org.mpxj.CriticalActivityType ConvertType(this CriticalActivityType? value)
        {
            return value == null ? null : org.mpxj.CriticalActivityType.values()[(int)value];
        }

        public static CriticalActivityType? ConvertType(this org.mpxj.CriticalActivityType value)
        {
            return value == null ? (CriticalActivityType?)null : (CriticalActivityType)value.ordinal();
        }

        // RecurrenceType
        public static org.mpxj.RecurrenceType ConvertType(this RecurrenceType value)
        {
            return org.mpxj.RecurrenceType.values()[(int)value];
        }

        public static org.mpxj.RecurrenceType ConvertType(this RecurrenceType? value)
        {
            return value == null ? null : org.mpxj.RecurrenceType.values()[(int)value];
        }

        public static RecurrenceType? ConvertType(this org.mpxj.RecurrenceType value)
        {
            return value == null ? (RecurrenceType?)null : (RecurrenceType)value.ordinal();
        }

        // RelationType
        public static org.mpxj.RelationType ConvertType(this RelationType value)
        {
            return org.mpxj.RelationType.values()[(int)value];
        }

        public static org.mpxj.RelationType ConvertType(this RelationType? value)
        {
            return value == null ? null : org.mpxj.RelationType.values()[(int)value];
        }

        public static RelationType? ConvertType(this org.mpxj.RelationType value)
        {
            return value == null ? (RelationType?)null : (RelationType)value.ordinal();
        }

        // ResourceType
        public static org.mpxj.ResourceType ConvertType(this ResourceType value)
        {
            return org.mpxj.ResourceType.values()[(int)value];
        }

        public static org.mpxj.ResourceType ConvertType(this ResourceType? value)
        {
            return value == null ? null : org.mpxj.ResourceType.values()[(int)value];
        }

        public static ResourceType? ConvertType(this org.mpxj.ResourceType value)
        {
            return value == null ? (ResourceType?)null : (ResourceType)value.ordinal();
        }

        // WorkGroup
        public static org.mpxj.WorkGroup ConvertType(this WorkGroup value)
        {
            return org.mpxj.WorkGroup.values()[(int)value];
        }

        public static org.mpxj.WorkGroup ConvertType(this WorkGroup? value)
        {
            return value == null ? null : org.mpxj.WorkGroup.values()[(int)value];
        }

        public static WorkGroup? ConvertType(this org.mpxj.WorkGroup value)
        {
            return value == null ? (WorkGroup?)null : (WorkGroup)value.ordinal();
        }

        // BookingType
        public static org.mpxj.BookingType ConvertType(this BookingType value)
        {
            return org.mpxj.BookingType.values()[(int)value];
        }

        public static org.mpxj.BookingType ConvertType(this BookingType? value)
        {
            return value == null ? null : org.mpxj.BookingType.values()[(int)value];
        }

        public static BookingType? ConvertType(this org.mpxj.BookingType value)
        {
            return value == null ? (BookingType?)null : (BookingType)value.ordinal();
        }

        // RateSource
        public static org.mpxj.RateSource ConvertType(this RateSource value)
        {
            return org.mpxj.RateSource.values()[(int)value];
        }

        public static org.mpxj.RateSource ConvertType(this RateSource? value)
        {
            return value == null ? null : org.mpxj.RateSource.values()[(int)value];
        }

        public static RateSource? ConvertType(this org.mpxj.RateSource value)
        {
            return value == null ? (RateSource?)null : (RateSource)value.ordinal();
        }

        // ResourceRequestType
        public static org.mpxj.ResourceRequestType ConvertType(this ResourceRequestType value)
        {
            return org.mpxj.ResourceRequestType.values()[(int)value];
        }

        public static org.mpxj.ResourceRequestType ConvertType(this ResourceRequestType? value)
        {
            return value == null ? null : org.mpxj.ResourceRequestType.values()[(int)value];
        }

        public static ResourceRequestType? ConvertType(this org.mpxj.ResourceRequestType value)
        {
            return value == null ? (ResourceRequestType?)null : (ResourceRequestType)value.ordinal();
        }

        // ConstraintType
        public static org.mpxj.ConstraintType ConvertType(this ConstraintType value)
        {
            return org.mpxj.ConstraintType.values()[(int)value];
        }

        public static org.mpxj.ConstraintType ConvertType(this ConstraintType? value)
        {
            return value == null ? null : org.mpxj.ConstraintType.values()[(int)value];
        }

        public static ConstraintType? ConvertType(this org.mpxj.ConstraintType value)
        {
            return value == null ? (ConstraintType?)null : (ConstraintType)value.ordinal();
        }

        // TaskMode
        public static org.mpxj.TaskMode ConvertType(this TaskMode value)
        {
            return org.mpxj.TaskMode.values()[(int)value];
        }

        public static org.mpxj.TaskMode ConvertType(this TaskMode? value)
        {
            return value == null ? null : org.mpxj.TaskMode.values()[(int)value];
        }

        public static TaskMode? ConvertType(this org.mpxj.TaskMode value)
        {
            return value == null ? (TaskMode?)null : (TaskMode)value.ordinal();
        }

        // PercentCompleteType
        public static org.mpxj.PercentCompleteType ConvertType(this PercentCompleteType value)
        {
            return org.mpxj.PercentCompleteType.values()[(int)value];
        }

        public static org.mpxj.PercentCompleteType ConvertType(this PercentCompleteType? value)
        {
            return value == null ? null : org.mpxj.PercentCompleteType.values()[(int)value];
        }

        public static PercentCompleteType? ConvertType(this org.mpxj.PercentCompleteType value)
        {
            return value == null ? (PercentCompleteType?)null : (PercentCompleteType)value.ordinal();
        }

        // ActivityType
        public static org.mpxj.ActivityType ConvertType(this ActivityType value)
        {
            return org.mpxj.ActivityType.values()[(int)value];
        }

        public static org.mpxj.ActivityType ConvertType(this ActivityType? value)
        {
            return value == null ? null : org.mpxj.ActivityType.values()[(int)value];
        }

        public static ActivityType? ConvertType(this org.mpxj.ActivityType value)
        {
            return value == null ? (ActivityType?)null : (ActivityType)value.ordinal();
        }

        // ViewType
        public static org.mpxj.ViewType ConvertType(this ViewType value)
        {
            return org.mpxj.ViewType.values()[(int)value];
        }

        public static org.mpxj.ViewType ConvertType(this ViewType? value)
        {
            return value == null ? null : org.mpxj.ViewType.values()[(int)value];
        }

        public static ViewType? ConvertType(this org.mpxj.ViewType value)
        {
            return value == null ? (ViewType?)null : (ViewType)value.ordinal();
        }

        // SaveVersion
        public static org.mpxj.mspdi.SaveVersion ConvertType(this SaveVersion value)
        {
            return org.mpxj.mspdi.SaveVersion.values()[(int)value];
        }

        public static org.mpxj.mspdi.SaveVersion ConvertType(this SaveVersion? value)
        {
            return value == null ? null : org.mpxj.mspdi.SaveVersion.values()[(int)value];
        }

        public static SaveVersion? ConvertType(this org.mpxj.mspdi.SaveVersion value)
        {
            return value == null ? (SaveVersion?)null : (SaveVersion)value.ordinal();
        }

        // FileFormat
        public static org.mpxj.writer.FileFormat ConvertType(this FileFormat value)
        {
            return org.mpxj.writer.FileFormat.values()[(int)value];
        }

        public static org.mpxj.writer.FileFormat ConvertType(this FileFormat? value)
        {
            return value == null ? null : org.mpxj.writer.FileFormat.values()[(int)value];
        }

        public static FileFormat? ConvertType(this org.mpxj.writer.FileFormat value)
        {
            return value == null ? (FileFormat?)null : (FileFormat)value.ordinal();
        }

        // TotalSlackCalculationType
        public static org.mpxj.TotalSlackCalculationType ConvertType(this TotalSlackCalculationType value)
        {
            return org.mpxj.TotalSlackCalculationType.values()[(int)value];
        }

        public static org.mpxj.TotalSlackCalculationType ConvertType(this TotalSlackCalculationType? value)
        {
            return value == null ? null : org.mpxj.TotalSlackCalculationType.values()[(int)value];
        }

        public static TotalSlackCalculationType? ConvertType(this org.mpxj.TotalSlackCalculationType value)
        {
            return value == null ? (TotalSlackCalculationType?)null : (TotalSlackCalculationType)value.ordinal();
        }

        // RelationshipLagCalendar
        public static org.mpxj.RelationshipLagCalendar ConvertType(this RelationshipLagCalendar value)
        {
            return org.mpxj.RelationshipLagCalendar.values()[(int)value];
        }

        public static org.mpxj.RelationshipLagCalendar ConvertType(this RelationshipLagCalendar? value)
        {
            return value == null ? null : org.mpxj.RelationshipLagCalendar.values()[(int)value];
        }

        public static RelationshipLagCalendar? ConvertType(this org.mpxj.RelationshipLagCalendar value)
        {
            return value == null ? (RelationshipLagCalendar?)null : (RelationshipLagCalendar)value.ordinal();
        }

        // SchedulingProgressedActivities
        public static org.mpxj.SchedulingProgressedActivities ConvertType(this SchedulingProgressedActivities value)
        {
            return org.mpxj.SchedulingProgressedActivities.values()[(int)value];
        }

        public static org.mpxj.SchedulingProgressedActivities ConvertType(this SchedulingProgressedActivities? value)
        {
            return value == null ? null : org.mpxj.SchedulingProgressedActivities.values()[(int)value];
        }

        public static SchedulingProgressedActivities? ConvertType(this org.mpxj.SchedulingProgressedActivities value)
        {
            return value == null ? (SchedulingProgressedActivities?)null : (SchedulingProgressedActivities)value.ordinal();
        }

        // SkillLevel
        public static org.mpxj.SkillLevel ConvertType(this SkillLevel value)
        {
            return org.mpxj.SkillLevel.values()[(int)value];
        }

        public static org.mpxj.SkillLevel ConvertType(this SkillLevel? value)
        {
            return value == null ? null : org.mpxj.SkillLevel.values()[(int)value];
        }

        public static SkillLevel? ConvertType(this org.mpxj.SkillLevel value)
        {
            return value == null ? (SkillLevel?)null : (SkillLevel)value.ordinal();
        }
        
        // OpcExportType
        public static org.mpxj.opc.OpcExportType ConvertType(this OpcExportType value)
        {
            return org.mpxj.opc.OpcExportType.values()[(int)value];
        }
        
        // WebServicesExportType
        public static org.mpxj.primavera.webservices.WebServicesExportType ConvertType(this WebServicesExportType value)
        {
            return org.mpxj.primavera.webservices.WebServicesExportType.values()[(int)value];
        }
        
        // TimescaleUnits
        public static org.mpxj.TimescaleUnits ConvertType(this TimescaleUnits value)
        {
            return org.mpxj.TimescaleUnits.values()[(int)value];
        }
    }
}
