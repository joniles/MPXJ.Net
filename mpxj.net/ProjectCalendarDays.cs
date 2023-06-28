namespace org.mpxj;

public class ProjectCalendarDays
{
    internal readonly ProjectFile _projectFile;
    internal readonly net.sf.mpxj.ProjectCalendarDays _proxy;

    internal ProjectCalendarDays(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarDays proxy)
    {
        _projectFile = projectFile;
        _proxy = proxy;
    }

    public readonly net.sf.mpxj.DateRange DefaultWorkingMorning = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_MORNING;

    public readonly net.sf.mpxj.DateRange DefaultWorkingAfternoon = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_AFTERNOON;

    public string Name
    {
        get => _proxy.getName();
        set => _proxy.setName(value);
    }

    public ProjectCalendarHours GetCalendarHours(net.sf.mpxj.Day day)
    {
        return _projectFile.ProxyObject(_proxy.getCalendarHours(day), h => new ProjectCalendarHours(h));
    }

    public void AddDefaultCalendarHours()
    {
        _proxy.addDefaultCalendarHours();
    }

    public void AddDefaultCalendarDays()
    {
        _proxy.addDefaultCalendarDays();
    }

    public void AddDefaultCalendarHours(net.sf.mpxj.Day day)
    {
        _proxy.addDefaultCalendarHours(day);
    }

    public ProjectCalendarHours AddCalendarHours(net.sf.mpxj.Day day)
    {
        return _projectFile.ProxyObject(_proxy.addCalendarHours(day), h => new ProjectCalendarHours(h));
    }

    public void RemoveCalendarHours(net.sf.mpxj.Day day)
    {
        _proxy.removeCalendarHours(day);
    }

    public net.sf.mpxj.DayType GetCalendarDayType(net.sf.mpxj.Day day)
    {
        return _proxy.getCalendarDayType(day);
    }

    public void SetWorkingDay(net.sf.mpxj.Day day, bool working)
    {
        _proxy.setWorkingDay(day, working);
    }

    public void SetCalendarDayType(net.sf.mpxj.Day day, net.sf.mpxj.DayType type)
    {
        _proxy.setCalendarDayType(day, type);
    }
}
