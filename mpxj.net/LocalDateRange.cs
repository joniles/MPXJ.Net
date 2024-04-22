using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class LocalDateRange : IJavaObjectProxy<net.sf.mpxj.LocalDateRange>
    {
        public net.sf.mpxj.LocalDateRange JavaObject { get; }

        internal LocalDateRange(net.sf.mpxj.LocalDateRange javaObject)
        {
            JavaObject = javaObject;
        }

        public LocalDateRange(DateOnly startDate, DateOnly endDate)
        {
            JavaObject = new net.sf.mpxj.LocalDateRange(startDate.ConvertType(), endDate.ConvertType());
        }

        public DateOnly? Start => JavaObject.getStart().ConvertType();

        public DateOnly? End => JavaObject.getEnd().ConvertType();

        public override string ToString() => JavaObject.toString();

        public override bool Equals(object obj) => this.Equals(obj as LocalDateRange);

        public bool Equals(LocalDateRange d) => JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(LocalDateRange lhs, LocalDateRange rhs) => lhs is null ? rhs is null : lhs.Equals(rhs);

        public static bool operator !=(LocalDateRange lhs, LocalDateRange rhs) => !(lhs == rhs);
    }
}

