using System;
using System.Collections.Generic;

namespace org.mpxj
{
    public class ProjectFile: IJavaObjectProxy<net.sf.mpxj.ProjectFile>
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
            return ProxyObject(value, r => new Resource(this, r));
        }

        internal ProjectCalendarWeek ProxyObject(net.sf.mpxj.ProjectCalendarWeek value)
        {
            return ProxyObject(value, w => new ProjectCalendarWeek(this, w));
        }

        internal ProjectCalendarException ProxyObject(net.sf.mpxj.ProjectCalendarException value)
        {
            return ProxyObject(value, e => new ProjectCalendarException(this, e));
        }

        internal ProjectCalendar ProxyObject(net.sf.mpxj.ProjectCalendar value)
        {
            return ProxyObject(value, c => new ProjectCalendar(this, c));
        }

        internal RecurringData ProxyObject(net.sf.mpxj.RecurringData value)
        {
            return ProxyObject(value, r => new RecurringData(r));
        }

        internal ProjectCalendarHours ProxyObject(net.sf.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, h => new ProjectCalendarHours(h));
        }

        internal ProjectFile(net.sf.mpxj.ProjectFile file)
        {
            JavaObject = file;
        }

        public ProjectConfig ProjectConfig
        {
            get => ProxyObject(JavaObject.getProjectConfig(), o => new ProjectConfig(o));
        }

        public net.sf.mpxj.Task AddTask()
        {
            return JavaObject.addTask();
        }

        public void RemoveTask(net.sf.mpxj.Task task)
        {
            JavaObject.removeTask(task);
        }

        public void ValidateUniqueIDsForMicrosoftProject()
        {
            JavaObject.validateUniqueIDsForMicrosoftProject();
        }

        public java.util.List ChildTasks
        {
            get => JavaObject.getChildTasks();
        }

        public java.util.List ChildResources
        {
            get => JavaObject.getChildResources();
        }

        public net.sf.mpxj.TaskContainer Tasks
        {
            get => JavaObject.getTasks();
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

        public net.sf.mpxj.ProjectCalendarContainer Calendars
        {
            get => JavaObject.getCalendars();
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

        public net.sf.mpxj.ResourceContainer Resources
        {
            get => JavaObject.getResources();

        }

        public net.sf.mpxj.ResourceAssignmentContainer ResourceAssignments
        {
            get => JavaObject.getResourceAssignments();
        }

        public ProjectCalendar GetCalendarByName(string calendarName)
        {
            return ProxyObject(JavaObject.getCalendarByName(calendarName), c => new ProjectCalendar(this, c));
        }

        public ProjectCalendar GetCalendarByUniqueID(java.lang.Integer calendarID)
        {
            return ProxyObject(JavaObject.getCalendarByUniqueID(calendarID), c => new ProjectCalendar(this, c));
        }

        public net.sf.mpxj.Task GetTaskByID(java.lang.Integer id)
        {
            return JavaObject.getTaskByID(id);
        }

        public net.sf.mpxj.Task GetTaskByUniqueID(java.lang.Integer id)
        {
            return JavaObject.getTaskByUniqueID(id);
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

        public net.sf.mpxj.ViewContainer Views
        {
            get => JavaObject.getViews();
        }

        public net.sf.mpxj.TableContainer Tables
        {
            get => JavaObject.getTables();
        }

        public net.sf.mpxj.FilterContainer Filters
        {
            get => JavaObject.getFilters();
        }

        public net.sf.mpxj.GroupContainer Groups
        {
            get => JavaObject.getGroups();
        }

        public net.sf.mpxj.EventManager EventManager
        {
            get => JavaObject.getEventManager();
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

        public java.util.List Baselines
        {
            get => JavaObject.getBaselines();
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