using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class DateTimeRange : IJavaObjectProxy<org.mpxj.LocalDateTimeRange>
    {
        public org.mpxj.LocalDateTimeRange JavaObject { get; }

        internal DateTimeRange(org.mpxj.LocalDateTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateTimeRange(DateTime? start, DateTime? end)
        {
            JavaObject = new org.mpxj.LocalDateTimeRange(start.ConvertType(), end.ConvertType());
        }

        public DateTime? Start => JavaObject.getStart().ConvertType();

        public DateTime? End => JavaObject.getEnd().ConvertType();
    }
}

