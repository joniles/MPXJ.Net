namespace org.mpxj;

public class ProjectCalendarException : ProjectCalendarHours
{
    internal readonly ProjectFile _projectFile;
    internal new readonly net.sf.mpxj.ProjectCalendarException _proxy;

    internal ProjectCalendarException(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarException proxy) : base(proxy)
    {
        _projectFile = projectFile;
        _proxy = proxy;
    }

    public string Name
    {
        get => _proxy.getName();
        set => _proxy.setName(value);
    }


    public java.util.Date FromDate
    {
        get => _proxy.getFromDate();
    }

    public java.util.Date ToDate
    {
        get => _proxy.getToDate();
    }

    public RecurringData Recurring
    {
        get => _projectFile.ProxyObject(_proxy.getRecurring(), r => new RecurringData(r));
    }

    public bool Working
    {
        get => _proxy.getWorking();
    }

    public java.util.List ExpandedExceptions
    {
        get => _proxy.getExpandedExceptions();
    }

    public bool Contains(java.util.Date date)
    {
        return _proxy.contains(date);
    }

    public bool Contains(ProjectCalendarException exception)
    {
        return _proxy.contains(exception._proxy);
    }

    public override string ToString()
    {
        return _proxy.toString();
    }
}

