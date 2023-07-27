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
    }
}

