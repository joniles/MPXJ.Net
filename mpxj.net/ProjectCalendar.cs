namespace org.mpxj;

public class ProjectCalendar : ProjectCalendarDays
{
    internal new readonly net.sf.mpxj.ProjectCalendar _proxy;

    internal ProjectCalendar(ProjectFile projectFile, net.sf.mpxj.ProjectCalendar proxy) : base(projectFile, proxy)
    {
        _proxy = proxy;
    }

    public java.lang.Integer MinutesPerDay
    {
        get => _proxy.getMinutesPerDay();
    }

    public java.lang.Integer MinutesPerWeek
    {
        get => _proxy.getMinutesPerWeek();
    }

    public java.lang.Integer MinutesPerMonth
    {
        get => _proxy.getMinutesPerMonth();
    }

    public java.lang.Integer MinutesPerYear
    {
        get => _proxy.getMinutesPerYear();
    }

    public java.lang.Integer DaysPerMonth
    {
        get => _proxy.getDaysPerMonth();
    }

    public java.lang.Integer CalendarMinutesPerDay
    {
        get => _proxy.getCalendarMinutesPerDay();
        set => _proxy.setCalendarMinutesPerDay(value);
    }

    public java.lang.Integer CalendarMinutesPerWeek
    {
        get => _proxy.getCalendarMinutesPerWeek();
        set => _proxy.setCalendarMinutesPerWeek(value);
    }

    public java.lang.Integer CalendarMinutesPerMonth
    {
        get => _proxy.getCalendarMinutesPerMonth();
        set => _proxy.setCalendarMinutesPerMonth(value);
    }

    public java.lang.Integer CalendarMinutesPerYear
    {
        get => _proxy.getCalendarMinutesPerYear();
        set => _proxy.setCalendarMinutesPerYear(value);
    }

    public ProjectCalendarWeek AddWorkWeek()
    {
        return _projectFile.ProxyObject(_proxy.addWorkWeek(), w => new ProjectCalendarWeek(_projectFile, w));
    }

    public void RemoveWorkWeek(ProjectCalendarWeek week)
    {
        _proxy.removeWorkWeek(week._proxy);
    }

    public void ClearWorkWeeks()
    {
        _proxy.clearWorkWeeks();
    }

    public java.util.List WorkWeeks
    {
        get => _proxy.getWorkWeeks();
    }

    public ProjectCalendarException AddCalendarException(java.util.Date date)
    {
        return _projectFile.ProxyObject(_proxy.addCalendarException(date), e => new ProjectCalendarException(_projectFile, e));
    }

    public ProjectCalendarException AddCalendarException(java.util.Date fromDate, java.util.Date toDate)
    {
        return _projectFile.ProxyObject(_proxy.addCalendarException(fromDate, toDate), e => new ProjectCalendarException(_projectFile, e));
    }

    public ProjectCalendarException AddCalendarException(RecurringData recurringData)
    {
        return _projectFile.ProxyObject(_proxy.addCalendarException(recurringData._proxy), e => new ProjectCalendarException(_projectFile, e));
    }

    public void RemoveCalendarException(ProjectCalendarException exception)
    {
        _proxy.removeCalendarException(exception._proxy);
    }

    public void ClearCalendarExceptions()
    {
        _proxy.clearCalendarExceptions();
    }

    public java.util.List CalendarExceptions
    {
        get => _proxy.getCalendarExceptions();
    }

    public java.util.List ExpandedCalendarExceptions
    {
        get => _proxy.getExpandedCalendarExceptions();
    }

    public ProjectCalendar Parent
    {
        get => _projectFile.ProxyObject(_proxy.getParent(), c => new ProjectCalendar(_projectFile, c));
        set => _proxy.setParent(value._proxy);
    }

    public java.lang.Integer ParentUniqueID
    {
        get => _proxy.getParentUniqueID();
    }

    public net.sf.mpxj.Duration GetDuration(java.util.Date startDate, java.util.Date endDate)
    {
        return _proxy.getDuration(startDate, endDate);
    }

    public java.util.Date GetStartTime(java.util.Date date)
    {
        return _proxy.getStartTime(date);
    }

    public java.util.Date GetFinishTime(java.util.Date date)
    {
        return _proxy.getFinishTime(date);
    }

    public java.util.Date GetDate(java.util.Date startDate, net.sf.mpxj.Duration duration, bool returnNextWorkStart)
    {
        return _proxy.getDate(startDate, duration, returnNextWorkStart);
    }

    public java.util.Date GetStartDate(java.util.Date finishDate, net.sf.mpxj.Duration duration)
    {
        return _proxy.getStartDate(finishDate, duration);
    }

    public java.util.Date GetNextWorkStart(java.util.Date date)
    {
        return _proxy.getNextWorkStart(date);
    }

    java.util.Date GetPreviousWorkFinish(java.util.Date date)
    {
        return _proxy.getPreviousWorkFinish(date);
    }

    public net.sf.mpxj.DayType GetDayType(net.sf.mpxj.Day day)
    {
        return _proxy.getDayType(day);
    }

    public bool IsWorkingDay(net.sf.mpxj.Day day)
    {
        return _proxy.isWorkingDay(day);
    }

    public bool IsWorkingDate(java.util.Date date)
    {
        return _proxy.isWorkingDate(date);
    }

    public ProjectCalendarHours GetHours(net.sf.mpxj.Day day)
    {
        return _projectFile.ProxyObject(_proxy.getHours(day), h => new ProjectCalendarHours(h));
    }

    public ProjectCalendarHours GetHours(java.util.Date date)
    {
        return _projectFile.ProxyObject(_proxy.getHours(date), h => new ProjectCalendarHours(h));
    }

    public java.lang.Integer UniqueID
    {
        get => _proxy.getUniqueID();
        set => _proxy.setUniqueID(value);
    }

    public java.util.List Tasks
    {
        get => _proxy.getTasks();
    }

    public java.util.List Resources
    {
        get => _proxy.getResources();
    }

    public int ResourceCount
    {
        get => _proxy.getResourceCount();
    }

    public void Remove()
    {
        _proxy.remove();
    }

    public ProjectCalendarException GetException(java.util.Date date)
    {
        return _projectFile.ProxyObject(_proxy.getException(date), e => new ProjectCalendarException(_projectFile, e));
    }

    public ProjectCalendarWeek GetWorkWeek(java.util.Date date)
    {
        return _projectFile.ProxyObject(_proxy.getWorkWeek(date), w => new ProjectCalendarWeek(_projectFile, w));
    }

    public net.sf.mpxj.Duration GetWork(net.sf.mpxj.Day day, net.sf.mpxj.TimeUnit format)
    {
        return _proxy.getWork(day, format);
    }

    public net.sf.mpxj.Duration GetWork(java.util.Date date, net.sf.mpxj.TimeUnit format)
    {
        return _proxy.getWork(date, format);
    }

    public net.sf.mpxj.Duration GetWork(java.util.Date startDate, java.util.Date endDate, net.sf.mpxj.TimeUnit format)
    {
        return _proxy.getWork(startDate, endDate, format);
    }

    public java.util.List DerivedCalendars
    {
        get => _proxy.getDerivedCalendars();
    }

    public override String ToString()
    {
        return _proxy.toString();
    }

    public ProjectFile ParentFile
    {
        get => _projectFile;
    }

    public bool Derived
    {
        get => _proxy.isDerived();
    }

    public net.sf.mpxj.CalendarType Type
    {
        get => _proxy.getType();
        set => _proxy.setType(value);
    }

    public bool Personal
    {
        get => _proxy.getPersonal();
        set => _proxy.setPersonal(value);
    }
}


