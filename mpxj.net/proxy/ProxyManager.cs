using System;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
    internal class ProxyManager
    {
        private readonly Dictionary<object, object> _objectCache = new Dictionary<object, object>();
        internal ProjectFile ProjectFile { get; }

        public ProxyManager(ProjectFile projectFile)
        {
            ProjectFile = projectFile;
        }

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

        internal RecurringTask ProxyObject(net.sf.mpxj.RecurringTask value)
        {
            return ProxyObject(value, v => new RecurringTask(v));
        }

        internal ProjectCalendarHours ProxyObject(net.sf.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, v => new ProjectCalendarHours(v));
        }

        internal ProjectConfig ProxyObject(net.sf.mpxj.ProjectConfig value)
        {
            return ProxyObject(value, v => new ProjectConfig(v));
        }

        internal ProjectProperties ProxyObject(net.sf.mpxj.ProjectProperties value)
        {
            return ProxyObject(value, v => new ProjectProperties(this, v));
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
            return ProxyObject(value, v => new ViewContainer(this, v));
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

        internal ActivityCode ProxyObject(net.sf.mpxj.ActivityCode value)
        {
            return ProxyObject(value, v => new ActivityCode(this, v));
        }

        internal ActivityCodeValue ProxyObject(net.sf.mpxj.ActivityCodeValue value)
        {
            return ProxyObject(value, v => new ActivityCodeValue(this, v));
        }

        internal Relation ProxyObject(net.sf.mpxj.Relation value)
        {
            return ProxyObject(value, v => new Relation(this, v));
        }

        internal ExpenseItem ProxyObject(net.sf.mpxj.ExpenseItem value)
        {
            return ProxyObject(value, v => new ExpenseItem(this, v));
        }

        internal Step ProxyObject(net.sf.mpxj.Step value)
        {
            return ProxyObject(value, v => new Step(this, v));
        }

        internal Location ProxyObject(net.sf.mpxj.Location value)
        {
            return ProxyObject(value, v => new Location(this, v));
        }

        internal LocalDateTimeRange ProxyObject(net.sf.mpxj.LocalDateTimeRange value)
        {
            return ProxyObject(value, v => new LocalDateTimeRange(v));
        }

        internal CostRateTableEntry ProxyObject(net.sf.mpxj.CostRateTableEntry value)
        {
            return ProxyObject(value, v => new CostRateTableEntry(v));
        }

        internal CostRateTable ProxyObject(net.sf.mpxj.CostRateTable value)
        {
            return ProxyObject(value, v => new CostRateTable(this, v));
        }

        internal Availability ProxyObject(net.sf.mpxj.Availability value)
        {
            return ProxyObject(value, v => new Availability(this, v));
        }

        internal AvailabilityTable ProxyObject(net.sf.mpxj.AvailabilityTable value)
        {
            return ProxyObject(value, v => new AvailabilityTable(this, v));
        }

        internal Notes ProxyObject(net.sf.mpxj.Notes value)
        {
            return ProxyObject(value, v => new Notes(v));
        }

        internal ResourceAssignmentWorkgroupFields ProxyObject(net.sf.mpxj.ResourceAssignmentWorkgroupFields value)
        {
            return ProxyObject(value, v => new ResourceAssignmentWorkgroupFields(v));
        }

        internal WorkContour ProxyObject(net.sf.mpxj.WorkContour value)
        {
            return ProxyObject(value, v => new WorkContour(v));
        }

        internal CostAccount ProxyObject(net.sf.mpxj.CostAccount value)
        {
            return ProxyObject(value, v => new CostAccount(this, v));
        }

        internal Table ProxyObject(net.sf.mpxj.Table value)
        {
            return ProxyObject(value, v => new Table(v));
        }

        internal Filter ProxyObject(net.sf.mpxj.Filter value)
        {
            return ProxyObject(value, v => new Filter(v));
        }

        internal Group ProxyObject(net.sf.mpxj.Group value)
        {
            return ProxyObject(value, v => new Group(this, v));
        }

        internal GroupClause ProxyObject(net.sf.mpxj.GroupClause value)
        {
            return ProxyObject(value, v => new GroupClause(v));
        }

        internal DataLink ProxyObject(net.sf.mpxj.DataLink value)
        {
            return ProxyObject(value, v => new DataLink(v));
        }

        internal CustomField ProxyObject(net.sf.mpxj.CustomField value)
        {
            return ProxyObject(value, v => new CustomField(v));
        }

        internal ExpenseCategory ProxyObject(net.sf.mpxj.ExpenseCategory value)
        {
            return ProxyObject(value, v => new ExpenseCategory(v));
        }

        internal NotesTopic ProxyObject(net.sf.mpxj.NotesTopic value)
        {
            return ProxyObject(value, v => new NotesTopic(v));
        }

        internal ViewState ProxyObject(net.sf.mpxj.ViewState value)
        {
            return ProxyObject(value, v => new ViewState(this, v));
        }

        internal CustomFieldValueItem ProxyObject(net.sf.mpxj.mpp.CustomFieldValueItem value)
        {
            return ProxyObject(value, v => new CustomFieldValueItem(v));
        }

        internal ProjectCalendarContainer ProxyObject(net.sf.mpxj.ProjectCalendarContainer value)
        {
            return ProxyObject(value, v => new ProjectCalendarContainer(this, v));
        }

        internal TableContainer ProxyObject(net.sf.mpxj.TableContainer value)
        {
            return ProxyObject(value, v => new TableContainer(this, v));
        }

        internal FilterContainer ProxyObject(net.sf.mpxj.FilterContainer value)
        {
            return ProxyObject(value, v => new FilterContainer(this, v));
        }

        internal EventManager ProxyObject(net.sf.mpxj.EventManager value)
        {
            return ProxyObject(value, v => new EventManager(v));
        }

        internal GroupContainer ProxyObject(net.sf.mpxj.GroupContainer value)
        {
            return ProxyObject(value, v => new GroupContainer(this, v));
        }

        internal CustomFieldContainer ProxyObject(net.sf.mpxj.CustomFieldContainer value)
        {
            return ProxyObject(value, v => new CustomFieldContainer(this, v));
        }

        internal ActivityCodeContainer ProxyObject(net.sf.mpxj.ActivityCodeContainer value)
        {
            return ProxyObject(value, v => new ActivityCodeContainer(this, v));
        }

        internal DataLinkContainer ProxyObject(net.sf.mpxj.DataLinkContainer value)
        {
            return ProxyObject(value, v => new DataLinkContainer(this, v));
        }

        internal ExpenseCategoryContainer ProxyObject(net.sf.mpxj.ExpenseCategoryContainer value)
        {
            return ProxyObject(value, v => new ExpenseCategoryContainer(this, v));
        }

        internal CostAccountContainer ProxyObject(net.sf.mpxj.CostAccountContainer value)
        {
            return ProxyObject(value, v => new CostAccountContainer(this, v));
        }

        internal UserDefinedFieldContainer ProxyObject(net.sf.mpxj.UserDefinedFieldContainer value)
        {
            return ProxyObject(value, v => new UserDefinedFieldContainer(this, v));
        }

        internal WorkContourContainer ProxyObject(net.sf.mpxj.WorkContourContainer value)
        {
            return ProxyObject(value, v => new WorkContourContainer(this, v));
        }

        internal NotesTopicContainer ProxyObject(net.sf.mpxj.NotesTopicContainer value)
        {
            return ProxyObject(value, v => new NotesTopicContainer(this, v));
        }

        internal LocationContainer ProxyObject(net.sf.mpxj.LocationContainer value)
        {
            return ProxyObject(value, v => new LocationContainer(this, v));
        }

        internal object GenericProxyObject(object o)
        {
            if (o == null)
            {
                return null;
            }

            // TODO: complete this switch statement
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

        internal IList<N> ProxyList<M, N>(java.util.List value) where N : IJavaObjectProxy<M>
        {
            return ProxyObject(value, l => new DeepProxyList<M, N>(this, l));
        }

        internal ICollection<N> ProxyCollection<M, N>(java.util.Collection value) where N : IJavaObjectProxy<M>
        {
            return ProxyObject(value, l => new DeepProxyCollection<M, N>(this, l));
        }
    }
}
