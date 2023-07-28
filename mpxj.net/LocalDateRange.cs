using System;
using org.mpxj.proxy;

namespace org.mpxj
{
	public class LocalDateRange : IJavaObjectProxy<net.sf.mpxj.LocalDateRange>
    {
        public net.sf.mpxj.LocalDateRange JavaObject { get; }

        internal LocalDateRange(net.sf.mpxj.LocalDateRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateOnly? Start => JavaObject.getStart().ConvertType();

        public DateOnly? End => JavaObject.getEnd().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

