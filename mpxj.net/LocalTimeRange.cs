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

        public LocalTimeRange(java.time.LocalTime start, java.time.LocalTime end)
        {
            JavaObject = new net.sf.mpxj.LocalTimeRange(start, end);
        }

        public java.time.LocalTime Start => JavaObject.getStart();

        public java.time.LocalTime End => JavaObject.getEnd();

        public long DurationAsMilliseconds => JavaObject.getDurationAsMilliseconds();

        public override string ToString() => JavaObject.toString();
    }
}

