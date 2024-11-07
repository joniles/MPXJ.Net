﻿using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimeOnlyRange : IJavaObjectProxy<net.sf.mpxj.LocalTimeRange>
    {
        public net.sf.mpxj.LocalTimeRange JavaObject { get; }

        internal TimeOnlyRange(net.sf.mpxj.LocalTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public TimeOnlyRange(TimeOnly start, TimeOnly end)
        {
            JavaObject = new net.sf.mpxj.LocalTimeRange(start.ConvertType(), end.ConvertType());
        }

        public TimeOnly? Start => JavaObject.getStart().ConvertType();

        public TimeOnly? End => JavaObject.getEnd().ConvertType();

        public long DurationAsMilliseconds => JavaObject.getDurationAsMilliseconds();

        public override string ToString() => JavaObject.toString();

        public override bool Equals(object obj) => Equals(obj as TimeOnlyRange);

        public bool Equals(TimeOnlyRange d) => d != null && JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(TimeOnlyRange lhs, TimeOnlyRange rhs) => lhs is null ? rhs is null : lhs.Equals(rhs);

        public static bool operator !=(TimeOnlyRange lhs, TimeOnlyRange rhs) => !(lhs == rhs);
    }
}
