using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimeOnlyRange : IJavaObjectProxy<org.mpxj.LocalTimeRange>
    {
        public org.mpxj.LocalTimeRange JavaObject { get; }

        internal TimeOnlyRange(org.mpxj.LocalTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public TimeOnlyRange(TimeOnly start, TimeOnly end)
        {
            JavaObject = new org.mpxj.LocalTimeRange(start.ConvertType(), end.ConvertType());
        }

        public TimeOnly? Start => JavaObject.getStart().ConvertType();

        public TimeOnly? End => JavaObject.getEnd().ConvertType();

        public long DurationAsMilliseconds => JavaObject.getDurationAsMilliseconds();

        public override string ToString() => JavaObject.toString();

        public override bool Equals(object obj) => Equals(obj as TimeOnlyRange);

        public bool Equals(TimeOnlyRange d) => d != null && JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(TimeOnlyRange lhs, TimeOnlyRange rhs) => lhs?.Equals(rhs) ?? rhs is null;

        public static bool operator !=(TimeOnlyRange lhs, TimeOnlyRange rhs) => !(lhs == rhs);
    }
}
