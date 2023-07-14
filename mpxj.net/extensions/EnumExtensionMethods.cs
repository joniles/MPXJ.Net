namespace org.mpxj
{
    internal static class EnumExtensionMethods
    {
        // DayType
        public static net.sf.mpxj.DayType ConvertType(this DayType value)
        {
            return net.sf.mpxj.DayType.getInstance((int)value);
        }

        public static net.sf.mpxj.DayType ConvertType(this DayType? value)
        {
            return value == null ? null : net.sf.mpxj.DayType.getInstance((int)value);
        }

        public static DayType? ConvertType(this net.sf.mpxj.DayType value)
        {
            return value == null ? (DayType?)null : (DayType)value.getValue();
        }

        // TimeUnit
        public static net.sf.mpxj.TimeUnit ConvertType(this TimeUnit value)
        {
            return net.sf.mpxj.TimeUnit.getInstance((int)value);
        }

        public static net.sf.mpxj.TimeUnit ConvertType(this TimeUnit? value)
        {
            return value == null ? null : net.sf.mpxj.TimeUnit.getInstance((int)value);
        }

        public static TimeUnit? ConvertType(this net.sf.mpxj.TimeUnit value)
        {
            return value == null ? (TimeUnit?)null : (TimeUnit)value.getValue();
        }

        // AccrueType
        public static net.sf.mpxj.AccrueType ConvertType(this AccrueType value)
        {
            return net.sf.mpxj.AccrueType.getInstance((int)value);
        }

        public static net.sf.mpxj.AccrueType ConvertType(this AccrueType? value)
        {
            return value == null ? null : net.sf.mpxj.AccrueType.getInstance((int)value);
        }

        public static AccrueType? ConvertType(this net.sf.mpxj.AccrueType value)
        {
            return value == null ? (AccrueType?)null : (AccrueType)value.getValue();
        }

        // EarnedValueMethod
        public static net.sf.mpxj.EarnedValueMethod ConvertType(this EarnedValueMethod value)
        {
            return net.sf.mpxj.EarnedValueMethod.getInstance((int)value);
        }

        public static net.sf.mpxj.EarnedValueMethod ConvertType(this EarnedValueMethod? value)
        {
            return value == null ? null : net.sf.mpxj.EarnedValueMethod.getInstance((int)value);
        }

        public static EarnedValueMethod? ConvertType(this net.sf.mpxj.EarnedValueMethod value)
        {
            return value == null ? (EarnedValueMethod?)null : (EarnedValueMethod)value.getValue();
        }

        // ActivityStatus
        public static net.sf.mpxj.ActivityStatus ConvertType(this ActivityStatus value)
        {
            return net.sf.mpxj.ActivityStatus.values()[(int)value];
        }

        public static net.sf.mpxj.ActivityStatus ConvertType(this ActivityStatus? value)
        {
            return value == null ? null : net.sf.mpxj.ActivityStatus.values()[(int)value];
        }

        public static ActivityStatus? ConvertType(this net.sf.mpxj.ActivityStatus value)
        {
            return value == null ? (ActivityStatus?)null : (ActivityStatus)value.ordinal();
        }

        // FieldTypeClass
        public static net.sf.mpxj.FieldTypeClass ConvertType(this FieldTypeClass value)
        {
            return net.sf.mpxj.FieldTypeClass.values()[(int)value];
        }

        public static net.sf.mpxj.FieldTypeClass ConvertType(this FieldTypeClass? value)
        {
            return value == null ? null : net.sf.mpxj.FieldTypeClass.values()[(int)value];
        }

        public static FieldTypeClass? ConvertType(this net.sf.mpxj.FieldTypeClass value)
        {
            return value == null ? (FieldTypeClass?)null : (FieldTypeClass)value.ordinal();
        }

        // CustomFieldValueDataType
        public static net.sf.mpxj.CustomFieldValueDataType ConvertType(this CustomFieldValueDataType value)
        {
            return net.sf.mpxj.CustomFieldValueDataType.values()[(int)value];
        }

        public static net.sf.mpxj.CustomFieldValueDataType ConvertType(this CustomFieldValueDataType? value)
        {
            return value == null ? null : net.sf.mpxj.CustomFieldValueDataType.values()[(int)value];
        }

        public static CustomFieldValueDataType? ConvertType(this net.sf.mpxj.CustomFieldValueDataType value)
        {
            return value == null ? (CustomFieldValueDataType?)null : (CustomFieldValueDataType)value.ordinal();
        }

        // TestOperator
        public static net.sf.mpxj.TestOperator ConvertType(this TestOperator value)
        {
            return net.sf.mpxj.TestOperator.values()[(int)value];
        }

        public static net.sf.mpxj.TestOperator ConvertType(this TestOperator? value)
        {
            return value == null ? null : net.sf.mpxj.TestOperator.values()[(int)value];
        }

        public static TestOperator? ConvertType(this net.sf.mpxj.TestOperator value)
        {
            return value == null ? (TestOperator?)null : (TestOperator)value.ordinal();
        }

        // ActivityCodeScope
        public static net.sf.mpxj.ActivityCodeScope ConvertType(this ActivityCodeScope value)
        {
            return net.sf.mpxj.ActivityCodeScope.values()[(int)value];
        }

        public static net.sf.mpxj.ActivityCodeScope ConvertType(this ActivityCodeScope? value)
        {
            return value == null ? null : net.sf.mpxj.ActivityCodeScope.values()[(int)value];
        }

        public static ActivityCodeScope? ConvertType(this net.sf.mpxj.ActivityCodeScope value)
        {
            return value == null ? (ActivityCodeScope?)null : (ActivityCodeScope)value.ordinal();
        }

        // DataType
        public static net.sf.mpxj.DataType ConvertType(this DataType value)
        {
            return net.sf.mpxj.DataType.values()[(int)value];
        }

        public static net.sf.mpxj.DataType ConvertType(this DataType? value)
        {
            return value == null ? null : net.sf.mpxj.DataType.values()[(int)value];
        }

        public static DataType? ConvertType(this net.sf.mpxj.DataType value)
        {
            return value == null ? (DataType?)null : (DataType)value.ordinal();
        }

        // BackgroundPattern
        public static net.sf.mpxj.mpp.BackgroundPattern ConvertType(this BackgroundPattern value)
        {
            return net.sf.mpxj.mpp.BackgroundPattern.values()[(int)value];
        }

        public static net.sf.mpxj.mpp.BackgroundPattern ConvertType(this BackgroundPattern? value)
        {
            return value == null ? null : net.sf.mpxj.mpp.BackgroundPattern.values()[(int)value];
        }

        public static BackgroundPattern? ConvertType(this net.sf.mpxj.mpp.BackgroundPattern value)
        {
            return value == null ? (BackgroundPattern?)null : (BackgroundPattern)value.ordinal();
        }

        // CalendarType
        public static net.sf.mpxj.CalendarType ConvertType(this CalendarType value)
        {
            return net.sf.mpxj.CalendarType.values()[(int)value];
        }

        public static net.sf.mpxj.CalendarType ConvertType(this CalendarType? value)
        {
            return value == null ? null : net.sf.mpxj.CalendarType.values()[(int)value];
        }

        public static CalendarType? ConvertType(this net.sf.mpxj.CalendarType value)
        {
            return value == null ? (CalendarType?)null : (CalendarType)value.ordinal();
        }

        // DateOrder
        public static net.sf.mpxj.DateOrder ConvertType(this DateOrder value)
        {
            return net.sf.mpxj.DateOrder.values()[(int)value];
        }

        public static net.sf.mpxj.DateOrder ConvertType(this DateOrder? value)
        {
            return value == null ? null : net.sf.mpxj.DateOrder.values()[(int)value];
        }

        public static DateOrder? ConvertType(this net.sf.mpxj.DateOrder value)
        {
            return value == null ? (DateOrder?)null : (DateOrder)value.ordinal();
        }

        // ProjectTimeFormat
        public static net.sf.mpxj.ProjectTimeFormat ConvertType(this ProjectTimeFormat value)
        {
            return net.sf.mpxj.ProjectTimeFormat.values()[(int)value];
        }

        public static net.sf.mpxj.ProjectTimeFormat ConvertType(this ProjectTimeFormat? value)
        {
            return value == null ? null : net.sf.mpxj.ProjectTimeFormat.values()[(int)value];
        }

        public static ProjectTimeFormat? ConvertType(this net.sf.mpxj.ProjectTimeFormat value)
        {
            return value == null ? (ProjectTimeFormat?)null : (ProjectTimeFormat)value.ordinal();
        }

        // ProjectDateFormat
        public static net.sf.mpxj.ProjectDateFormat ConvertType(this ProjectDateFormat value)
        {
            return net.sf.mpxj.ProjectDateFormat.values()[(int)value];
        }

        public static net.sf.mpxj.ProjectDateFormat ConvertType(this ProjectDateFormat? value)
        {
            return value == null ? null : net.sf.mpxj.ProjectDateFormat.values()[(int)value];
        }

        public static ProjectDateFormat? ConvertType(this net.sf.mpxj.ProjectDateFormat value)
        {
            return value == null ? (ProjectDateFormat?)null : (ProjectDateFormat)value.ordinal();
        }

        // ScheduleFrom
        public static net.sf.mpxj.ScheduleFrom ConvertType(this ScheduleFrom value)
        {
            return net.sf.mpxj.ScheduleFrom.values()[(int)value];
        }

        public static net.sf.mpxj.ScheduleFrom ConvertType(this ScheduleFrom? value)
        {
            return value == null ? null : net.sf.mpxj.ScheduleFrom.values()[(int)value];
        }

        public static ScheduleFrom? ConvertType(this net.sf.mpxj.ScheduleFrom value)
        {
            return value == null ? (ScheduleFrom?)null : (ScheduleFrom)value.ordinal();
        }


        // CurrencySymbolPosition
        public static net.sf.mpxj.CurrencySymbolPosition ConvertType(this CurrencySymbolPosition value)
        {
            return net.sf.mpxj.CurrencySymbolPosition.values()[(int)value];
        }

        public static net.sf.mpxj.CurrencySymbolPosition ConvertType(this CurrencySymbolPosition? value)
        {
            return value == null ? null : net.sf.mpxj.CurrencySymbolPosition.values()[(int)value];
        }

        public static CurrencySymbolPosition? ConvertType(this net.sf.mpxj.CurrencySymbolPosition value)
        {
            return value == null ? (CurrencySymbolPosition?)null : (CurrencySymbolPosition)value.ordinal();
        }

        // TaskType
        public static net.sf.mpxj.TaskType ConvertType(this TaskType value)
        {
            return net.sf.mpxj.TaskType.values()[(int)value];
        }

        public static net.sf.mpxj.TaskType ConvertType(this TaskType? value)
        {
            return value == null ? null : net.sf.mpxj.TaskType.values()[(int)value];
        }

        public static TaskType? ConvertType(this net.sf.mpxj.TaskType value)
        {
            return value == null ? (TaskType?)null : (TaskType)value.ordinal();
        }

        // FileVersion
        public static net.sf.mpxj.FileVersion ConvertType(this FileVersion value)
        {
            return net.sf.mpxj.FileVersion.values()[(int)value];
        }

        public static net.sf.mpxj.FileVersion ConvertType(this FileVersion? value)
        {
            return value == null ? null : net.sf.mpxj.FileVersion.values()[(int)value];
        }

        public static FileVersion? ConvertType(this net.sf.mpxj.FileVersion value)
        {
            return value == null ? (FileVersion?)null : (FileVersion)value.ordinal();
        }

        // CodePage
        public static net.sf.mpxj.CodePage ConvertType(this CodePage value)
        {
            return net.sf.mpxj.CodePage.values()[(int)value];
        }

        public static net.sf.mpxj.CodePage ConvertType(this CodePage? value)
        {
            return value == null ? null : net.sf.mpxj.CodePage.values()[(int)value];
        }

        public static CodePage? ConvertType(this net.sf.mpxj.CodePage value)
        {
            return value == null ? (CodePage?)null : (CodePage)value.ordinal();
        }

        // CriticalActivityType
        public static net.sf.mpxj.CriticalActivityType ConvertType(this CriticalActivityType value)
        {
            return net.sf.mpxj.CriticalActivityType.values()[(int)value];
        }

        public static net.sf.mpxj.CriticalActivityType ConvertType(this CriticalActivityType? value)
        {
            return value == null ? null : net.sf.mpxj.CriticalActivityType.values()[(int)value];
        }

        public static CriticalActivityType? ConvertType(this net.sf.mpxj.CriticalActivityType value)
        {
            return value == null ? (CriticalActivityType?)null : (CriticalActivityType)value.ordinal();
        }

        // RecurrenceType
        public static net.sf.mpxj.RecurrenceType ConvertType(this RecurrenceType value)
        {
            return net.sf.mpxj.RecurrenceType.values()[(int)value];
        }

        public static net.sf.mpxj.RecurrenceType ConvertType(this RecurrenceType? value)
        {
            return value == null ? null : net.sf.mpxj.RecurrenceType.values()[(int)value];
        }

        public static RecurrenceType? ConvertType(this net.sf.mpxj.RecurrenceType value)
        {
            return value == null ? (RecurrenceType?)null : (RecurrenceType)value.ordinal();
        }

        // RelationType
        public static net.sf.mpxj.RelationType ConvertType(this RelationType value)
        {
            return net.sf.mpxj.RelationType.values()[(int)value];
        }

        public static net.sf.mpxj.RelationType ConvertType(this RelationType? value)
        {
            return value == null ? null : net.sf.mpxj.RelationType.values()[(int)value];
        }

        public static RelationType? ConvertType(this net.sf.mpxj.RelationType value)
        {
            return value == null ? (RelationType?)null : (RelationType)value.ordinal();
        }

        // ResourceType
        public static net.sf.mpxj.ResourceType ConvertType(this ResourceType value)
        {
            return net.sf.mpxj.ResourceType.values()[(int)value];
        }

        public static net.sf.mpxj.ResourceType ConvertType(this ResourceType? value)
        {
            return value == null ? null : net.sf.mpxj.ResourceType.values()[(int)value];
        }

        public static ResourceType? ConvertType(this net.sf.mpxj.ResourceType value)
        {
            return value == null ? (ResourceType?)null : (ResourceType)value.ordinal();
        }

        // WorkGroup
        public static net.sf.mpxj.WorkGroup ConvertType(this WorkGroup value)
        {
            return net.sf.mpxj.WorkGroup.values()[(int)value];
        }

        public static net.sf.mpxj.WorkGroup ConvertType(this WorkGroup? value)
        {
            return value == null ? null : net.sf.mpxj.WorkGroup.values()[(int)value];
        }

        public static WorkGroup? ConvertType(this net.sf.mpxj.WorkGroup value)
        {
            return value == null ? (WorkGroup?)null : (WorkGroup)value.ordinal();
        }

        // BookingType
        public static net.sf.mpxj.BookingType ConvertType(this BookingType value)
        {
            return net.sf.mpxj.BookingType.values()[(int)value];
        }

        public static net.sf.mpxj.BookingType ConvertType(this BookingType? value)
        {
            return value == null ? null : net.sf.mpxj.BookingType.values()[(int)value];
        }

        public static BookingType? ConvertType(this net.sf.mpxj.BookingType value)
        {
            return value == null ? (BookingType?)null : (BookingType)value.ordinal();
        }

        // RateSource
        public static net.sf.mpxj.RateSource ConvertType(this RateSource value)
        {
            return net.sf.mpxj.RateSource.values()[(int)value];
        }

        public static net.sf.mpxj.RateSource ConvertType(this RateSource? value)
        {
            return value == null ? null : net.sf.mpxj.RateSource.values()[(int)value];
        }

        public static RateSource? ConvertType(this net.sf.mpxj.RateSource value)
        {
            return value == null ? (RateSource?)null : (RateSource)value.ordinal();
        }
    }
}
