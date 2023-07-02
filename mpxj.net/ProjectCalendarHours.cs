namespace org.mpxj
{
    public class ProjectCalendarHours : ShallowProxyList<net.sf.mpxj.LocalTimeRange>
    {
        internal ProjectCalendarHours(net.sf.mpxj.ProjectCalendarHours javaObject) : base(javaObject) { }

        public ProjectCalendarHours() : base(new net.sf.mpxj.ProjectCalendarHours()) { }

        public override string ToString()
        {
            return JavaObject.ToString();
        }
    }
}