using System;

namespace org.mpxj
{
    internal static class ExtensionMethods
	{
        public static Guid? FromJava(this java.util.UUID value)
        {
            return value == null ? (Guid?)null : new Guid(value.toString());
        }

        public static java.util.UUID ToJava(this Guid? g)
        {
            return g == null ? null : java.util.UUID.fromString(g.ToString());
        }

        public static java.util.UUID ToJava(this Guid g)
        {
            return java.util.UUID.fromString(g.ToString());
        }
    }
}

