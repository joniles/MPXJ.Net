using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class DateTimeRange : IJavaObjectProxy<net.sf.mpxj.LocalDateTimeRange>
    {
        public net.sf.mpxj.LocalDateTimeRange JavaObject { get; }

        internal DateTimeRange(net.sf.mpxj.LocalDateTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateTime? Start => JavaObject.getStart().ConvertType();

        public DateTime? End => JavaObject.getEnd().ConvertType();
    }
}

