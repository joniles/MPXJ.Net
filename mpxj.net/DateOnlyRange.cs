using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class DateOnlyRange : IJavaObjectProxy<net.sf.mpxj.LocalDateRange>
    {
        public net.sf.mpxj.LocalDateRange JavaObject { get; }

        internal DateOnlyRange(net.sf.mpxj.LocalDateRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateOnlyRange(DateOnly startDate, DateOnly endDate)
        {
            JavaObject = new net.sf.mpxj.LocalDateRange(startDate.ConvertType(), endDate.ConvertType());
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

