namespace org.mpxj;

public class ProjectConfig
{
    internal readonly net.sf.mpxj.ProjectConfig _proxy;

    internal ProjectConfig(net.sf.mpxj.ProjectConfig proxy)
    {
        _proxy = proxy;
    }

    public bool AutoWBS
    {
        get => _proxy.getAutoWBS();
        set => _proxy.setAutoWBS(value);
    }

    public bool AutoOutlineLevel
    {
        get => _proxy.getAutoOutlineLevel();
        set => _proxy.setAutoOutlineLevel(value);
    }

    public bool AutoOutlineNumber
    {
        get => _proxy.getAutoOutlineNumber();
        set => _proxy.setAutoOutlineNumber(value);
    }

    public bool AutoTaskUniqueID
    {
        get => _proxy.getAutoTaskID();
        set => _proxy.setAutoTaskID(value);
    }

    public bool AutoCalendarUniqueID
    {
        get => _proxy.getAutoCalendarUniqueID();
        set => _proxy.setAutoCalendarUniqueID(value);
    }

    public bool AutoAssignmentUniqueID
    {
        get => _proxy.getAutoAssignmentUniqueID();
        set => _proxy.setAutoAssignmentUniqueID(value);
    }

    public bool AutoTaskID
    {
        get => _proxy.getAutoTaskID();
        set => _proxy.setAutoTaskID(value);
    }

    public bool AutoResourceUniqueID
    {
        get => _proxy.getAutoResourceUniqueID();
        set => _proxy.setAutoResourceUniqueID(value);
    }

    public bool AutoResourceID
    {
        get => _proxy.getAutoResourceID();
        set => _proxy.setAutoResourceID(value);
    }

    public bool AutoRelationUniqueID
    {
        get => _proxy.getAutoRelationUniqueID();
        set => _proxy.setAutoRelationUniqueID(value);
    }

    public bool CompleteThroughIsNextWorkStart
    {
        get => _proxy.getCompleteThroughIsNextWorkStart();
        set => _proxy.setCompleteThroughIsNextWorkStart(value);
    }

    public void UpdateUniqueCounters()
    {
        _proxy.updateUniqueCounters();
    }

    public void UpdateTaskUniqueCounter()
    {
        _proxy.updateTaskUniqueCounter();
    }

    public void UpdateResourceUniqueCounter()
    {
        _proxy.updateResourceUniqueCounter();
    }

    public void UpdateCalendarUniqueCounter()
    {
        _proxy.updateCalendarUniqueCounter();
    }

    public void UpdateAssignmentUniqueCounter()
    {
        _proxy.updateAssignmentUniqueCounter();
    }

    public net.sf.mpxj.BaselineStrategy BaselineStrategy
    {
        get => _proxy.getBaselineStrategy();
        set => _proxy.setBaselineStrategy(value);
    }

    public string? SubprojectWorkingDirectory
    {
        get => _proxy.getSubprojectWorkingDirectory()?.getCanonicalPath();
        set => _proxy.setSubprojectWorkingDirectory(value == null ? null : new java.io.File(value));
    }
}
