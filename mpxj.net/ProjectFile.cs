using System;
using System.Collections.Generic;

namespace org.mpxj
{
    public class ProjectFile : IChildTaskContainer, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.ProjectFile>
    {
        public net.sf.mpxj.ProjectFile JavaObject { get; }

        private readonly Dictionary<object, object> _objectCache = new Dictionary<object, object>();

        public ProjectFile() : this(new net.sf.mpxj.ProjectFile()) { }

        private N ProxyObject<M, N>(M o, Func<M, N> proxyFunction)
        {
            if (!_objectCache.ContainsKey(o))
            {
                _objectCache[o] = proxyFunction.Invoke(o);
            }

            return (N)_objectCache[o];
        }

        internal Resource ProxyObject(net.sf.mpxj.Resource value)
        {
            return ProxyObject(value, v => new Resource(this, v));
        }

        internal ProjectCalendarWeek ProxyObject(net.sf.mpxj.ProjectCalendarWeek value)
        {
            return ProxyObject(value, v => new ProjectCalendarWeek(this, v));
        }

        internal ProjectCalendarException ProxyObject(net.sf.mpxj.ProjectCalendarException value)
        {
            return ProxyObject(value, v => new ProjectCalendarException(this, v));
        }

        internal ProjectCalendar ProxyObject(net.sf.mpxj.ProjectCalendar value)
        {
            return ProxyObject(value, v => new ProjectCalendar(this, v));
        }

        internal RecurringData ProxyObject(net.sf.mpxj.RecurringData value)
        {
            return ProxyObject(value, v => new RecurringData(v));
        }

        internal ProjectCalendarHours ProxyObject(net.sf.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, v => new ProjectCalendarHours(v));
        }

        internal ResourceContainer ProxyObject(net.sf.mpxj.ResourceContainer value)
        {
            return ProxyObject(value, v => new ResourceContainer(this, v));
        }

        internal TaskContainer ProxyObject(net.sf.mpxj.TaskContainer value)
        {
            return ProxyObject(value, v => new TaskContainer(this, v));
        }

        internal ResourceAssignmentContainer ProxyObject(net.sf.mpxj.ResourceAssignmentContainer value)
        {
            return ProxyObject(value, v => new ResourceAssignmentContainer(this, v));
        }

        internal ViewContainer ProxyObject(net.sf.mpxj.ViewContainer value)
        {
            return ProxyObject(value, v => new ViewContainer(v));
        }

        internal Task ProxyObject(net.sf.mpxj.Task value)
        {
            return ProxyObject(value, v => new Task(this, v));
        }

        internal ProjectFile ProxyObject(net.sf.mpxj.ProjectFile value)
        {
            return ProxyObject(value, v => new ProjectFile(v));
        }

        internal ResourceAssignment ProxyObject(net.sf.mpxj.ResourceAssignment value)
        {
            return ProxyObject(value, v => new ResourceAssignment(this, v));
        }

        internal ProjectCalendarContainer ProxyObject(net.sf.mpxj.ProjectCalendarContainer value)
        {
            return ProxyObject(value, v => new ProjectCalendarContainer(this, v));
        }

        internal TableContainer ProxyObject(net.sf.mpxj.TableContainer value)
        {
            return ProxyObject(value, v => new TableContainer(v));
        }

        internal FilterContainer ProxyObject(net.sf.mpxj.FilterContainer value)
        {
            return ProxyObject(value, v => new FilterContainer(v));
        }

        internal EventManager ProxyObject(net.sf.mpxj.EventManager value)
        {
            return ProxyObject(value, v => new EventManager(v));
        }

        internal GroupContainer ProxyObject(net.sf.mpxj.GroupContainer value)
        {
            return ProxyObject(value, v => new GroupContainer(v));
        }

        internal object GenericProxyObject(object o)
        {
            if (o == null)
            {
                return null;
            }

            switch (o.GetType().AssemblyQualifiedName)
            {
                case "net.sf.mpxj.Resource":
                    return ProxyObject((net.sf.mpxj.Resource)o);

                case "net.sf.mpxj.Task":
                    return ProxyObject((net.sf.mpxj.Task)o);

                case "net.sf.mpxj.ResourceAssignment":
                    return ProxyObject((net.sf.mpxj.ResourceAssignment)o);

                case "net.sf.mpxj.ProjectCalendarWeek":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarWeek)o);

                case "net.sf.mpxj.ProjectCalendarException":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarException)o);

                case "net.sf.mpxj.ProjectCalendar":
                    return ProxyObject((net.sf.mpxj.ProjectCalendar)o);

                case "net.sf.mpxj.RecurringData":
                    return ProxyObject((net.sf.mpxj.RecurringData)o);

                case "net.sf.mpxj.ProjectCalendarHours":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarHours)o);

            }

            return o;
        }

        internal IList<ProjectFile> ProxyProjectFileList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.ProjectFile, ProjectFile>(this, l));
        }

        internal IList<Resource> ProxyResourceList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.Resource, Resource>(this, l));
        }

        internal IList<Task> ProxyTaskList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.Task, Task>(this, l));
        }

        internal IList<ResourceAssignment> ProxyResourceAssignmentList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.ResourceAssignment, ResourceAssignment>(this, l));
        }

        internal ProjectFile(net.sf.mpxj.ProjectFile file)
        {
            JavaObject = file;
        }

        public ProjectConfig ProjectConfig
        {
            get => ProxyObject(JavaObject.getProjectConfig(), o => new ProjectConfig(o));
        }

        public Task AddTask()
        {
            return ProxyObject(JavaObject.addTask());
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
            get => ProxyTaskList(JavaObject.getChildTasks());
        }

        public IList<Resource> ChildResources
        {
            get => ProxyResourceList(JavaObject.getChildResources());
        }

        public TaskContainer Tasks
        {
            get => ProxyObject(JavaObject.getTasks());
        }

        public ProjectCalendar AddCalendar()
        {
            return ProxyObject(JavaObject.addCalendar(), c => new ProjectCalendar(this, c));
        }

        public void RemoveCalendar(ProjectCalendar calendar)
        {
            JavaObject.removeCalendar(calendar.JavaObject);
        }

        public ProjectCalendar AddDefaultBaseCalendar()
        {
            return ProxyObject(JavaObject.addDefaultBaseCalendar(), c => new ProjectCalendar(this, c));
        }

        public ProjectCalendar AddDefaultDerivedCalendar()
        {
            return ProxyObject(JavaObject.addDefaultDerivedCalendar(), c => new ProjectCalendar(this, c));
        }

        public ProjectCalendarContainer Calendars
        {
            get => ProxyObject(JavaObject.getCalendars());
        }

        public ProjectProperties ProjectProperties
        {
            get => ProxyObject(JavaObject.getProjectProperties(), p => new ProjectProperties(this, p));
        }

        public Resource AddResource()
        {
            return ProxyObject(JavaObject.addResource());
        }

        public void RemoveResource(Resource resource)
        {
            JavaObject.removeResource(resource.JavaObject);
        }

        public ResourceContainer Resources
        {
            get => ProxyObject(JavaObject.getResources());
        }

        public ResourceAssignmentContainer ResourceAssignments
        {
            get => ProxyObject(JavaObject.getResourceAssignments());
        }

        public ProjectCalendar GetCalendarByName(string calendarName)
        {
            return ProxyObject(JavaObject.getCalendarByName(calendarName), c => new ProjectCalendar(this, c));
        }

        public ProjectCalendar GetCalendarByUniqueID(java.lang.Integer calendarID)
        {
            return ProxyObject(JavaObject.getCalendarByUniqueID(calendarID), c => new ProjectCalendar(this, c));
        }

        public Task GetTaskByID(java.lang.Integer id)
        {
            return ProxyObject(JavaObject.getTaskByID(id));
        }

        public Task GetTaskByUniqueID(java.lang.Integer id)
        {
            return ProxyObject(JavaObject.getTaskByUniqueID(id));
        }

        public Resource GetResourceByID(java.lang.Integer id)
        {
            return ProxyObject(JavaObject.getResourceByID(id));
        }

        public Resource GetResourceByUniqueID(java.lang.Integer id)
        {
            return ProxyObject(JavaObject.getResourceByUniqueID(id));
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
            get => ProxyObject(JavaObject.getViews());
        }

        public TableContainer Tables
        {
            get => ProxyObject(JavaObject.getTables());
        }

        public FilterContainer Filters
        {
            get => ProxyObject(JavaObject.getFilters());
        }

        public GroupContainer Groups
        {
            get => ProxyObject(JavaObject.getGroups());
        }

        public EventManager EventManager
        {
            get => ProxyObject(JavaObject.getEventManager());
        }

        public net.sf.mpxj.CustomFieldContainer CustomFields
        {
            get => JavaObject.getCustomFields();
        }

        public net.sf.mpxj.ActivityCodeContainer ActivityCodes
        {
            get => JavaObject.getActivityCodes();
        }

        public net.sf.mpxj.DataLinkContainer DataLinks
        {
            get => JavaObject.getDataLinks();
        }

        public net.sf.mpxj.ExpenseCategoryContainer ExpenseCategories
        {
            get => JavaObject.getExpenseCategories();
        }

        public net.sf.mpxj.CostAccountContainer CostAccounts
        {
            get => JavaObject.getCostAccounts();
        }

        public net.sf.mpxj.UserDefinedFieldContainer UserDefinedFields
        {
            get => JavaObject.getUserDefinedFields();
        }

        public net.sf.mpxj.WorkContourContainer WorkContours
        {
            get => JavaObject.getWorkContours();
        }

        public net.sf.mpxj.NotesTopicContainer NotesTopics
        {
            get => JavaObject.getNotesTopics();
        }

        public net.sf.mpxj.LocationContainer Locations
        {
            get => JavaObject.getLocations();
        }

        public ProjectCalendar DefaultCalendar
        {
            get => ProxyObject(JavaObject.getDefaultCalendar(), c => new ProjectCalendar(this, c));
            set => JavaObject.setDefaultCalendar(value.JavaObject);
        }

        public ProjectCalendar BaselineCalendar
        {
            get => ProxyObject(JavaObject.getBaselineCalendar(), c => new ProjectCalendar(this, c));
        }

        public IList<ProjectFile> Baselines
        {
            get => ProxyProjectFileList(JavaObject.getBaselines());
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

        public java.util.Set PopulatedFields
        {
            get => JavaObject.getPopulatedFields();
        }

        public void ExpandSubprojects()
        {
            JavaObject.expandSubprojects();
        }
    }
}