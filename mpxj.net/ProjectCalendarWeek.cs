namespace org.mpxj;

public class ProjectCalendarWeek : ProjectCalendarDays
{
    internal new readonly net.sf.mpxj.ProjectCalendarWeek _proxy;

    internal ProjectCalendarWeek(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarWeek proxy) : base(projectFile, proxy)
    {
        _proxy = proxy;
    }

    public net.sf.mpxj.DateRange DateRange
    {
        get => _proxy.getDateRange();
        set => _proxy.setDateRange(value);
    }

    public java.util.List ConvertToRecurringExceptions(ProjectCalendar calendar)
    {
        return _proxy.convertToRecurringExceptions(calendar._proxy);
    }

    public override string ToString()
    {
        return _proxy.toString();
    }
}


