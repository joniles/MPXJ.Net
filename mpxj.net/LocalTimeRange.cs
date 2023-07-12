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

        public java.time.LocalTime Start
        {
            get => JavaObject.getStart();
        }

        public java.time.LocalTime End
        {
            get => JavaObject.getEnd();
        }

        public long DurationAsMilliseconds
        {
            get => JavaObject.getDurationAsMilliseconds();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

