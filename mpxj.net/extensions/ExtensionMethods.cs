﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MPXJ.Net.Proxy;
// ReSharper disable RedundantCast

namespace MPXJ.Net
{
    internal static class ExtensionMethods
	{
        private static readonly Dictionary<java.time.DayOfWeek, DayOfWeek> FromJavaDayOfWeek = new Dictionary<java.time.DayOfWeek, DayOfWeek>
        {
            { java.time.DayOfWeek.MONDAY, DayOfWeek.Monday },
            { java.time.DayOfWeek.TUESDAY, DayOfWeek.Tuesday },
            { java.time.DayOfWeek.WEDNESDAY, DayOfWeek.Wednesday },
            { java.time.DayOfWeek.THURSDAY, DayOfWeek.Thursday },
            { java.time.DayOfWeek.FRIDAY, DayOfWeek.Friday },
            { java.time.DayOfWeek.SATURDAY, DayOfWeek.Saturday },
            { java.time.DayOfWeek.SUNDAY, DayOfWeek.Sunday }
        };

        private static readonly Dictionary<DayOfWeek, java.time.DayOfWeek> ToJavaDayOfWeek = new Dictionary<DayOfWeek, java.time.DayOfWeek>
        {
            { DayOfWeek.Monday, java.time.DayOfWeek.MONDAY },
            { DayOfWeek.Tuesday, java.time.DayOfWeek.TUESDAY },
            { DayOfWeek.Wednesday, java.time.DayOfWeek.WEDNESDAY },
            { DayOfWeek.Thursday, java.time.DayOfWeek.THURSDAY },
            { DayOfWeek.Friday, java.time.DayOfWeek.FRIDAY },
            { DayOfWeek.Saturday, java.time.DayOfWeek.SATURDAY },
            { DayOfWeek.Sunday, java.time.DayOfWeek.SUNDAY }
        };

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
            return value?.intValue();
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
            return value?.doubleValue();
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
            return value?.doubleValue();
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
            return java.time.LocalTime.of(t.Hour, t.Minute, t.Second);
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

        public static DayOfWeek? ConvertType(this java.time.DayOfWeek value)
        {
            return value == null ? (DayOfWeek?)null : FromJavaDayOfWeek[value];
        }

        public static java.time.DayOfWeek ConvertType(this DayOfWeek value)
        {
            return ToJavaDayOfWeek[value];
        }

        public static java.time.DayOfWeek ConvertType(this DayOfWeek? value)
        {
            return value == null ? null : ToJavaDayOfWeek[value.Value];
        }

        public static DateOnly? ConvertType(this java.time.LocalDate value)
        {
            return value == null ? (DateOnly?)null : new DateOnly(value.getYear(), value.getMonthValue(), value.getDayOfMonth());
        }

        public static java.time.LocalDate ConvertType(this DateOnly? t)
        {
            return t == null ? null : java.time.LocalDate.of(t.Value.Year, t.Value.Month, t.Value.Day);
        }

        public static java.time.LocalDate ConvertType(this DateOnly t)
        {
            return java.time.LocalDate.of(t.Year, t.Month, t.Day);
        }

        public static Encoding ConvertType(this java.nio.charset.Charset charset)
        {
            return Encoding.GetEncoding(charset.name());
        }

        public static java.nio.charset.Charset ConvertType(this Encoding encoding)
        {
            return java.nio.charset.Charset.forName(encoding.WebName);
        }

        public static CultureInfo ConvertType(this java.util.Locale value)
        {
            return CultureInfo.GetCultureInfoByIetfLanguageTag(value.toLanguageTag());
        }

        public static java.util.Locale ConvertType(this CultureInfo value)
        {
            return java.util.Locale.forLanguageTag(value.IetfLanguageTag);
        }

        public static java.io.InputStream ConvertType(this Stream stream)
        {
            return new ProxyInputStream(stream);
        }

        public static java.util.List ConvertType<N>(this IList<N> list) where N : IHasJavaObject
        {
            if (list is IJavaObjectProxy<java.util.List> proxy)
            {
                return proxy.JavaObject;
            }
            
            return java.util.Arrays.asList( list.Select(n => n.GenericJavaObject()).ToArray());
        }

        public static java.util.Map ConvertType<K, V>(this IDictionary<K, V> dictionary)
        {
            if (dictionary is IJavaObjectProxy<java.util.Map> proxy)
            {
                return proxy.JavaObject;
            }

            var map = new java.util.HashMap();
            foreach (var entry in dictionary)
            {
                map.put(entry.Key.GenericJavaObject(), entry.Value.GenericJavaObject());
            }
            return map;
        }

        public static object GenericJavaObject(this object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o is IHasJavaObject)
            {
                return GetJavaObjectPropertyValue(o);
            }

            if (o is string)
            {
                return o;
            }

            if (o is bool boolValue)
            {
                return java.lang.Boolean.valueOf(boolValue);
            }

            if (o is int intValue)
            {
                return java.lang.Integer.valueOf(intValue);
            }

            if (o is long longValue)
            {
                return java.lang.Long.valueOf(longValue);
            }

            if (o is double doubleValue)
            {
                return java.lang.Double.valueOf(doubleValue);
            }
            
            if (o is decimal decimalValue)
            {
                return java.lang.Double.valueOf((double)decimalValue);
            }
            
            if (o is DateTime dateTimeValue)
            {
                return dateTimeValue.ConvertType();
            }

            if (o is DateOnly dateOnlyValue)
            {
                return dateOnlyValue.ConvertType();
            }

            if (o is TimeOnly timeOnlyValue)
            {
                return timeOnlyValue.ConvertType();
            }

            throw new NotSupportedException($"Conversion not defined for {o.GetType()}");
        }

        // https://stackoverflow.com/questions/994698/ambiguousmatchexception-type-getproperty-c-sharp-reflection/994717#994717
        private static object GetJavaObjectPropertyValue(object o)
        {
            var type = o.GetType();
            while (type != null)
            {
                var property = type.GetProperty("JavaObject", BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                if (property != null)
                {
                    return property.GetValue(o, null);
                }
                type = type.BaseType;
            }

            return null;
        }
    }
}

