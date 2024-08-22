using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectFile : IChildTaskContainer, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.ProjectFile>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectFile JavaObject { get; }

        public ProjectFile() : this(new net.sf.mpxj.ProjectFile()) { }

        internal ProjectFile(net.sf.mpxj.ProjectFile file) : this(new ProxyManager(), file) { }

        internal ProjectFile(ProxyManager proxyManager, net.sf.mpxj.ProjectFile file)
        {
            _proxyManager = proxyManager;
            JavaObject = file;            
            _proxyManager.PopulateCache(file, this);
        }

        public ProjectConfig ProjectConfig => _proxyManager.ProxyObject(JavaObject.getProjectConfig());

        public Task AddTask() => _proxyManager.ProxyObject(JavaObject.addTask());

        public void RemoveTask(Task task) => JavaObject.removeTask(task.JavaObject);

        public IList<Task> ChildTasks => _proxyManager.ProxyList<net.sf.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildTasks());

        public IList<Resource> ChildResources => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildResources());

        public TaskContainer Tasks => _proxyManager.ProxyObject(JavaObject.getTasks());

        public ProjectCalendar AddCalendar() => _proxyManager.ProxyObject(JavaObject.addCalendar());

        public void RemoveCalendar(ProjectCalendar calendar) => JavaObject.removeCalendar(calendar.JavaObject);

        public ProjectCalendar AddDefaultBaseCalendar() => _proxyManager.ProxyObject(JavaObject.addDefaultBaseCalendar());

        public ProjectCalendar AddDefaultDerivedCalendar() => _proxyManager.ProxyObject(JavaObject.addDefaultDerivedCalendar());

        public ProjectCalendarContainer Calendars => _proxyManager.ProxyObject(JavaObject.getCalendars());

        public ProjectProperties ProjectProperties => _proxyManager.ProxyObject(JavaObject.getProjectProperties());

        public Resource AddResource() => _proxyManager.ProxyObject(JavaObject.addResource());

        public void RemoveResource(Resource resource) => JavaObject.removeResource(resource.JavaObject);

        public ResourceContainer Resources => _proxyManager.ProxyObject(JavaObject.getResources());

        public ResourceAssignmentContainer ResourceAssignments => _proxyManager.ProxyObject(JavaObject.getResourceAssignments());

        public ProjectCalendar GetCalendarByName(string calendarName) => _proxyManager.ProxyObject(JavaObject.getCalendarByName(calendarName));

        public ProjectCalendar GetCalendarByUniqueID(int calendarID) => _proxyManager.ProxyObject(JavaObject.getCalendarByUniqueID(calendarID.ConvertType()));

        public Task GetTaskByID(int id) => _proxyManager.ProxyObject(JavaObject.getTaskByID(id.ConvertType()));

        public Task GetTaskByUniqueID(int id) => _proxyManager.ProxyObject(JavaObject.getTaskByUniqueID(id.ConvertType()));

        public Resource GetResourceByID(int id) => _proxyManager.ProxyObject(JavaObject.getResourceByID(id.ConvertType()));

        public Resource GetResourceByUniqueID(int id) => _proxyManager.ProxyObject(JavaObject.getResourceByUniqueID(id.ConvertType()));

        public void UpdateStructure() => JavaObject.updateStructure();

        public DateTime? EarliestStartDate => JavaObject.getEarliestStartDate().ConvertType();

        public DateTime? LatestFinishDate => JavaObject.getLatestFinishDate().ConvertType();

        public ViewContainer Views => _proxyManager.ProxyObject(JavaObject.getViews());

        public TableContainer Tables => _proxyManager.ProxyObject(JavaObject.getTables());

        public FilterContainer Filters => _proxyManager.ProxyObject(JavaObject.getFilters());

        public GroupContainer Groups => _proxyManager.ProxyObject(JavaObject.getGroups());

        public CustomFieldContainer CustomFields => _proxyManager.ProxyObject(JavaObject.getCustomFields());

        public ActivityCodeContainer ActivityCodes => _proxyManager.ProxyObject(JavaObject.getActivityCodes());

        public DataLinkContainer DataLinks => _proxyManager.ProxyObject(JavaObject.getDataLinks());

        public ExpenseCategoryContainer ExpenseCategories => _proxyManager.ProxyObject(JavaObject.getExpenseCategories());

        public CostAccountContainer CostAccounts => _proxyManager.ProxyObject(JavaObject.getCostAccounts());

        public UserDefinedFieldContainer UserDefinedFields => _proxyManager.ProxyObject(JavaObject.getUserDefinedFields());

        public WorkContourContainer WorkContours => _proxyManager.ProxyObject(JavaObject.getWorkContours());

        public NotesTopicContainer NotesTopics => _proxyManager.ProxyObject(JavaObject.getNotesTopics());

        public LocationContainer Locations => _proxyManager.ProxyObject(JavaObject.getLocations());

        public ProjectCalendar DefaultCalendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultCalendar());
            set => JavaObject.setDefaultCalendar(value?.JavaObject);
        }

        public ProjectCalendar BaselineCalendar => _proxyManager.ProxyObject(JavaObject.getBaselineCalendar());

        public IList<ProjectFile> Baselines => _proxyManager.ProxyList<net.sf.mpxj.ProjectFile, ProjectFile>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getBaselines());

        public void SetBaseline(ProjectFile baseline) => JavaObject.setBaseline(baseline.JavaObject);

        public void SetBaseline(ProjectFile baseline, int index) => JavaObject.setBaseline(baseline.JavaObject, index);

        public void ClearBaseline() => JavaObject.clearBaseline();

        public void ClearBaseline(int index) => JavaObject.clearBaseline(index);

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (net.sf.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public void ExpandSubprojects(bool replaceExternalTasks) => JavaObject.expandSubprojects(replaceExternalTasks);

        public RelationContainer Relations => _proxyManager.ProxyObject(JavaObject.getRelations());

        public UnitOfMeasureContainer UnitsOfMeasure => _proxyManager.ProxyObject(JavaObject.getUnitsOfMeasure());
    }
}