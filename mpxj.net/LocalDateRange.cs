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

        public java.time.LocalDate Start => JavaObject.getStart();

        public java.time.LocalDate End => JavaObject.getEnd();

        public override string ToString() => JavaObject.toString();
    }
}

