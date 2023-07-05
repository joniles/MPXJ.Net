using System;

namespace org.mpxj
{
	internal static class ExtensionMethods
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
    }
}

