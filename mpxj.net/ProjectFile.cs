using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectFile : IChildTaskContainer, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.ProjectFile>
    {
        internal ProxyManager ProxyManager { get; }
        public net.sf.mpxj.ProjectFile JavaObject { get; }

        public ProjectFile() : this(new net.sf.mpxj.ProjectFile()) { }

        internal ProjectFile(net.sf.mpxj.ProjectFile file)
        {
            ProxyManager = new ProxyManager(this);
            JavaObject = file;
        }

        public ProjectConfig ProjectConfig
        {
            get => ProxyManager.ProxyObject(JavaObject.getProjectConfig());
        }

        public Task AddTask()
        {
            return ProxyManager.ProxyObject(JavaObject.addTask());
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
            get => ProxyManager.ProxyList<net.sf.mpxj.Task, Task>(ProxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildTasks());
        }

        public IList<Resource> ChildResources
        {
            get => ProxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(ProxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildResources());
        }

        public TaskContainer Tasks
        {
            get => ProxyManager.ProxyObject(JavaObject.getTasks());
        }

        public ProjectCalendar AddCalendar()
        {
            return ProxyManager.ProxyObject(JavaObject.addCalendar());
        }

        public void RemoveCalendar(ProjectCalendar calendar)
        {
            JavaObject.removeCalendar(calendar.JavaObject);
        }

        public ProjectCalendar AddDefaultBaseCalendar()
        {
            return ProxyManager.ProxyObject(JavaObject.addDefaultBaseCalendar());
        }

        public ProjectCalendar AddDefaultDerivedCalendar()
        {
            return ProxyManager.ProxyObject(JavaObject.addDefaultDerivedCalendar());
        }

        public ProjectCalendarContainer Calendars
        {
            get => ProxyManager.ProxyObject(JavaObject.getCalendars());
        }

        public ProjectProperties ProjectProperties
        {
            get => ProxyManager.ProxyObject(JavaObject.getProjectProperties());
        }

        public Resource AddResource()
        {
            return ProxyManager.ProxyObject(JavaObject.addResource());
        }

        public void RemoveResource(Resource resource)
        {
            JavaObject.removeResource(resource.JavaObject);
        }

        public ResourceContainer Resources
        {
            get => ProxyManager.ProxyObject(JavaObject.getResources());
        }

        public ResourceAssignmentContainer ResourceAssignments
        {
            get => ProxyManager.ProxyObject(JavaObject.getResourceAssignments());
        }

        public ProjectCalendar GetCalendarByName(string calendarName)
        {
            return ProxyManager.ProxyObject(JavaObject.getCalendarByName(calendarName));
        }

        public ProjectCalendar GetCalendarByUniqueID(java.lang.Integer calendarID)
        {
            return ProxyManager.ProxyObject(JavaObject.getCalendarByUniqueID(calendarID));
        }

        public Task GetTaskByID(java.lang.Integer id)
        {
            return ProxyManager.ProxyObject(JavaObject.getTaskByID(id));
        }

        public Task GetTaskByUniqueID(java.lang.Integer id)
        {
            return ProxyManager.ProxyObject(JavaObject.getTaskByUniqueID(id));
        }

        public Resource GetResourceByID(java.lang.Integer id)
        {
            return ProxyManager.ProxyObject(JavaObject.getResourceByID(id));
        }

        public Resource GetResourceByUniqueID(java.lang.Integer id)
        {
            return ProxyManager.ProxyObject(JavaObject.getResourceByUniqueID(id));
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
            get => ProxyManager.ProxyObject(JavaObject.getViews());
        }

        public TableContainer Tables
        {
            get => ProxyManager.ProxyObject(JavaObject.getTables());
        }

        public FilterContainer Filters
        {
            get => ProxyManager.ProxyObject(JavaObject.getFilters());
        }

        public GroupContainer Groups
        {
            get => ProxyManager.ProxyObject(JavaObject.getGroups());
        }

        public EventManager EventManager
        {
            get => ProxyManager.ProxyObject(JavaObject.getEventManager());
        }

        public CustomFieldContainer CustomFields
        {
            get => ProxyManager.ProxyObject(JavaObject.getCustomFields());
        }

        public ActivityCodeContainer ActivityCodes
        {
            get => ProxyManager.ProxyObject(JavaObject.getActivityCodes());
        }

        public DataLinkContainer DataLinks
        {
            get => ProxyManager.ProxyObject(JavaObject.getDataLinks());
        }

        public ExpenseCategoryContainer ExpenseCategories
        {
            get => ProxyManager.ProxyObject(JavaObject.getExpenseCategories());
        }

        public CostAccountContainer CostAccounts
        {
            get => ProxyManager.ProxyObject(JavaObject.getCostAccounts());
        }

        public UserDefinedFieldContainer UserDefinedFields
        {
            get => ProxyManager.ProxyObject(JavaObject.getUserDefinedFields());
        }

        public WorkContourContainer WorkContours
        {
            get => ProxyManager.ProxyObject(JavaObject.getWorkContours());
        }

        public NotesTopicContainer NotesTopics
        {
            get => ProxyManager.ProxyObject(JavaObject.getNotesTopics());
        }

        public LocationContainer Locations
        {
            get => ProxyManager.ProxyObject(JavaObject.getLocations());
        }

        public ProjectCalendar DefaultCalendar
        {
            get => ProxyManager.ProxyObject(JavaObject.getDefaultCalendar());
            set => JavaObject.setDefaultCalendar(value.JavaObject);
        }

        public ProjectCalendar BaselineCalendar
        {
            get => ProxyManager.ProxyObject(JavaObject.getBaselineCalendar());
        }

        public IList<ProjectFile> Baselines
        {
            get => ProxyManager.ProxyList<net.sf.mpxj.ProjectFile, ProjectFile>(ProxyManager.ProxyObject, value => value.JavaObject, JavaObject.getBaselines());
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