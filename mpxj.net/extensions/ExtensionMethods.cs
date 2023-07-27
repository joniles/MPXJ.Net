using System;
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

