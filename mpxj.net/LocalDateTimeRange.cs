using org.mpxj.proxy;

namespace org.mpxj
{
    public class LocalDateTimeRange : IJavaObjectProxy<net.sf.mpxj.LocalDateTimeRange>
    {
        public net.sf.mpxj.LocalDateTimeRange JavaObject { get; }

        internal LocalDateTimeRange(net.sf.mpxj.LocalDateTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public java.time.LocalDateTime Start
        {
            get => JavaObject.getStart();
        }

        public java.time.LocalDateTime End
        {
            get => JavaObject.getEnd();
        }
    }
}

