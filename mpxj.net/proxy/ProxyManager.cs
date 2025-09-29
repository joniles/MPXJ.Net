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

        internal UnitOfMeasure ProxyObject(org.mpxj.UnitOfMeasure value)
        {
            return ProxyObject(value, v => new UnitOfMeasure(v));
        }

        internal Resource ProxyObject(org.mpxj.Resource value)
        {
            return ProxyObject(value, v => new Resource(this, v));
        }

        internal ProjectCalendarWeek ProxyObject(org.mpxj.ProjectCalendarWeek value)
        {
            return ProxyObject(value, v => new ProjectCalendarWeek(this, v));
        }

        internal ProjectCalendarException ProxyObject(org.mpxj.ProjectCalendarException value)
        {
            return ProxyObject(value, v => new ProjectCalendarException(this, v));
        }

        internal ProjectCalendar ProxyObject(org.mpxj.ProjectCalendar value)
        {
            return ProxyObject(value, v => new ProjectCalendar(this, v));
        }

        internal RecurringData ProxyObject(org.mpxj.RecurringData value)
        {
            return ProxyObject(value, v => new RecurringData(v));
        }

        internal RecurringTask ProxyObject(org.mpxj.RecurringTask value)
        {
            return ProxyObject(value, v => new RecurringTask(this, v));
        }

        internal ProjectCalendarHours ProxyObject(org.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, v => new ProjectCalendarHours(this, v));
        }

        internal ProjectConfig ProxyObject(org.mpxj.ProjectConfig value)
        {
            return ProxyObject(value, v => new ProjectConfig(v));
        }

        internal ProjectProperties ProxyObject(org.mpxj.ProjectProperties value)
        {
            return ProxyObject(value, v => new ProjectProperties(this, v));
        }

        internal ResourceContainer ProxyObject(org.mpxj.ResourceContainer value)
        {
            return ProxyObject(value, v => new ResourceContainer(this, v));
        }

        internal TaskContainer ProxyObject(org.mpxj.TaskContainer value)
        {
            return ProxyObject(value, v => new TaskContainer(this, v));
        }

        internal RelationContainer ProxyObject(org.mpxj.RelationContainer value)
        {
            return ProxyObject(value, v => new RelationContainer(this, v));
        }

        internal ResourceAssignmentContainer ProxyObject(org.mpxj.ResourceAssignmentContainer value)
        {
            return ProxyObject(value, v => new ResourceAssignmentContainer(this, v));
        }

        internal ViewContainer ProxyObject(org.mpxj.ViewContainer value)
        {
            return ProxyObject(value, v => new ViewContainer(this, v));
        }

        internal Task ProxyObject(org.mpxj.Task value)
        {
            return ProxyObject(value, v => new Task(this, v));
        }

        internal ProjectFile ProxyObject(org.mpxj.ProjectFile value)
        {
            return ProxyObject(value, v => new ProjectFile(this, v));
        }

        internal ResourceAssignment ProxyObject(org.mpxj.ResourceAssignment value)
        {
            return ProxyObject(value, v => new ResourceAssignment(this, v));
        }

        internal ActivityCode ProxyObject(org.mpxj.ActivityCode value)
        {
            return ProxyObject(value, v => new ActivityCode(this, v));
        }

        internal ActivityCodeValue ProxyObject(org.mpxj.ActivityCodeValue value)
        {
            return ProxyObject(value, v => new ActivityCodeValue(this, v));
        }

        internal ProjectCode ProxyObject(org.mpxj.ProjectCode value)
        {
            return ProxyObject(value, v => new ProjectCode(this, v));
        }

        internal ProjectCodeValue ProxyObject(org.mpxj.ProjectCodeValue value)
        {
            return ProxyObject(value, v => new ProjectCodeValue(this, v));
        }

        internal ResourceCode ProxyObject(org.mpxj.ResourceCode value)
        {
            return ProxyObject(value, v => new ResourceCode(this, v));
        }

        internal ResourceCodeValue ProxyObject(org.mpxj.ResourceCodeValue value)
        {
            return ProxyObject(value, v => new ResourceCodeValue(this, v));
        }

        internal RoleCode ProxyObject(org.mpxj.RoleCode value)
        {
            return ProxyObject(value, v => new RoleCode(this, v));
        }

        internal RoleCodeValue ProxyObject(org.mpxj.RoleCodeValue value)
        {
            return ProxyObject(value, v => new RoleCodeValue(this, v));
        }

        internal ResourceAssignmentCode ProxyObject(org.mpxj.ResourceAssignmentCode value)
        {
            return ProxyObject(value, v => new ResourceAssignmentCode(this, v));
        }

        internal ResourceAssignmentCodeValue ProxyObject(org.mpxj.ResourceAssignmentCodeValue value)
        {
            return ProxyObject(value, v => new ResourceAssignmentCodeValue(this, v));
        }

        internal Relation ProxyObject(org.mpxj.Relation value)
        {
            return ProxyObject(value, v => new Relation(this, v));
        }

        internal ExpenseItem ProxyObject(org.mpxj.ExpenseItem value)
        {
            return ProxyObject(value, v => new ExpenseItem(this, v));
        }

        internal Step ProxyObject(org.mpxj.Step value)
        {
            return ProxyObject(value, v => new Step(this, v));
        }

        internal Location ProxyObject(org.mpxj.Location value)
        {
            return ProxyObject(value, v => new Location(v));
        }

        internal TimeOnlyRange ProxyObject(org.mpxj.LocalTimeRange value)
        {
            return ProxyObject(value, v => new TimeOnlyRange(v));
        }

        internal DateTimeRange ProxyObject(org.mpxj.LocalDateTimeRange value)
        {
            return ProxyObject(value, v => new DateTimeRange(v));
        }

        internal CostRateTableEntry ProxyObject(org.mpxj.CostRateTableEntry value)
        {
            return ProxyObject(value, v => new CostRateTableEntry(this, v));
        }

        internal CostRateTable ProxyObject(org.mpxj.CostRateTable value)
        {
            return ProxyObject(value, v => new CostRateTable(this, v));
        }

        internal Availability ProxyObject(org.mpxj.Availability value)
        {
            return ProxyObject(value, v => new Availability(this, v));
        }

        internal AvailabilityTable ProxyObject(org.mpxj.AvailabilityTable value)
        {
            return ProxyObject(value, v => new AvailabilityTable(this, v));
        }

        internal Notes ProxyObject(org.mpxj.Notes value)
        {
            if (value is org.mpxj.HtmlNotes h)
            {
                return ProxyObject(h);
            }

            if (value is org.mpxj.RtfNotes r)
            {
                return ProxyObject(r);
            }

            if (value is org.mpxj.ParentNotes p)
            {
                return ProxyObject(p);
            }

            if (value is org.mpxj.StructuredNotes s)
            {
                return ProxyObject(s);
            }

            return ProxyObject(value, v => new Notes(v));
        }

        internal HtmlNotes ProxyObject(org.mpxj.HtmlNotes value)
        {
            return ProxyObject(value, v => new HtmlNotes(v));
        }

        internal RtfNotes ProxyObject(org.mpxj.RtfNotes value)
        {
            return ProxyObject(value, v => new RtfNotes(v));
        }

        internal ParentNotes ProxyObject(org.mpxj.ParentNotes value)
        {
            return ProxyObject(value, v => new ParentNotes(this, v));
        }

        internal StructuredNotes ProxyObject(org.mpxj.StructuredNotes value)
        {
            return ProxyObject(value, v => new StructuredNotes(this, v));
        }

        internal ResourceAssignmentWorkgroupFields ProxyObject(org.mpxj.ResourceAssignmentWorkgroupFields value)
        {
            return ProxyObject(value, v => new ResourceAssignmentWorkgroupFields(v));
        }

        internal WorkContour ProxyObject(org.mpxj.WorkContour value)
        {
            return ProxyObject(value, v => new WorkContour(v));
        }

        internal CostAccount ProxyObject(org.mpxj.CostAccount value)
        {
            return ProxyObject(value, v => new CostAccount(this, v));
        }

        internal Table ProxyObject(org.mpxj.Table value)
        {
            return ProxyObject(value, v => new Table(this, v));
        }

        internal Filter ProxyObject(org.mpxj.Filter value)
        {
            return ProxyObject(value, v => new Filter(this, v));
        }

        internal Group ProxyObject(org.mpxj.Group value)
        {
            return ProxyObject(value, v => new Group(this, v));
        }

        internal GroupClause ProxyObject(org.mpxj.GroupClause value)
        {
            return ProxyObject(value, v => new GroupClause(this, v));
        }

        internal DataLink ProxyObject(org.mpxj.DataLink value)
        {
            return ProxyObject(value, v => new DataLink(this, v));
        }

        internal CustomField ProxyObject(org.mpxj.CustomField value)
        {
            return ProxyObject(value, v => new CustomField(this, v));
        }

        internal ExpenseCategory ProxyObject(org.mpxj.ExpenseCategory value)
        {
            return ProxyObject(value, v => new ExpenseCategory(v));
        }

        internal NotesTopic ProxyObject(org.mpxj.NotesTopic value)
        {
            return ProxyObject(value, v => new NotesTopic(v));
        }

        internal ViewState ProxyObject(org.mpxj.ViewState value)
        {
            return ProxyObject(value, v => new ViewState(this, v));
        }

        internal CustomFieldValueItem ProxyObject(org.mpxj.mpp.CustomFieldValueItem value)
        {
            return ProxyObject(value, v => new CustomFieldValueItem(v));
        }

        internal GraphicalIndicator ProxyObject(org.mpxj.GraphicalIndicator value)
        {
            return ProxyObject(value, v => new GraphicalIndicator(this, v));
        }

        internal GenericCriteria ProxyObject(org.mpxj.GenericCriteria value)
        {
            return ProxyObject(value, v => new GenericCriteria(this, v));
        }

        internal GraphicalIndicatorCriteria ProxyObject(org.mpxj.GraphicalIndicatorCriteria value)
        {
            return ProxyObject(value, v => new GraphicalIndicatorCriteria(this, v));
        }

        internal CustomFieldValueMask ProxyObject(org.mpxj.CustomFieldValueMask value)
        {
            return ProxyObject(value, v => new CustomFieldValueMask(v));
        }

        internal GenericCriteriaPrompt ProxyObject(org.mpxj.GenericCriteriaPrompt value)
        {
            return ProxyObject(value, v => new GenericCriteriaPrompt(v));
        }

        internal ProjectCalendarContainer ProxyObject(org.mpxj.ProjectCalendarContainer value)
        {
            return ProxyObject(value, v => new ProjectCalendarContainer(this, v));
        }

        internal TableContainer ProxyObject(org.mpxj.TableContainer value)
        {
            return ProxyObject(value, v => new TableContainer(this, v));
        }

        internal FilterContainer ProxyObject(org.mpxj.FilterContainer value)
        {
            return ProxyObject(value, v => new FilterContainer(this, v));
        }

        internal GroupContainer ProxyObject(org.mpxj.GroupContainer value)
        {
            return ProxyObject(value, v => new GroupContainer(this, v));
        }

        internal Column ProxyObject(org.mpxj.Column value)
        {
            return ProxyObject(value, v => new Column(this, v));
        }

        internal TimephasedWork ProxyObject(org.mpxj.TimephasedWork value)
        {
            return ProxyObject(value, v => new TimephasedWork(v));
        }

        internal TimephasedCost ProxyObject(org.mpxj.TimephasedCost value)
        {
            return ProxyObject(value, v => new TimephasedCost(v));
        }

        internal IView ProxyObject(org.mpxj.View value)
        {
            // TODO: implement view hierarchy
            return null;
        }

        internal FontBase ProxyObject(org.mpxj.mpp.FontBase value)
        {
            return ProxyObject(value, v => new FontBase(v));
        }

        internal UserDefinedField ProxyObject(org.mpxj.UserDefinedField value)
        {
            return ProxyObject(value, v => new UserDefinedField(v));
        }

        internal FontStyle ProxyObject(org.mpxj.mpp.FontStyle value)
        {
            return ProxyObject(value, v => new FontStyle(this, v));
        }

        internal CustomFieldLookupTable ProxyObject(org.mpxj.CustomFieldLookupTable value)
        {
            return ProxyObject(value, v => new CustomFieldLookupTable(this, v));
        }

        internal Rate ProxyObject(org.mpxj.Rate value)
        {
            return ProxyObject(value, v => new Rate(v));
        }

        internal Priority ProxyObject(org.mpxj.Priority value)
        {
            return ProxyObject(value, v => new Priority(v));
        }

        internal Duration ProxyObject(org.mpxj.Duration value)
        {
            return ProxyObject(value, v => new Duration(v));
        }

        internal DateOnlyRange ProxyObject(org.mpxj.LocalDateRange value)
        {
            return ProxyObject(value, v => new DateOnlyRange(v));
        }

        internal Shift ProxyObject(org.mpxj.Shift value)
        {
            return ProxyObject(value, v => new Shift(this, v));
        }

        internal ShiftPeriod ProxyObject(org.mpxj.ShiftPeriod value)
        {
            return ProxyObject(value, v => new ShiftPeriod(this, v));
        }

        internal Currency ProxyObject(org.mpxj.Currency value)
        {
            return ProxyObject(value, v => new Currency(v));
        }

        internal EpsNode ProxyObject(org.mpxj.EpsNode value)
        {
            return ProxyObject(value, v => new EpsNode(this, v));
        }

        internal EpsProjectNode ProxyObject(org.mpxj.EpsProjectNode value)
        {
            return ProxyObject(value, v => new EpsProjectNode(this,v));
        }

        internal OpcProject ProxyObject(org.mpxj.opc.OpcProject value)
        {
            return ProxyObject(value, v => new OpcProject(v));
        }

        internal OpcProjectBaseline ProxyObject(org.mpxj.opc.OpcProjectBaseline value)
        {
            return ProxyObject(value, v => new OpcProjectBaseline(v));
        }

        internal PwaProject ProxyObject(org.mpxj.pwa.PwaProject value)
        {
            return ProxyObject(value, v => new PwaProject(v));
        }

        internal WebServicesProject ProxyObject(org.mpxj.primavera.webservices.WebServicesProject value)
        {
            return ProxyObject(value, v => new WebServicesProject(v));
        }

        internal ShiftContainer ProxyObject(org.mpxj.ShiftContainer value)
        {
            return ProxyObject(value, v => new ShiftContainer(this, v));
        }

        internal ShiftPeriodContainer ProxyObject(org.mpxj.ShiftPeriodContainer value)
        {
            return ProxyObject(value, v => new ShiftPeriodContainer(this, v));
        }

        internal IFieldType ProxyObject(org.mpxj.FieldType value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is org.mpxj.UserDefinedField udf)
            {
                return ProxyObject(udf, v => new UserDefinedField(v));
            }

            if (value.getFieldTypeClass() == org.mpxj.FieldTypeClass.UNKNOWN)
            {
                return ProxyObject(value, v => new UnknownFieldType(v));
            }

            return EnumExtensionMethods.FieldTypeDictionary[value];
        }

        internal CustomFieldContainer ProxyObject(org.mpxj.CustomFieldContainer value)
        {
            return ProxyObject(value, v => new CustomFieldContainer(this, v));
        }

        internal ActivityCodeContainer ProxyObject(org.mpxj.ActivityCodeContainer value)
        {
            return ProxyObject(value, v => new ActivityCodeContainer(this, v));
        }

        internal ProjectCodeContainer ProxyObject(org.mpxj.ProjectCodeContainer value)
        {
            return ProxyObject(value, v => new ProjectCodeContainer(this, v));
        }

        internal ResourceCodeContainer ProxyObject(org.mpxj.ResourceCodeContainer value)
        {
            return ProxyObject(value, v => new ResourceCodeContainer(this, v));
        }

        internal RoleCodeContainer ProxyObject(org.mpxj.RoleCodeContainer value)
        {
            return ProxyObject(value, v => new RoleCodeContainer(this, v));
        }

        internal ResourceAssignmentCodeContainer ProxyObject(org.mpxj.ResourceAssignmentCodeContainer value)
        {
            return ProxyObject(value, v => new ResourceAssignmentCodeContainer(this, v));
        }

        internal DataLinkContainer ProxyObject(org.mpxj.DataLinkContainer value)
        {
            return ProxyObject(value, v => new DataLinkContainer(this, v));
        }

        internal ExpenseCategoryContainer ProxyObject(org.mpxj.ExpenseCategoryContainer value)
        {
            return ProxyObject(value, v => new ExpenseCategoryContainer(this, v));
        }

        internal CostAccountContainer ProxyObject(org.mpxj.CostAccountContainer value)
        {
            return ProxyObject(value, v => new CostAccountContainer(this, v));
        }

        internal UserDefinedFieldContainer ProxyObject(org.mpxj.UserDefinedFieldContainer value)
        {
            return ProxyObject(value, v => new UserDefinedFieldContainer(this, v));
        }

        internal WorkContourContainer ProxyObject(org.mpxj.WorkContourContainer value)
        {
            return ProxyObject(value, v => new WorkContourContainer(this, v));
        }

        internal NotesTopicContainer ProxyObject(org.mpxj.NotesTopicContainer value)
        {
            return ProxyObject(value, v => new NotesTopicContainer(this, v));
        }

        internal LocationContainer ProxyObject(org.mpxj.LocationContainer value)
        {
            return ProxyObject(value, v => new LocationContainer(this, v));
        }

        internal UnitOfMeasureContainer ProxyObject(org.mpxj.UnitOfMeasureContainer value)
        {
            return ProxyObject(value, v => new UnitOfMeasureContainer(this, v));
        }

        internal CurrencyContainer ProxyObject(org.mpxj.CurrencyContainer value)
        {
            return ProxyObject(value, v => new CurrencyContainer(this, v));
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
                case "org.mpxj.Duration":
                    return ProxyObject((org.mpxj.Duration)o);

                case "org.mpxj.Rate":
                    return ProxyObject((org.mpxj.Rate)o);

                case "org.mpxj.Resource":
                    return ProxyObject((org.mpxj.Resource)o);

                case "org.mpxj.Task":
                    return ProxyObject((org.mpxj.Task)o);

                case "org.mpxj.ResourceAssignment":
                    return ProxyObject((org.mpxj.ResourceAssignment)o);

                case "org.mpxj.ProjectCalendarWeek":
                    return ProxyObject((org.mpxj.ProjectCalendarWeek)o);

                case "org.mpxj.ProjectCalendarException":
                    return ProxyObject((org.mpxj.ProjectCalendarException)o);

                case "org.mpxj.ProjectCalendar":
                    return ProxyObject((org.mpxj.ProjectCalendar)o);

                case "org.mpxj.RecurringData":
                    return ProxyObject((org.mpxj.RecurringData)o);

                case "org.mpxj.ProjectCalendarHours":
                    return ProxyObject((org.mpxj.ProjectCalendarHours)o);

                case "org.mpxj.Notes":
                    return ProxyObject((org.mpxj.Notes)o);

                case "org.mpxj.HtmlNotes":
                    return ProxyObject((org.mpxj.HtmlNotes)o);

                case "org.mpxj.RtfNotes":
                    return ProxyObject((org.mpxj.RtfNotes)o);

                case "org.mpxj.ParentNotes":
                    return ProxyObject((org.mpxj.ParentNotes)o);

                case "org.mpxj.StructuredNotes":
                    return ProxyObject((org.mpxj.StructuredNotes)o);

                case "org.mpxj.Priority":
                    return ProxyObject((org.mpxj.Priority)o);

                case "org.mpxj.WorkContour":
                    return ProxyObject((org.mpxj.WorkContour)o);

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

                case "java.util.Map":
                case "java.util.HashMap":
                case "java.util.TreeMap":
                    // Best effort conversion leaving original Java types
                    return ProxyDictionary<object, object, object, object>(k => k, k => k, v => v, v => v, (java.util.Map)o);
                
                // MPXJ Enums
                case "org.mpxj.AccrueType":
                    return ((org.mpxj.AccrueType)o).ConvertType();

                case "org.mpxj.BookingType":
                    return ((org.mpxj.BookingType)o).ConvertType();

                case "org.mpxj.CodePage":
                    return ((org.mpxj.CodePage)o).ConvertType();

                case "org.mpxj.CriticalActivityType":
                    return ((org.mpxj.CriticalActivityType)o).ConvertType();

                case "org.mpxj.CurrencySymbolPosition":
                    return ((org.mpxj.CurrencySymbolPosition)o).ConvertType();

                case "org.mpxj.DateOrder":
                    return ((org.mpxj.DateOrder)o).ConvertType();

                case "org.mpxj.FileVersion":
                    return ((org.mpxj.FileVersion)o).ConvertType();

                case "org.mpxj.EarnedValueMethod":
                    return ((org.mpxj.EarnedValueMethod)o).ConvertType();

                case "org.mpxj.TimeUnit":
                    return ((org.mpxj.TimeUnit)o).ConvertType();

                case "org.mpxj.ProjectDateFormat":
                    return ((org.mpxj.ProjectDateFormat)o).ConvertType();

                case "org.mpxj.ProjectTimeFormat":
                    return ((org.mpxj.ProjectTimeFormat)o).ConvertType();

                case "org.mpxj.ScheduleFrom":
                    return ((org.mpxj.ScheduleFrom)o).ConvertType();

                case "org.mpxj.TaskType":
                    return ((org.mpxj.TaskType)o).ConvertType();

                case "org.mpxj.ResourceType":
                    return ((org.mpxj.ResourceType)o).ConvertType();

                case "org.mpxj.ConstraintType":
                    return ((org.mpxj.ConstraintType)o).ConvertType();

                case "org.mpxj.TaskMode":
                    return ((org.mpxj.TaskMode)o).ConvertType();

                case "org.mpxj.ResourceRequestType":
                    return ((org.mpxj.ResourceRequestType)o).ConvertType();

                case "org.mpxj.RateSource":
                    return ((org.mpxj.RateSource)o).ConvertType();
                
                case "org.mpxj.TotalSlackCalculationType":
                    return ((org.mpxj.TotalSlackCalculationType)o).ConvertType();

                case "org.mpxj.RelationshipLagCalendar":
                    return ((org.mpxj.RelationshipLagCalendar)o).ConvertType();
                
                case "org.mpxj.WorkGroup":
                    return ((org.mpxj.WorkGroup)o).ConvertType();
                
                case "System.String":
                case "System.Byte[]":
                    return o;
            }

            throw new NotSupportedException($"No conversion available for {key}");
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
