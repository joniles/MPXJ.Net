namespace org.mpxj;

public class ProjectCalendarHours : ProxyList<net.sf.mpxj.LocalTimeRange>
{
    internal ProjectCalendarHours(net.sf.mpxj.ProjectCalendarHours proxy) : base(proxy) { }

    public ProjectCalendarHours() : base(new net.sf.mpxj.ProjectCalendarHours()) { }

    public override string ToString()
    {
        return _proxy.ToString();
    }
}
