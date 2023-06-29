namespace org.mpxj;

public class ProjectFile
{
    internal readonly net.sf.mpxj.ProjectFile _proxy;
    private readonly Dictionary<Object, Object> _objectCache = new();

    public ProjectFile() : this(new net.sf.mpxj.ProjectFile()) { }

    internal N ProxyObject<M, N>(M o, Func<M, N> proxyFunction)
    {
        if (!_objectCache.ContainsKey(o))
        {
            _objectCache[o] = proxyFunction.Invoke(o);
        }

        return (N)_objectCache[o];
    }

    internal Resource ProxyObject(net.sf.mpxj.Resource value)
    {
        return ProxyObject(value, r => new Resource(this, r));
    }

    internal ProjectFile(net.sf.mpxj.ProjectFile file)
    {
        _proxy = file;
    }

    public ProjectConfig ProjectConfig
    {
        get => ProxyObject(_proxy.getProjectConfig(), o => new ProjectConfig(o));
    }

    public net.sf.mpxj.Task AddTask()
    {
        return _proxy.addTask();
    }

    public void RemoveTask(net.sf.mpxj.Task task)
    {
        _proxy.removeTask(task);
    }

    public void ValidateUniqueIDsForMicrosoftProject()
    {
        _proxy.validateUniqueIDsForMicrosoftProject();
    }

    public java.util.List ChildTasks
    {
        get => _proxy.getChildTasks();
    }

    public java.util.List ChildResources
    {
        get => _proxy.getChildResources();
    }

    public net.sf.mpxj.TaskContainer Tasks
    {
        get => _proxy.getTasks();
    }

    public ProjectCalendar AddCalendar()
    {
        return ProxyObject(_proxy.addCalendar(), c => new ProjectCalendar(this, c));
    }

    public void RemoveCalendar(ProjectCalendar calendar)
    {
        _proxy.removeCalendar(calendar._proxy);
    }

    public ProjectCalendar AddDefaultBaseCalendar()
    {
        return ProxyObject(_proxy.addDefaultBaseCalendar(), c => new ProjectCalendar(this, c));
    }

    public ProjectCalendar AddDefaultDerivedCalendar()
    {
        return ProxyObject(_proxy.addDefaultDerivedCalendar(), c => new ProjectCalendar(this, c));
    }

    public net.sf.mpxj.ProjectCalendarContainer Calendars
    {
        get => _proxy.getCalendars();
    }

    public ProjectProperties ProjectProperties
    {
        get => ProxyObject(_proxy.getProjectProperties(), p => new ProjectProperties(this, p));
    }

    public Resource AddResource()
    {
        return ProxyObject(_proxy.addResource());
    }

    public void RemoveResource(Resource resource)
    {
        _proxy.removeResource(resource._proxy);
    }

    public net.sf.mpxj.ResourceContainer Resources
    {
        get => _proxy.getResources();

    }

    public net.sf.mpxj.ResourceAssignmentContainer ResourceAssignments
    {
        get => _proxy.getResourceAssignments();
    }

    public ProjectCalendar GetCalendarByName(string calendarName)
    {
        return ProxyObject(_proxy.getCalendarByName(calendarName), c => new ProjectCalendar(this, c));
    }

    public ProjectCalendar GetCalendarByUniqueID(java.lang.Integer calendarID)
    {
        return ProxyObject(_proxy.getCalendarByUniqueID(calendarID), c => new ProjectCalendar(this, c));
    }

    public net.sf.mpxj.Task GetTaskByID(java.lang.Integer id)
    {
        return _proxy.getTaskByID(id);
    }

    public net.sf.mpxj.Task GetTaskByUniqueID(java.lang.Integer id)
    {
        return _proxy.getTaskByUniqueID(id);
    }

    public Resource GetResourceByID(java.lang.Integer id)
    {
        return ProxyObject(_proxy.getResourceByID(id));
    }

    public Resource GetResourceByUniqueID(java.lang.Integer id)
    {
        return ProxyObject(_proxy.getResourceByUniqueID(id));
    }

    public void UpdateStructure()
    {
        _proxy.updateStructure();
    }

    public java.time.LocalDateTime EarliestStartDate
    {
        get => _proxy.getEarliestStartDate();
    }

    public java.time.LocalDateTime LatestFinishDate
    {
        get => _proxy.getLatestFinishDate();
    }

    public net.sf.mpxj.ViewContainer Views
    {
        get => _proxy.getViews();
    }

    public net.sf.mpxj.TableContainer Tables
    {
        get => _proxy.getTables();
    }

    public net.sf.mpxj.FilterContainer Filters
    {
        get => _proxy.getFilters();
    }

    public net.sf.mpxj.GroupContainer Groups
    {
        get => _proxy.getGroups();
    }

    public net.sf.mpxj.EventManager EventManager
    {
        get => _proxy.getEventManager();
    }

    public net.sf.mpxj.CustomFieldContainer CustomFields
    {
        get => _proxy.getCustomFields();
    }

    public net.sf.mpxj.ActivityCodeContainer ActivityCodes
    {
        get => _proxy.getActivityCodes();
    }

    public net.sf.mpxj.DataLinkContainer DataLinks
    {
        get => _proxy.getDataLinks();
    }

    public net.sf.mpxj.ExpenseCategoryContainer ExpenseCategories
    {
        get => _proxy.getExpenseCategories();
    }

    public net.sf.mpxj.CostAccountContainer CostAccounts
    {
        get => _proxy.getCostAccounts();
    }

    public net.sf.mpxj.UserDefinedFieldContainer UserDefinedFields
    {
        get => _proxy.getUserDefinedFields();
    }

    public net.sf.mpxj.WorkContourContainer WorkContours
    {
        get => _proxy.getWorkContours();
    }

    public net.sf.mpxj.NotesTopicContainer NotesTopics
    {
        get => _proxy.getNotesTopics();
    }

    public net.sf.mpxj.LocationContainer Locations
    {
        get => _proxy.getLocations();
    }

    public ProjectCalendar DefaultCalendar
    {
        get => ProxyObject(_proxy.getDefaultCalendar(), c => new ProjectCalendar(this, c));
        set => _proxy.setDefaultCalendar(value._proxy);
    }

    public ProjectCalendar BaselineCalendar
    {
        get => ProxyObject(_proxy.getBaselineCalendar(), c => new ProjectCalendar(this, c));
    }

    public java.util.List Baselines
    {
        get => _proxy.getBaselines();
    }

    public void SetBaseline(ProjectFile baseline)
    {
        _proxy.setBaseline(baseline._proxy);
    }

    public void SetBaseline(ProjectFile baseline, int index)
    {
        _proxy.setBaseline(baseline._proxy, index);
    }

    public void ClearBaseline()
    {
        _proxy.clearBaseline();
    }

    public void ClearBaseline(int index)
    {
        _proxy.clearBaseline(index);
    }

    public java.util.Set PopulatedFields
    {
        get => _proxy.getPopulatedFields();
    }

    public void ExpandSubprojects()
    {
        _proxy.expandSubprojects();
    }
}
