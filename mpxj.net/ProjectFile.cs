using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectFile : IChildTaskContainer, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.ProjectFile>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectFile JavaObject { get; }

        public ProjectFile() : this(new net.sf.mpxj.ProjectFile()) { }

        internal ProjectFile(net.sf.mpxj.ProjectFile file)
        {
            _proxyManager = new ProxyManager(this);
            JavaObject = file;
        }

        public ProjectConfig ProjectConfig
        {
            get => _proxyManager.ProxyObject(JavaObject.getProjectConfig());
        }

        public Task AddTask()
        {
            return _proxyManager.ProxyObject(JavaObject.addTask());
        }

        public void RemoveTask(Task task)
        {
            JavaObject.removeTask(task.JavaObject);
        }

        public void ValidateUniqueIDsForMicrosoftProject()
        {
            JavaObject.validateUniqueIDsForMicrosoftProject();
        }

        public IList<Task> ChildTasks
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildTasks());
        }

        public IList<Resource> ChildResources
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildResources());
        }

        public TaskContainer Tasks
        {
            get => _proxyManager.ProxyObject(JavaObject.getTasks());
        }

        public ProjectCalendar AddCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendar());
        }

        public void RemoveCalendar(ProjectCalendar calendar)
        {
            JavaObject.removeCalendar(calendar.JavaObject);
        }

        public ProjectCalendar AddDefaultBaseCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.addDefaultBaseCalendar());
        }

        public ProjectCalendar AddDefaultDerivedCalendar()
        {
            return _proxyManager.ProxyObject(JavaObject.addDefaultDerivedCalendar());
        }

        public ProjectCalendarContainer Calendars
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendars());
        }

        public ProjectProperties ProjectProperties
        {
            get => _proxyManager.ProxyObject(JavaObject.getProjectProperties());
        }

        public Resource AddResource()
        {
            return _proxyManager.ProxyObject(JavaObject.addResource());
        }

        public void RemoveResource(Resource resource)
        {
            JavaObject.removeResource(resource.JavaObject);
        }

        public ResourceContainer Resources
        {
            get => _proxyManager.ProxyObject(JavaObject.getResources());
        }

        public ResourceAssignmentContainer ResourceAssignments
        {
            get => _proxyManager.ProxyObject(JavaObject.getResourceAssignments());
        }

        public ProjectCalendar GetCalendarByName(string calendarName)
        {
            return _proxyManager.ProxyObject(JavaObject.getCalendarByName(calendarName));
        }

        public ProjectCalendar GetCalendarByUniqueID(java.lang.Integer calendarID)
        {
            return _proxyManager.ProxyObject(JavaObject.getCalendarByUniqueID(calendarID));
        }

        public Task GetTaskByID(java.lang.Integer id)
        {
            return _proxyManager.ProxyObject(JavaObject.getTaskByID(id));
        }

        public Task GetTaskByUniqueID(java.lang.Integer id)
        {
            return _proxyManager.ProxyObject(JavaObject.getTaskByUniqueID(id));
        }

        public Resource GetResourceByID(java.lang.Integer id)
        {
            return _proxyManager.ProxyObject(JavaObject.getResourceByID(id));
        }

        public Resource GetResourceByUniqueID(java.lang.Integer id)
        {
            return _proxyManager.ProxyObject(JavaObject.getResourceByUniqueID(id));
        }

        public void UpdateStructure()
        {
            JavaObject.updateStructure();
        }

        public java.time.LocalDateTime EarliestStartDate
        {
            get => JavaObject.getEarliestStartDate();
        }

        public java.time.LocalDateTime LatestFinishDate
        {
            get => JavaObject.getLatestFinishDate();
        }

        public ViewContainer Views
        {
            get => _proxyManager.ProxyObject(JavaObject.getViews());
        }

        public TableContainer Tables
        {
            get => _proxyManager.ProxyObject(JavaObject.getTables());
        }

        public FilterContainer Filters
        {
            get => _proxyManager.ProxyObject(JavaObject.getFilters());
        }

        public GroupContainer Groups
        {
            get => _proxyManager.ProxyObject(JavaObject.getGroups());
        }

        public EventManager EventManager
        {
            get => _proxyManager.ProxyObject(JavaObject.getEventManager());
        }

        public CustomFieldContainer CustomFields
        {
            get => _proxyManager.ProxyObject(JavaObject.getCustomFields());
        }

        public ActivityCodeContainer ActivityCodes
        {
            get => _proxyManager.ProxyObject(JavaObject.getActivityCodes());
        }

        public DataLinkContainer DataLinks
        {
            get => _proxyManager.ProxyObject(JavaObject.getDataLinks());
        }

        public ExpenseCategoryContainer ExpenseCategories
        {
            get => _proxyManager.ProxyObject(JavaObject.getExpenseCategories());
        }

        public CostAccountContainer CostAccounts
        {
            get => _proxyManager.ProxyObject(JavaObject.getCostAccounts());
        }

        public UserDefinedFieldContainer UserDefinedFields
        {
            get => _proxyManager.ProxyObject(JavaObject.getUserDefinedFields());
        }

        public WorkContourContainer WorkContours
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkContours());
        }

        public NotesTopicContainer NotesTopics
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesTopics());
        }

        public LocationContainer Locations
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocations());
        }

        public ProjectCalendar DefaultCalendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultCalendar());
            set => JavaObject.setDefaultCalendar(value.JavaObject);
        }

        public ProjectCalendar BaselineCalendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineCalendar());
        }

        public IList<ProjectFile> Baselines
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectFile, ProjectFile>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getBaselines());
        }

        public void SetBaseline(ProjectFile baseline)
        {
            JavaObject.setBaseline(baseline.JavaObject);
        }

        public void SetBaseline(ProjectFile baseline, int index)
        {
            JavaObject.setBaseline(baseline.JavaObject, index);
        }

        public void ClearBaseline()
        {
            JavaObject.clearBaseline();
        }

        public void ClearBaseline(int index)
        {
            JavaObject.clearBaseline(index);
        }

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields
        //{
        //    get => ProxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(JavaObject.getPopulatedFields());
        //}

        public void ExpandSubprojects()
        {
            JavaObject.expandSubprojects();
        }
    }
}