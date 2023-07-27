﻿using System;
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

