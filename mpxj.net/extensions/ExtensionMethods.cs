using System;
using System.Drawing;
using org.mpxj.proxy;

namespace org.mpxj
{
    internal static class ExtensionMethods
	{
        public static Guid? ConvertType(this java.util.UUID value)
        {
            return value == null ? (Guid?)null : new Guid(value.toString());
        }

        public static java.util.UUID ConvertType(this Guid? g)
        {
            return g == null ? null : java.util.UUID.fromString(g.ToString());
        }

        public static java.util.UUID ConvertType(this Guid g)
        {
            return java.util.UUID.fromString(g.ToString());
        }

        public static int? ConvertType(this java.lang.Integer value)
        {
            return value == null ? (int?)null : value.intValue();
        }

        public static java.lang.Integer ConvertType(this int? value)
        {
            return value == null ? null : java.lang.Integer.valueOf(value.Value);
        }

        public static java.lang.Integer ConvertType(this int value)
        {
            return java.lang.Integer.valueOf(value);
        }

        public static double? ConvertType(this java.lang.Double value)
        {
            return value == null ? (double?)null : value.doubleValue();
        }

        public static java.lang.Double ConvertType(this double? value)
        {
            return value == null ? null : java.lang.Double.valueOf(value.Value);
        }

        public static java.lang.Double ConvertType(this double value)
        {
            return java.lang.Double.valueOf(value);
        }

        public static double? ConvertType(this java.lang.Number value)
        {
            return value == null ? (double?)null : value.doubleValue();
        }

        public static Color? ConvertType(this java.awt.Color color)
        {
            return color == null ? (Color?)null : Color.FromArgb(color.getRGB());
        }

        public static java.awt.Color ConvertType(this Color? color)
        {
            return color == null ? null : new java.awt.Color(color.Value.R, color.Value.G, color.Value.B);
        }

        public static java.awt.Color ConvertType(this Color color)
        {
            return new java.awt.Color(color.R, color.G, color.B);
        }

        public static TimeOnly? ConvertType(this java.time.LocalTime value)
        {
            return value == null ? (TimeOnly?)null : new TimeOnly(value.getHour(), value.getMinute(), value.getSecond());
        }

        public static java.time.LocalTime ConvertType(this TimeOnly? t)
        {
            return t == null ? null : java.time.LocalTime.of(t.Value.Hour, t.Value.Minute, t.Value.Second);
        }

        public static java.time.LocalTime ConvertType(this TimeOnly t)
        {
            return t == null ? null : java.time.LocalTime.of(t.Hour, t.Minute, t.Second);
        }

        public static DateTime? ConvertType(this java.time.LocalDateTime value)
        {
            return value == null ? (DateTime?)null : new DateTime(value.getYear(), value.getMonthValue(), value.getDayOfMonth(), value.getHour(), value.getMinute(), value.getSecond());
        }

        public static java.time.LocalDateTime ConvertType(this DateTime value)
        {
            return java.time.LocalDateTime.of(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
        }

        public static java.time.LocalDateTime ConvertType(this DateTime? value)
        {
            return value == null ? null : java.time.LocalDateTime.of(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, value.Value.Minute, value.Value.Second);
        }

        public static object GenericJavaObject(this object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o is IHasJavaObject)
            {
                return o.GetType().GetProperty("JavaObject").GetValue(o, null);
            }

            // TODO - all other type conversions

            return null;
        }

    }
}

