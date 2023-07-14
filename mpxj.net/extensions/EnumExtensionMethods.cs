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
            return value == null ? (TimeUnit?) null : (TimeUnit)value.getValue();
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
    }
}

