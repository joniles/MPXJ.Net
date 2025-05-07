using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class DateOnlyRange : IJavaObjectProxy<org.mpxj.LocalDateRange>
    {
        public org.mpxj.LocalDateRange JavaObject { get; }

        internal DateOnlyRange(org.mpxj.LocalDateRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateOnlyRange(DateOnly startDate, DateOnly endDate)
        {
            JavaObject = new org.mpxj.LocalDateRange(startDate.ConvertType(), endDate.ConvertType());
        }

        public DateOnly? Start => JavaObject.getStart().ConvertType();

        public DateOnly? End => JavaObject.getEnd().ConvertType();

        public override string ToString() => JavaObject.toString();

        public override bool Equals(object obj) => Equals(obj as DateOnlyRange);

        public bool Equals(DateOnlyRange d) => d != null && JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(DateOnlyRange lhs, DateOnlyRange rhs) => lhs?.Equals(rhs) ?? rhs is null;

        public static bool operator !=(DateOnlyRange lhs, DateOnlyRange rhs) => !(lhs == rhs);
    }
}

