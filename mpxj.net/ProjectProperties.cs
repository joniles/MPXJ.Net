using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectProperties : ITimeUnitDefaultsContainer<net.sf.mpxj.ProjectProperties>, IJavaObjectProxy<net.sf.mpxj.ProjectProperties>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectProperties JavaObject { get; }

        internal ProjectProperties(ProxyManager proxyManager, net.sf.mpxj.ProjectProperties javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public TimeUnit? DefaultDurationUnits
        {
            get => JavaObject.getDefaultDurationUnits().ConvertType();
            set => JavaObject.setDefaultDurationUnits(value.ConvertType());
        }

        public bool DefaultDurationIsFixed
        {
            get => JavaObject.getDefaultDurationIsFixed();
            set => JavaObject.setDefaultDurationIsFixed(value);
        }

        public TimeUnit? DefaultWorkUnits
        {
            get => JavaObject.getDefaultWorkUnits().ConvertType();
            set => JavaObject.setDefaultWorkUnits(value.ConvertType());
        }

        public Rate DefaultStandardRate
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultStandardRate());
            set => JavaObject.setDefaultStandardRate(value.JavaObject);
        }

        public Rate DefaultOvertimeRate
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultOvertimeRate());
            set => JavaObject.setDefaultOvertimeRate(value.JavaObject);
        }

        public bool UpdatingTaskStatusUpdatesResourceStatus
        {
            get => JavaObject.getUpdatingTaskStatusUpdatesResourceStatus();
            set => JavaObject.setUpdatingTaskStatusUpdatesResourceStatus(value);
        }

        public bool SplitInProgressTasks
        {
            get => JavaObject.getSplitInProgressTasks();
            set => JavaObject.setSplitInProgressTasks(value);
        }

        public DateOrder? DateOrder
        {
            get => JavaObject.getDateOrder().ConvertType();
            set => JavaObject.setDateOrder(value.ConvertType());
        }

        public ProjectTimeFormat? TimeFormat
        {
            get => JavaObject.getTimeFormat().ConvertType();
            set => JavaObject.setTimeFormat(value.ConvertType());
        }

        public TimeOnly? DefaultStartTime
        {
            get => JavaObject.getDefaultStartTime().ConvertType();
            set => JavaObject.setDefaultStartTime(value.ConvertType());
        }

        public char DateSeparator
        {
            get => JavaObject.getDateSeparator();
            set => JavaObject.setDateSeparator(value);
        }

        public char TimeSeparator
        {
            get => JavaObject.getTimeSeparator();
            set => JavaObject.setTimeSeparator(value);
        }

        public string AMText
        {
            get => JavaObject.getAMText();
            set => JavaObject.setAMText(value);
        }

        public string PMText
        {
            get => JavaObject.getPMText();
            set => JavaObject.setPMText(value);
        }

        public ProjectDateFormat? DateFormat
        {
            get => JavaObject.getDateFormat().ConvertType();
            set => JavaObject.setDateFormat(value.ConvertType());
        }

        public ProjectDateFormat? BarTextDateFormat
        {
            get => JavaObject.getBarTextDateFormat().ConvertType();
            set => JavaObject.setBarTextDateFormat(value.ConvertType());
        }

        public TimeOnly? DefaultEndTime
        {
            get => JavaObject.getDefaultEndTime().ConvertType();
            set => JavaObject.setDefaultEndTime(value.ConvertType());
        }

        public string ProjectTitle
        {
            get => JavaObject.getProjectTitle();
            set => JavaObject.setProjectTitle(value);
        }

        public string Company
        {
            get => JavaObject.getCompany();
            set => JavaObject.setCompany(value);
        }

        public string Manager
        {
            get => JavaObject.getManager();
            set => JavaObject.setManager(value);
        }

        public int? DefaultCalendarUniqueID
        {
            get => JavaObject.getDefaultCalendarUniqueID().ConvertType();
            set => JavaObject.setDefaultCalendarUniqueID(value.ConvertType());
        }

        public ProjectCalendar DefaultCalendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultCalendar());
            set => JavaObject.setDefaultCalendar(value.JavaObject);
        }

        public DateTime? StartDate
        {
            get => JavaObject.getStartDate().ConvertType();
            set => JavaObject.setStartDate(value.ConvertType());
        }

        public DateTime? FinishDate
        {
            get => JavaObject.getFinishDate().ConvertType();
            set => JavaObject.setFinishDate(value.ConvertType());
        }

        public ScheduleFrom? ScheduleFrom
        {
            get => JavaObject.getScheduleFrom().ConvertType();
            set => JavaObject.setScheduleFrom(value.ConvertType());
        }

        public DateTime? CurrentDate
        {
            get => JavaObject.getCurrentDate().ConvertType();
            set => JavaObject.setCurrentDate(value.ConvertType());
        }

        public string Comments
        {
            get => JavaObject.getComments();
            set => JavaObject.setComments(value);
        }

        public double? Cost
        {
            get => JavaObject.getCost().ConvertType();
            set => JavaObject.setCost(value.ConvertType());
        }

        public double? BaselineCost
        {
            get => JavaObject.getBaselineCost().ConvertType();
            set => JavaObject.setBaselineCost(value.ConvertType());
        }

        public double? ActualCost
        {
            get => JavaObject.getActualCost().ConvertType();
            set => JavaObject.setActualCost(value.ConvertType());
        }

        public Duration Work
        {
            get => _proxyManager.ProxyObject(JavaObject.getWork());
            set => JavaObject.setWork(value.JavaObject);
        }

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineWork());
            set => JavaObject.setBaselineWork(value.JavaObject);
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value.JavaObject);
        }

        public double? Work2
        {
            get => JavaObject.getWork2().ConvertType();
            set => JavaObject.setWork2(value.ConvertType());
        }

        public Duration Duration
        {
            get => _proxyManager.ProxyObject(JavaObject.getDuration());
            set => JavaObject.setDuration(value.JavaObject);
        }

        public Duration BaselineDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineDuration());
            set => JavaObject.setBaselineDuration(value.JavaObject);
        }

        public Duration ActualDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualDuration());
            set => JavaObject.setActualDuration(value.JavaObject);
        }

        public double? PercentageComplete
        {
            get => JavaObject.getPercentageComplete().ConvertType();
            set => JavaObject.setPercentageComplete(value.ConvertType());
        }

        public DateTime? BaselineStart
        {
            get => JavaObject.getBaselineStart().ConvertType();
            set => JavaObject.setBaselineStart(value.ConvertType());
        }

        public DateTime? BaselineFinish
        {
            get => JavaObject.getBaselineFinish().ConvertType();
            set => JavaObject.setBaselineFinish(value.ConvertType());
        }

        public DateTime? ActualStart
        {
            get => JavaObject.getActualStart().ConvertType();
            set => JavaObject.setActualStart(value.ConvertType());
        }

        public DateTime? ActualFinish
        {
            get => JavaObject.getActualFinish().ConvertType();
            set => JavaObject.setActualFinish(value.ConvertType());
        }

        public Duration StartVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartVariance());
            set => JavaObject.setStartVariance(value.JavaObject);
        }

        public Duration FinishVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishVariance());
            set => JavaObject.setFinishVariance(value.JavaObject);
        }

        public string Subject
        {
            get => JavaObject.getSubject();
            set => JavaObject.setSubject(value);
        }

        public string Author
        {
            get => JavaObject.getAuthor();
            set => JavaObject.setAuthor(value);
        }

        public string Keywords
        {
            get => JavaObject.getKeywords();
            set => JavaObject.setKeywords(value);
        }

        public string CurrencySymbol
        {
            get => JavaObject.getCurrencySymbol();
            set => JavaObject.setCurrencySymbol(value);
        }

        public CurrencySymbolPosition? SymbolPosition
        {
            get => JavaObject.getSymbolPosition().ConvertType();
            set => JavaObject.setSymbolPosition(value.ConvertType());
        }

        public int? CurrencyDigits
        {
            get => JavaObject.getCurrencyDigits().ConvertType();
            set => JavaObject.setCurrencyDigits(value.ConvertType());
        }

        public char ThousandsSeparator
        {
            get => JavaObject.getThousandsSeparator();
            set => JavaObject.setThousandsSeparator(value);
        }

        public char DecimalSeparator
        {
            get => JavaObject.getDecimalSeparator();
            set => JavaObject.setDecimalSeparator(value);
        }

        public bool ProjectExternallyEdited
        {
            get => JavaObject.getProjectExternallyEdited();
            set => JavaObject.setProjectExternallyEdited(value);
        }

        public string Category
        {
            get => JavaObject.getCategory();
            set => JavaObject.setCategory(value);
        }

        public int? DaysPerMonth
        {
            get => JavaObject.getDaysPerMonth().ConvertType();
            set => JavaObject.setDaysPerMonth(value.ConvertType());
        }

        public int? MinutesPerDay
        {
            get => JavaObject.getMinutesPerDay().ConvertType();
            set => JavaObject.setMinutesPerDay(value.ConvertType());
        }

        public int? MinutesPerWeek
        {
            get => JavaObject.getMinutesPerWeek().ConvertType();
            set => JavaObject.setMinutesPerWeek(value.ConvertType());
        }

        public int? MinutesPerMonth
        {
            get => JavaObject.getMinutesPerMonth().ConvertType();
            set => JavaObject.setMinutesPerMonth(value.ConvertType());
        }

        public int? MinutesPerYear
        {
            get => JavaObject.getMinutesPerYear().ConvertType();
            set => JavaObject.setMinutesPerYear(value.ConvertType());
        }

        public bool FiscalYearStart
        {
            get => JavaObject.getFiscalYearStart();
            set => JavaObject.setFiscalYearStart(value);
        }

        public EarnedValueMethod? DefaultTaskEarnedValueMethod
        {
            get => JavaObject.getDefaultTaskEarnedValueMethod().ConvertType();
            set => JavaObject.setDefaultTaskEarnedValueMethod(value.ConvertType());
        }

        public bool RemoveFileProperties
        {
            get => JavaObject.getRemoveFileProperties();
            set => JavaObject.setRemoveFileProperties(value);
        }

        public bool MoveCompletedEndsBack
        {
            get => JavaObject.getMoveCompletedEndsBack();
            set => JavaObject.setMoveCompletedEndsBack(value);
        }

        public bool NewTasksEstimated
        {
            get => JavaObject.getNewTasksEstimated();
            set => JavaObject.setNewTasksEstimated(value);
        }

        public bool SpreadActualCost
        {
            get => JavaObject.getSpreadActualCost();
            set => JavaObject.setSpreadActualCost(value);
        }

        public bool MultipleCriticalPaths
        {
            get => JavaObject.getMultipleCriticalPaths();
            set => JavaObject.setMultipleCriticalPaths(value);
        }

        public bool AutoAddNewResourcesAndTasks
        {
            get => JavaObject.getAutoAddNewResourcesAndTasks();
            set => JavaObject.setAutoAddNewResourcesAndTasks(value);
        }

        public DateTime? LastSaved
        {
            get => JavaObject.getLastSaved().ConvertType();
            set => JavaObject.setLastSaved(value.ConvertType());
        }

        public DateTime? StatusDate
        {
            get => JavaObject.getStatusDate().ConvertType();
            set => JavaObject.setStatusDate(value.ConvertType());
        }

        public bool MoveRemainingStartsBack
        {
            get => JavaObject.getMoveRemainingStartsBack();
            set => JavaObject.setMoveRemainingStartsBack(value);
        }

        public bool Autolink
        {
            get => JavaObject.getAutolink();
            set => JavaObject.setAutolink(value);
        }

        public bool MicrosoftProjectServerURL
        {
            get => JavaObject.getMicrosoftProjectServerURL();
            set => JavaObject.setMicrosoftProjectServerURL(value);
        }

        public bool HonorConstraints
        {
            get => JavaObject.getHonorConstraints();
            set => JavaObject.setHonorConstraints(value);
        }

        public bool AdminProject
        {
            get => JavaObject.getAdminProject();
            set => JavaObject.setAdminProject(value);
        }

        public bool InsertedProjectsLikeSummary
        {
            get => JavaObject.getInsertedProjectsLikeSummary();
            set => JavaObject.setInsertedProjectsLikeSummary(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public bool SpreadPercentComplete
        {
            get => JavaObject.getSpreadPercentComplete();
            set => JavaObject.setSpreadPercentComplete(value);
        }

        public bool MoveCompletedEndsForward
        {
            get => JavaObject.getMoveCompletedEndsForward();
            set => JavaObject.setMoveCompletedEndsForward(value);
        }

        public bool EditableActualCosts
        {
            get => JavaObject.getEditableActualCosts();
            set => JavaObject.setEditableActualCosts(value);
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public int? Revision
        {
            get => JavaObject.getRevision().ConvertType();
            set => JavaObject.setRevision(value.ConvertType());
        }

        public bool NewTasksEffortDriven
        {
            get => JavaObject.getNewTasksEffortDriven();
            set => JavaObject.setNewTasksEffortDriven(value);
        }

        public bool MoveRemainingStartsForward
        {
            get => JavaObject.getMoveRemainingStartsForward();
            set => JavaObject.setMoveRemainingStartsForward(value);
        }

        public bool ActualsInSync
        {
            get => JavaObject.getActualsInSync();
            set => JavaObject.setActualsInSync(value);
        }

        public TaskType? DefaultTaskType
        {
            get => JavaObject.getDefaultTaskType().ConvertType();
            set => JavaObject.setDefaultTaskType(value.ConvertType());
        }

        public EarnedValueMethod? EarnedValueMethod
        {
            get => JavaObject.getEarnedValueMethod().ConvertType();
            set => JavaObject.setEarnedValueMethod(value.ConvertType());
        }

        public DateTime? CreationDate
        {
            get => JavaObject.getCreationDate().ConvertType();
            set => JavaObject.setCreationDate(value.ConvertType());
        }

        public DateTime? ExtendedCreationDate
        {
            get => JavaObject.getExtendedCreationDate().ConvertType();
            set => JavaObject.setExtendedCreationDate(value.ConvertType());
        }

        public AccrueType? DefaultFixedCostAccrual
        {
            get => JavaObject.getDefaultFixedCostAccrual().ConvertType();
            set => JavaObject.setDefaultFixedCostAccrual(value.ConvertType());
        }

        public Duration CriticalSlackLimit
        {
            get => _proxyManager.ProxyObject(JavaObject.getCriticalSlackLimit());
            set => JavaObject.setCriticalSlackLimit(value.JavaObject);
        }

        public int? BaselineForEarnedValue
        {
            get => JavaObject.getBaselineForEarnedValue().ConvertType();
            set => JavaObject.setBaselineForEarnedValue(value.ConvertType());
        }

        public int? FiscalYearStartMonth
        {
            get => JavaObject.getFiscalYearStartMonth().ConvertType();
            set => JavaObject.setFiscalYearStartMonth(value.ConvertType());
        }

        public bool NewTaskStartIsProjectStart
        {
            get => JavaObject.getNewTaskStartIsProjectStart();
            set => JavaObject.setNewTaskStartIsProjectStart(value);
        }

        public bool NewTasksAreManual
        {
            get => JavaObject.getNewTasksAreManual();
            set => JavaObject.setNewTasksAreManual(value);
        }

        public java.time.DayOfWeek WeekStartDay
        {
            get => JavaObject.getWeekStartDay();
            set => JavaObject.setWeekStartDay(value);
        }

        public string CurrencyCode
        {
            get => JavaObject.getCurrencyCode();
            set => JavaObject.setCurrencyCode(value);
        }

        public IDictionary<string, object> CustomProperties => _proxyManager.ProxyDictionary<string, object, string, object>(k => k, k => k, v => _proxyManager.GenericProxyObject(v), v => v.GenericJavaObject(), JavaObject.getCustomProperties());

        public string HyperlinkBase
        {
            get => JavaObject.getHyperlinkBase();
            set => JavaObject.setHyperlinkBase(value);
        }

        public bool ShowProjectSummaryTask
        {
            get => JavaObject.getShowProjectSummaryTask();
            set => JavaObject.setShowProjectSummaryTask(value);
        }

        public DateTime? BaselineDate
        {
            get => JavaObject.getBaselineDate().ConvertType();
            set => JavaObject.setBaselineDate(value.ConvertType());
        }

        public DateTime? GetBaselineDate(int baselineNumber) => JavaObject.getBaselineDate(baselineNumber).ConvertType();

        public void SetBaselineDate(int baselineNumber, DateTime date) => JavaObject.setBaselineDate(baselineNumber, date.ConvertType());

        public string Template
        {
            get => JavaObject.getTemplate();
            set => JavaObject.setTemplate(value);
        }

        public string LastAuthor
        {
            get => JavaObject.getLastAuthor();
            set => JavaObject.setLastAuthor(value);
        }

        public DateTime? LastPrinted
        {
            get => JavaObject.getLastPrinted().ConvertType();
            set => JavaObject.setLastPrinted(value.ConvertType());
        }

        public string ShortApplicationName
        {
            get => JavaObject.getShortApplicationName();
            set => JavaObject.setShortApplicationName(value);
        }

        public int? EditingTime
        {
            get => JavaObject.getEditingTime().ConvertType();
            set => JavaObject.setEditingTime(value.ConvertType());
        }

        public string PresentationFormat
        {
            get => JavaObject.getPresentationFormat();
            set => JavaObject.setPresentationFormat(value);
        }

        public string ContentType
        {
            get => JavaObject.getContentType();
            set => JavaObject.setContentType(value);
        }

        public string ContentStatus
        {
            get => JavaObject.getContentStatus();
            set => JavaObject.setContentStatus(value);
        }

        public string Language
        {
            get => JavaObject.getLanguage();
            set => JavaObject.setLanguage(value);
        }

        public string DocumentVersion
        {
            get => JavaObject.getDocumentVersion();
            set => JavaObject.setDocumentVersion(value);
        }

        public char MpxDelimiter
        {
            get => JavaObject.getMpxDelimiter();
            set => JavaObject.setMpxDelimiter(value);
        }

        public string MpxProgramName
        {
            get => JavaObject.getMpxProgramName();
            set => JavaObject.setMpxProgramName(value);
        }

        public FileVersion? MpxFileVersion
        {
            get => JavaObject.getMpxFileVersion().ConvertType();
            set => JavaObject.setMpxFileVersion(value.ConvertType());
        }

        public CodePage? MpxCodePage
        {
            get => JavaObject.getMpxCodePage().ConvertType();
            set => JavaObject.setMpxCodePage(value.ConvertType());
        }

        public string ProjectFilePath
        {
            get => JavaObject.getProjectFilePath();
            set => JavaObject.setProjectFilePath(value);
        }

        public string FullApplicationName
        {
            get => JavaObject.getFullApplicationName();
            set => JavaObject.setFullApplicationName(value);
        }

        public int? ApplicationVersion
        {
            get => JavaObject.getApplicationVersion().ConvertType();
            set => JavaObject.setApplicationVersion(value.ConvertType());
        }

        public int? MppFileType
        {
            get => JavaObject.getMppFileType().ConvertType();
            set => JavaObject.setMppFileType(value.ConvertType());
        }

        public bool AutoFilter
        {
            get => JavaObject.getAutoFilter();
            set => JavaObject.setAutoFilter(value);
        }

        public string FileApplication
        {
            get => JavaObject.getFileApplication();
            set => JavaObject.setFileApplication(value);
        }

        public string FileType
        {
            get => JavaObject.getFileType();
            set => JavaObject.setFileType(value);
        }

        public bool ExportFlag
        {
            get => JavaObject.getExportFlag();
            set => JavaObject.setExportFlag(value);
        }

        public int? BaselineProjectUniqueID
        {
            get => JavaObject.getBaselineProjectUniqueID().ConvertType();
            set => JavaObject.setBaselineProjectUniqueID(value.ConvertType());
        }

        public string ProjectID
        {
            get => JavaObject.getProjectID();
            set => JavaObject.setProjectID(value);
        }

        public CriticalActivityType? CriticalActivityType
        {
            get => JavaObject.getCriticalActivityType().ConvertType();
            set => JavaObject.setCriticalActivityType(value.ConvertType());
        }

        public DateTime? MustFinishBy
        {
            get => JavaObject.getMustFinishBy().ConvertType();
            set => JavaObject.setMustFinishBy(value.ConvertType());
        }

        public DateTime? ScheduledFinish
        {
            get => JavaObject.getScheduledFinish().ConvertType();
            set => JavaObject.setScheduledFinish(value.ConvertType());
        }

        public DateTime? PlannedStart
        {
            get => JavaObject.getPlannedStart().ConvertType();
            set => JavaObject.setPlannedStart(value.ConvertType());
        }

        public int? LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID().ConvertType();
            set => JavaObject.setLocationUniqueID(value.ConvertType());
        }

        public Location Location
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocation());
            set => JavaObject.setLocation(value.JavaObject);
        }

        public string ResourcePoolFile
        {
            get => JavaObject.getResourcePoolFile();
            set => JavaObject.setResourcePoolFile(value);
        }

        public ProjectFile ResourcePoolObject => new ProjectFile(JavaObject.getResourcePoolObject());

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (net.sf.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());
    }
}
