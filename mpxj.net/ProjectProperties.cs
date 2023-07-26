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

        public java.time.LocalTime DefaultStartTime
        {
            get => JavaObject.getDefaultStartTime();
            set => JavaObject.setDefaultStartTime(value);
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

        public java.time.LocalTime DefaultEndTime
        {
            get => JavaObject.getDefaultEndTime();
            set => JavaObject.setDefaultEndTime(value);
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

        public java.lang.Integer DefaultCalendarUniqueID
        {
            get => JavaObject.getDefaultCalendarUniqueID();
            set => JavaObject.setDefaultCalendarUniqueID(value);
        }

        public ProjectCalendar DefaultCalendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultCalendar());
            set => JavaObject.setDefaultCalendar(value.JavaObject);
        }

        public java.time.LocalDateTime StartDate
        {
            get => JavaObject.getStartDate();
            set => JavaObject.setStartDate(value);
        }

        public java.time.LocalDateTime FinishDate
        {
            get => JavaObject.getFinishDate();
            set => JavaObject.setFinishDate(value);
        }

        public ScheduleFrom? ScheduleFrom
        {
            get => JavaObject.getScheduleFrom().ConvertType();
            set => JavaObject.setScheduleFrom(value.ConvertType());
        }

        public java.time.LocalDateTime CurrentDate
        {
            get => JavaObject.getCurrentDate();
            set => JavaObject.setCurrentDate(value);
        }

        public string Comments
        {
            get => JavaObject.getComments();
            set => JavaObject.setComments(value);
        }

        public java.lang.Number Cost
        {
            get => JavaObject.getCost();
            set => JavaObject.setCost(value);
        }

        public java.lang.Number BaselineCost
        {
            get => JavaObject.getBaselineCost();
            set => JavaObject.setBaselineCost(value);
        }

        public java.lang.Number ActualCost
        {
            get => JavaObject.getActualCost();
            set => JavaObject.setActualCost(value);
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

        public java.lang.Number Work2
        {
            get => JavaObject.getWork2();
            set => JavaObject.setWork2(value);
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

        public java.lang.Number PercentageComplete
        {
            get => JavaObject.getPercentageComplete();
            set => JavaObject.setPercentageComplete(value);
        }

        public java.time.LocalDateTime BaselineStart
        {
            get => JavaObject.getBaselineStart();
            set => JavaObject.setBaselineStart(value);
        }

        public java.time.LocalDateTime BaselineFinish
        {
            get => JavaObject.getBaselineFinish();
            set => JavaObject.setBaselineFinish(value);
        }

        public java.time.LocalDateTime ActualStart
        {
            get => JavaObject.getActualStart();
            set => JavaObject.setActualStart(value);
        }

        public java.time.LocalDateTime ActualFinish
        {
            get => JavaObject.getActualFinish();
            set => JavaObject.setActualFinish(value);
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

        public java.lang.Integer CurrencyDigits
        {
            get => JavaObject.getCurrencyDigits();
            set => JavaObject.setCurrencyDigits(value);
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

        public java.lang.Integer DaysPerMonth
        {
            get => JavaObject.getDaysPerMonth();
            set => JavaObject.setDaysPerMonth(value);
        }

        public java.lang.Integer MinutesPerDay
        {
            get => JavaObject.getMinutesPerDay();
            set => JavaObject.setMinutesPerDay(value);
        }

        public java.lang.Integer MinutesPerWeek
        {
            get => JavaObject.getMinutesPerWeek();
            set => JavaObject.setMinutesPerWeek(value);
        }

        public java.lang.Integer MinutesPerMonth
        {
            get => JavaObject.getMinutesPerMonth();
            set => JavaObject.setMinutesPerMonth(value);
        }

        public java.lang.Integer MinutesPerYear
        {
            get => JavaObject.getMinutesPerYear();
            set => JavaObject.setMinutesPerYear(value);
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

        public java.time.LocalDateTime LastSaved
        {
            get => JavaObject.getLastSaved();
            set => JavaObject.setLastSaved(value);
        }

        public java.time.LocalDateTime StatusDate
        {
            get => JavaObject.getStatusDate();
            set => JavaObject.setStatusDate(value);
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

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().FromJava();
            set => JavaObject.setGUID(value.ToJava());
        }

        public java.lang.Integer Revision
        {
            get => JavaObject.getRevision();
            set => JavaObject.setRevision(value);
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

        public java.time.LocalDateTime CreationDate
        {
            get => JavaObject.getCreationDate();
            set => JavaObject.setCreationDate(value);
        }

        public java.time.LocalDateTime ExtendedCreationDate
        {
            get => JavaObject.getExtendedCreationDate();
            set => JavaObject.setExtendedCreationDate(value);
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

        public java.lang.Integer BaselineForEarnedValue
        {
            get => JavaObject.getBaselineForEarnedValue();
            set => JavaObject.setBaselineForEarnedValue(value);
        }

        public java.lang.Integer FiscalYearStartMonth
        {
            get => JavaObject.getFiscalYearStartMonth();
            set => JavaObject.setFiscalYearStartMonth(value);
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

        // TODO: inverse of proxy to allow values to be written back
        public IDictionary<string, object> CustomProperties => _proxyManager.ProxyDictionary<string, object, string, object>(k => k, k => k, v => _proxyManager.GenericProxyObject(v), v => v, JavaObject.getCustomProperties());

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

        public java.time.LocalDateTime BaselineDate
        {
            get => JavaObject.getBaselineDate();
            set => JavaObject.setBaselineDate(value);
        }

        public java.time.LocalDateTime GetBaselineDate(int baselineNumber) => JavaObject.getBaselineDate(baselineNumber);

        public void SetBaselineDate(int baselineNumber, java.time.LocalDateTime date) => JavaObject.setBaselineDate(baselineNumber, date);

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

        public java.time.LocalDateTime LastPrinted
        {
            get => JavaObject.getLastPrinted();
            set => JavaObject.setLastPrinted(value);
        }

        public string ShortApplicationName
        {
            get => JavaObject.getShortApplicationName();
            set => JavaObject.setShortApplicationName(value);
        }

        public java.lang.Integer EditingTime
        {
            get => JavaObject.getEditingTime();
            set => JavaObject.setEditingTime(value);
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

        public java.lang.Integer ApplicationVersion
        {
            get => JavaObject.getApplicationVersion();
            set => JavaObject.setApplicationVersion(value);
        }

        public java.lang.Integer MppFileType
        {
            get => JavaObject.getMppFileType();
            set => JavaObject.setMppFileType(value);
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

        public java.lang.Integer BaselineProjectUniqueID
        {
            get => JavaObject.getBaselineProjectUniqueID();
            set => JavaObject.setBaselineProjectUniqueID(value);
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

        public java.time.LocalDateTime MustFinishBy
        {
            get => JavaObject.getMustFinishBy();
            set => JavaObject.setMustFinishBy(value);
        }

        public java.time.LocalDateTime ScheduledFinish
        {
            get => JavaObject.getScheduledFinish();
            set => JavaObject.setScheduledFinish(value);
        }

        public java.time.LocalDateTime PlannedStart
        {
            get => JavaObject.getPlannedStart();
            set => JavaObject.setPlannedStart(value);
        }

        public java.lang.Integer LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID();
            set => JavaObject.setLocationUniqueID(value);
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

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields => ProxyManager.ProxySet<IFieldType, IFieldType>(JavaObject.getPopulatedFields());
    }
}
