using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class LocalTimeRange : IJavaObjectProxy<net.sf.mpxj.LocalTimeRange>
    {
        public net.sf.mpxj.LocalTimeRange JavaObject { get; }

        internal LocalTimeRange(net.sf.mpxj.LocalTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public LocalTimeRange(TimeOnly start, TimeOnly end)
        {
            JavaObject = new net.sf.mpxj.LocalTimeRange(start.ConvertType(), end.ConvertType());
        }

        public TimeOnly? Start => JavaObject.getStart().ConvertType();

        public TimeOnly? End => JavaObject.getEnd().ConvertType();

        public long DurationAsMilliseconds => JavaObject.getDurationAsMilliseconds();

        public override string ToString() => JavaObject.toString();

        public override bool Equals(object obj) => this.Equals(obj as LocalTimeRange);

        public bool Equals(LocalTimeRange d) => JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(LocalTimeRange lhs, LocalTimeRange rhs) => lhs is null ? rhs is null : lhs.Equals(rhs);

        public static bool operator !=(LocalTimeRange lhs, LocalTimeRange rhs) => !(lhs == rhs);
    }
}
