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
    }
}

