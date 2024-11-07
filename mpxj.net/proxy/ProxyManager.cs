using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MPXJ.Net.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010085e039e9e6124613f05ac0f4441c7fa992e7761f2fca914329b462477327ab414b0bc15f320cac66b634607d2656b90c05ecbabb110a4af8b5ea9421e2b674d4b74d859cdd360448dc5723d12f63cf551fdeef87a5882d24fb9254577052c99ed1739380436e982df82cd7ee6ebb82588f578a5c27f40472017ffab697749ecc")]

namespace MPXJ.Net.Proxy
{    
    internal class ProxyManager : AbstractProxyManager
    {
        public ProxyManager()
        {
            //
            // Prepopulate the cache with constants
            //
            PopulateCache(WorkContour.Flat.JavaObject, WorkContour.Flat);
            PopulateCache(WorkContour.BackLoaded.JavaObject, WorkContour.BackLoaded);
            PopulateCache(WorkContour.FrontLoaded.JavaObject, WorkContour.FrontLoaded);
            PopulateCache(WorkContour.DoublePeak.JavaObject, WorkContour.DoublePeak);
            PopulateCache(WorkContour.EarlyPeak.JavaObject, WorkContour.EarlyPeak);
            PopulateCache(WorkContour.LatePeak.JavaObject, WorkContour.LatePeak);
            PopulateCache(WorkContour.Bell.JavaObject, WorkContour.Bell);
            PopulateCache(WorkContour.Turtle.JavaObject, WorkContour.Turtle);
            PopulateCache(WorkContour.Contoured.JavaObject, WorkContour.Contoured);
        }

        internal void PopulateCache(java.lang.Object javaObject, object netObject)
        {
            _objectCache[GetKey(javaObject)] = netObject;
        }

        internal UnitOfMeasure ProxyObject(net.sf.mpxj.UnitOfMeasure value)
        {
            return ProxyObject(value, v => new UnitOfMeasure(v));
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
            return ProxyObject(value, v => new RecurringTask(this, v));
        }

        internal ProjectCalendarHours ProxyObject(net.sf.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, v => new ProjectCalendarHours(this, v));
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

        internal RelationContainer ProxyObject(net.sf.mpxj.RelationContainer value)
        {
            return ProxyObject(value, v => new RelationContainer(this, v));
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
            return ProxyObject(value, v => new ProjectFile(this, v));
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
            return ProxyObject(value, v => new Location(v));
        }

        internal TimeOnlyRange ProxyObject(net.sf.mpxj.LocalTimeRange value)
        {
            return ProxyObject(value, v => new TimeOnlyRange(v));
        }

        internal DateTimeRange ProxyObject(net.sf.mpxj.LocalDateTimeRange value)
        {
            return ProxyObject(value, v => new DateTimeRange(v));
        }

        internal CostRateTableEntry ProxyObject(net.sf.mpxj.CostRateTableEntry value)
        {
            return ProxyObject(value, v => new CostRateTableEntry(this, v));
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
            if (value is net.sf.mpxj.HtmlNotes h)
            {
                return ProxyObject(h);
            }

            if (value is net.sf.mpxj.RtfNotes r)
            {
                return ProxyObject(r);
            }

            if (value is net.sf.mpxj.ParentNotes p)
            {
                return ProxyObject(p);
            }

            if (value is net.sf.mpxj.StructuredNotes s)
            {
                return ProxyObject(s);
            }

            return ProxyObject(value, v => new Notes(v));
        }

        internal HtmlNotes ProxyObject(net.sf.mpxj.HtmlNotes value)
        {
            return ProxyObject(value, v => new HtmlNotes(v));
        }

        internal RtfNotes ProxyObject(net.sf.mpxj.RtfNotes value)
        {
            return ProxyObject(value, v => new RtfNotes(v));
        }

        internal ParentNotes ProxyObject(net.sf.mpxj.ParentNotes value)
        {
            return ProxyObject(value, v => new ParentNotes(this, v));
        }

        internal StructuredNotes ProxyObject(net.sf.mpxj.StructuredNotes value)
        {
            return ProxyObject(value, v => new StructuredNotes(this, v));
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
            return ProxyObject(value, v => new Table(this, v));
        }

        internal Filter ProxyObject(net.sf.mpxj.Filter value)
        {
            return ProxyObject(value, v => new Filter(this, v));
        }

        internal Group ProxyObject(net.sf.mpxj.Group value)
        {
            return ProxyObject(value, v => new Group(this, v));
        }

        internal GroupClause ProxyObject(net.sf.mpxj.GroupClause value)
        {
            return ProxyObject(value, v => new GroupClause(this, v));
        }

        internal DataLink ProxyObject(net.sf.mpxj.DataLink value)
        {
            return ProxyObject(value, v => new DataLink(this, v));
        }

        internal CustomField ProxyObject(net.sf.mpxj.CustomField value)
        {
            return ProxyObject(value, v => new CustomField(this, v));
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

        internal GraphicalIndicator ProxyObject(net.sf.mpxj.GraphicalIndicator value)
        {
            return ProxyObject(value, v => new GraphicalIndicator(this, v));
        }

        internal GenericCriteria ProxyObject(net.sf.mpxj.GenericCriteria value)
        {
            return ProxyObject(value, v => new GenericCriteria(this, v));
        }

        internal GraphicalIndicatorCriteria ProxyObject(net.sf.mpxj.GraphicalIndicatorCriteria value)
        {
            return ProxyObject(value, v => new GraphicalIndicatorCriteria(this, v));
        }

        internal CustomFieldValueMask ProxyObject(net.sf.mpxj.CustomFieldValueMask value)
        {
            return ProxyObject(value, v => new CustomFieldValueMask(v));
        }

        internal GenericCriteriaPrompt ProxyObject(net.sf.mpxj.GenericCriteriaPrompt value)
        {
            return ProxyObject(value, v => new GenericCriteriaPrompt(v));
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

        internal GroupContainer ProxyObject(net.sf.mpxj.GroupContainer value)
        {
            return ProxyObject(value, v => new GroupContainer(this, v));
        }

        internal Column ProxyObject(net.sf.mpxj.Column value)
        {
            return ProxyObject(value, v => new Column(this, v));
        }

        internal TimephasedWork ProxyObject(net.sf.mpxj.TimephasedWork value)
        {
            return ProxyObject(value, v => new TimephasedWork(v));
        }

        internal TimephasedCost ProxyObject(net.sf.mpxj.TimephasedCost value)
        {
            return ProxyObject(value, v => new TimephasedCost(v));
        }

        internal IView ProxyObject(net.sf.mpxj.View value)
        {
            // TODO: implement view hierarchy
            return null;
        }

        internal FontBase ProxyObject(net.sf.mpxj.mpp.FontBase value)
        {
            return ProxyObject(value, v => new FontBase(v));
        }

        internal UserDefinedField ProxyObject(net.sf.mpxj.UserDefinedField value)
        {
            return ProxyObject(value, v => new UserDefinedField(v));
        }

        internal FontStyle ProxyObject(net.sf.mpxj.mpp.FontStyle value)
        {
            return ProxyObject(value, v => new FontStyle(this, v));
        }

        internal CustomFieldLookupTable ProxyObject(net.sf.mpxj.CustomFieldLookupTable value)
        {
            return ProxyObject(value, v => new CustomFieldLookupTable(this, v));
        }

        internal Rate ProxyObject(net.sf.mpxj.Rate value)
        {
            return ProxyObject(value, v => new Rate(v));
        }

        internal Priority ProxyObject(net.sf.mpxj.Priority value)
        {
            return ProxyObject(value, v => new Priority(v));
        }

        internal Duration ProxyObject(net.sf.mpxj.Duration value)
        {
            return ProxyObject(value, v => new Duration(v));
        }

        internal DateOnlyRange ProxyObject(net.sf.mpxj.LocalDateRange value)
        {
            return ProxyObject(value, v => new DateOnlyRange(v));
        }

        internal Shift ProxyObject(net.sf.mpxj.Shift value)
        {
            return ProxyObject(value, v => new Shift(this, v));
        }

        internal ShiftPeriod ProxyObject(net.sf.mpxj.ShiftPeriod value)
        {
            return ProxyObject(value, v => new ShiftPeriod(this, v));
        }

        internal ShiftContainer ProxyObject(net.sf.mpxj.ShiftContainer value)
        {
            return ProxyObject(value, v => new ShiftContainer(this, v));
        }

        internal ShiftPeriodContainer ProxyObject(net.sf.mpxj.ShiftPeriodContainer value)
        {
            return ProxyObject(value, v => new ShiftPeriodContainer(this, v));
        }

        internal IFieldType ProxyObject(net.sf.mpxj.FieldType value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is net.sf.mpxj.UserDefinedField udf)
            {
                return ProxyObject(udf, v => new UserDefinedField(v));
            }

            if (value.getFieldTypeClass() == net.sf.mpxj.FieldTypeClass.UNKNOWN)
            {
                return ProxyObject(value, v => new UnknownFieldType(v));
            }

            return EnumExtensionMethods.FieldTypeDictionary[value];
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

        internal UnitOfMeasureContainer ProxyObject(net.sf.mpxj.UnitOfMeasureContainer value)
        {
            return ProxyObject(value, v => new UnitOfMeasureContainer(this, v));
        }

        internal object GenericProxyObject(object o)
        {
            if (o == null)
            {
                return null;
            }

            var key = o.GetType().FullName;
            switch (key)
            {
                case "net.sf.mpxj.Duration":
                    return ProxyObject((net.sf.mpxj.Duration)o);

                case "net.sf.mpxj.Rate":
                    return ProxyObject((net.sf.mpxj.Rate)o);

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

                case "net.sf.mpxj.Notes":
                    return ProxyObject((net.sf.mpxj.Notes)o);

                case "net.sf.mpxj.HtmlNotes":
                    return ProxyObject((net.sf.mpxj.HtmlNotes)o);

                case "net.sf.mpxj.RtfNotes":
                    return ProxyObject((net.sf.mpxj.RtfNotes)o);

                case "net.sf.mpxj.ParentNotes":
                    return ProxyObject((net.sf.mpxj.ParentNotes)o);

                case "net.sf.mpxj.StructuredNotes":
                    return ProxyObject((net.sf.mpxj.StructuredNotes)o);

                case "net.sf.mpxj.Priority":
                    return ProxyObject((net.sf.mpxj.Priority)o);

                case "net.sf.mpxj.WorkContour":
                    return ProxyObject((net.sf.mpxj.WorkContour)o);

                case "java.lang.Boolean":
                    return ((java.lang.Boolean)o).booleanValue();

                case "java.lang.Character":
                    return ((java.lang.Character)o).charValue();

                case "java.lang.Double":
                    return ((java.lang.Double)o).doubleValue();

                case "java.lang.Integer":
                    return ((java.lang.Integer)o).ConvertType();

                case "java.time.DayOfWeek":
                    return ((java.time.DayOfWeek)o).ConvertType();

                case "java.time.LocalDateTime":
                    return ((java.time.LocalDateTime)o).ConvertType();

                case "java.time.LocalDate":
                    return ((java.time.LocalDate)o).ConvertType();

                case "java.time.LocalTime":
                    return ((java.time.LocalTime)o).ConvertType();

                case "java.util.UUID":
                    return ((java.util.UUID)o).ConvertType();

                // MPXJ Enums
                case "net.sf.mpxj.AccrueType":
                    return ((net.sf.mpxj.AccrueType)o).ConvertType();

                case "net.sf.mpxj.BookingType":
                    return ((net.sf.mpxj.BookingType)o).ConvertType();

                case "net.sf.mpxj.CodePage":
                    return ((net.sf.mpxj.CodePage)o).ConvertType();

                case "net.sf.mpxj.CriticalActivityType":
                    return ((net.sf.mpxj.CriticalActivityType)o).ConvertType();

                case "net.sf.mpxj.CurrencySymbolPosition":
                    return ((net.sf.mpxj.CurrencySymbolPosition)o).ConvertType();

                case "net.sf.mpxj.DateOrder":
                    return ((net.sf.mpxj.DateOrder)o).ConvertType();

                case "net.sf.mpxj.FileVersion":
                    return ((net.sf.mpxj.FileVersion)o).ConvertType();

                case "net.sf.mpxj.EarnedValueMethod":
                    return ((net.sf.mpxj.EarnedValueMethod)o).ConvertType();

                case "net.sf.mpxj.TimeUnit":
                    return ((net.sf.mpxj.TimeUnit)o).ConvertType();

                case "net.sf.mpxj.ProjectDateFormat":
                    return ((net.sf.mpxj.ProjectDateFormat)o).ConvertType();

                case "net.sf.mpxj.ProjectTimeFormat":
                    return ((net.sf.mpxj.ProjectTimeFormat)o).ConvertType();

                case "net.sf.mpxj.ScheduleFrom":
                    return ((net.sf.mpxj.ScheduleFrom)o).ConvertType();

                case "net.sf.mpxj.TaskType":
                    return ((net.sf.mpxj.TaskType)o).ConvertType();

                case "net.sf.mpxj.ResourceType":
                    return ((net.sf.mpxj.ResourceType)o).ConvertType();

                case "net.sf.mpxj.ConstraintType":
                    return ((net.sf.mpxj.ConstraintType)o).ConvertType();

                case "net.sf.mpxj.TaskMode":
                    return ((net.sf.mpxj.TaskMode)o).ConvertType();

                case "net.sf.mpxj.ResourceRequestType":
                    return ((net.sf.mpxj.ResourceRequestType)o).ConvertType();

                case "net.sf.mpxj.RateSource":
                    return ((net.sf.mpxj.RateSource)o).ConvertType();

                case "System.String":
                    return o;
            }

            throw new NotSupportedException();
        }

        internal IList<N> ProxyList<M, N>(Func<M, N> fromJava, Func<N, M> toJava, java.util.List value)
        {
            return ProxyObject(value, l => new ProxyList<M, N>(fromJava, toJava, l));
        }

        internal ICollection<N> ProxyCollection<M, N>(Func<M, N> fromJava, Func<N, M> toJava, java.util.Collection value)
        {
            return ProxyObject(value, l => new ProxyCollection<M, N>(fromJava, toJava, l));
        }

        internal ISet<N> ProxySet<M, N>(Func<M, N> fromJava, Func<N, M> toJava, java.util.Set value)
        {
            return ProxyObject(value, l => new ProxySet<M, N>(fromJava, toJava, l));
        }

        internal IDictionary<NK, NV> ProxyDictionary<MK, MV, NK, NV>(Func<MK, NK> keyFromJava, Func<NK, MK> keyToJava, Func<MV, NV> valueFromJava, Func<NV, MV> valueToJava, java.util.Map value)
        {
            return ProxyObject(value, l => new ProxyDictionary<MK, MV, NK, NV>(this, keyFromJava, keyToJava, valueFromJava, valueToJava, l));
        }
    }
}
