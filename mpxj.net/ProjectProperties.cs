using java.util;

namespace org.mpxj
{
    public class ProjectProperties
    {
        internal readonly ProjectFile _projectFile;
        internal readonly net.sf.mpxj.ProjectProperties _proxy;

        internal ProjectProperties(ProjectFile projectFile, net.sf.mpxj.ProjectProperties proxy)
        {
            _projectFile = projectFile;
            _proxy = proxy;
        }

        public net.sf.mpxj.TimeUnit DefaultDurationUnits
        {
            get => _proxy.getDefaultDurationUnits();
            set => _proxy.setDefaultDurationUnits(value);
        }

        public bool DefaultDurationIsFixed
        {
            get => _proxy.getDefaultDurationIsFixed();
            set => _proxy.setDefaultDurationIsFixed(value);
        }

        public net.sf.mpxj.TimeUnit DefaultWorkUnits
        {
            get => _proxy.getDefaultWorkUnits();
            set => _proxy.setDefaultWorkUnits(value);
        }

        public net.sf.mpxj.Rate DefaultStandardRate
        {
            get => _proxy.getDefaultStandardRate();
            set => _proxy.setDefaultStandardRate(value);
        }

        public net.sf.mpxj.Rate DefaultOvertimeRate
        {
            get => _proxy.getDefaultOvertimeRate();
            set => _proxy.setDefaultOvertimeRate(value);
        }

        public bool UpdatingTaskStatusUpdatesResourceStatus
        {
            get => _proxy.getUpdatingTaskStatusUpdatesResourceStatus();
            set => _proxy.setUpdatingTaskStatusUpdatesResourceStatus(value);
        }

        public bool SplitInProgressTasks
        {
            get => _proxy.getSplitInProgressTasks();
            set => _proxy.setSplitInProgressTasks(value);
        }

        public net.sf.mpxj.DateOrder DateOrder
        {
            get => _proxy.getDateOrder();
            set => _proxy.setDateOrder(value);
        }


        public net.sf.mpxj.ProjectTimeFormat TimeFormat
        {
            get => _proxy.getTimeFormat();
            set => _proxy.setTimeFormat(value);
        }

        public java.time.LocalTime DefaultStartTime
        {
            get => _proxy.getDefaultStartTime();
            set => _proxy.setDefaultStartTime(value);
        }

        public char DateSeparator
        {
            get => _proxy.getDateSeparator();
            set => _proxy.setDateSeparator(value);
        }

        public char TimeSeparator
        {
            get => _proxy.getTimeSeparator();
            set => _proxy.setTimeSeparator(value);
        }

        public string AMText
        {
            get => _proxy.getAMText();
            set => _proxy.setAMText(value);
        }

        public string PMText
        {
            get => _proxy.getPMText();
            set => _proxy.setPMText(value);
        }

        public net.sf.mpxj.ProjectDateFormat DateFormat
        {
            get => _proxy.getDateFormat();
            set => _proxy.setDateFormat(value);
        }

        public net.sf.mpxj.ProjectDateFormat BarTextDateFormat
        {
            get => _proxy.getBarTextDateFormat();
            set => _proxy.setBarTextDateFormat(value);
        }

        public java.time.LocalTime DefaultEndTime
        {
            get => _proxy.getDefaultEndTime();
            set => _proxy.setDefaultEndTime(value);
        }

        public string ProjectTitle
        {
            get => _proxy.getProjectTitle();
            set => _proxy.setProjectTitle(value);
        }

        public string Company
        {
            get => _proxy.getCompany();
            set => _proxy.setCompany(value);
        }

        public string Manager
        {
            get => _proxy.getManager();
            set => _proxy.setManager(value);
        }

        public java.lang.Integer DefaultCalendarUniqueID
        {
            get => _proxy.getDefaultCalendarUniqueID();
            set => _proxy.setDefaultCalendarUniqueID(value);
        }

        public ProjectCalendar DefaultCalendar
        {
            get => _projectFile.ProxyObject(_proxy.getDefaultCalendar());
            set => _proxy.setDefaultCalendar(value._proxy);
        }

        public java.time.LocalDateTime StartDate
        {
            get => _proxy.getStartDate();
            set => _proxy.setStartDate(value);
        }

        public java.time.LocalDateTime FinishDate
        {
            get => _proxy.getFinishDate();
            set => _proxy.setFinishDate(value);
        }

        public net.sf.mpxj.ScheduleFrom ScheduleFrom
        {
            get => _proxy.getScheduleFrom();
            set => _proxy.setScheduleFrom(value);
        }

        public java.time.LocalDateTime CurrentDate
        {
            get => _proxy.getCurrentDate();
            set => _proxy.setCurrentDate(value);
        }

        public string Comments
        {
            get => _proxy.getComments();
            set => _proxy.setComments(value);
        }

        public java.lang.Number Cost
        {
            get => _proxy.getCost();
            set => _proxy.setCost(value);
        }

        public java.lang.Number BaselineCost
        {
            get => _proxy.getBaselineCost();
            set => _proxy.setBaselineCost(value);
        }

        public java.lang.Number ActualCost
        {
            get => _proxy.getActualCost();
            set => _proxy.setActualCost(value);
        }

        public net.sf.mpxj.Duration Work
        {
            get => _proxy.getWork();
            set => _proxy.setWork(value);
        }

        public net.sf.mpxj.Duration BaselineWork
        {
            get => _proxy.getBaselineWork();
            set => _proxy.setBaselineWork(value);
        }

        public net.sf.mpxj.Duration ActualWork
        {
            get => _proxy.getActualWork();
            set => _proxy.setActualWork(value);
        }

        public java.lang.Number Work2
        {
            get => _proxy.getWork2();
            set => _proxy.setWork2(value);
        }

        public net.sf.mpxj.Duration Duration
        {
            get => _proxy.getDuration();
            set => _proxy.setDuration(value);
        }

        public net.sf.mpxj.Duration BaselineDuration
        {
            get => _proxy.getBaselineDuration();
            set => _proxy.setBaselineDuration(value);
        }

        public net.sf.mpxj.Duration ActualDuration
        {
            get => _proxy.getActualDuration();
            set => _proxy.setActualDuration(value);
        }

        public java.lang.Number PercentageComplete
        {
            get => _proxy.getPercentageComplete();
            set => _proxy.setPercentageComplete(value);
        }

        public java.time.LocalDateTime BaselineStart
        {
            get => _proxy.getBaselineStart();
            set => _proxy.setBaselineStart(value);
        }

        public java.time.LocalDateTime BaselineFinish
        {
            get => _proxy.getBaselineFinish();
            set => _proxy.setBaselineFinish(value);
        }

        public java.time.LocalDateTime ActualStart
        {
            get => _proxy.getActualStart();
            set => _proxy.setActualStart(value);
        }

        public java.time.LocalDateTime ActualFinish
        {
            get => _proxy.getActualFinish();
            set => _proxy.setActualFinish(value);
        }

        public net.sf.mpxj.Duration StartVariance
        {
            get => _proxy.getStartVariance();
            set => _proxy.setStartVariance(value);
        }

        public net.sf.mpxj.Duration FinishVariance
        {
            get => _proxy.getFinishVariance();
            set => _proxy.setFinishVariance(value);
        }

        public string Subject
        {
            get => _proxy.getSubject();
            set => _proxy.setSubject(value);
        }

        public string Author
        {
            get => _proxy.getAuthor();
            set => _proxy.setAuthor(value);
        }

        public string Keywords
        {
            get => _proxy.getKeywords();
            set => _proxy.setKeywords(value);
        }

        public string CurrencySymbol
        {
            get => _proxy.getCurrencySymbol();
            set => _proxy.setCurrencySymbol(value);
        }

        public net.sf.mpxj.CurrencySymbolPosition SymbolPosition
        {
            get => _proxy.getSymbolPosition();
            set => _proxy.setSymbolPosition(value);
        }

        public java.lang.Integer CurrencyDigits
        {
            get => _proxy.getCurrencyDigits();
            set => _proxy.setCurrencyDigits(value);
        }

        public char ThousandsSeparator
        {
            get => _proxy.getThousandsSeparator();
            set => _proxy.setThousandsSeparator(value);
        }

        public char DecimalSeparator
        {
            get => _proxy.getDecimalSeparator();
            set => _proxy.setDecimalSeparator(value);
        }

        public bool ProjectExternallyEdited
        {
            get => _proxy.getProjectExternallyEdited();
            set => _proxy.setProjectExternallyEdited(value);
        }

        public string Category
        {
            get => _proxy.getCategory();
            set => _proxy.setCategory(value);
        }

        public java.lang.Integer DaysPerMonth
        {
            get => _proxy.getDaysPerMonth();
            set => _proxy.setDaysPerMonth(value);
        }

        public java.lang.Integer MinutesPerDay
        {
            get => _proxy.getMinutesPerDay();
            set => _proxy.setMinutesPerDay(value);
        }

        public java.lang.Integer MinutesPerWeek
        {
            get => _proxy.getMinutesPerWeek();
            set => _proxy.setMinutesPerWeek(value);
        }

        public java.lang.Integer MinutesPerMonth
        {
            get => _proxy.getMinutesPerMonth();
            set => _proxy.setMinutesPerMonth(value);
        }

        public java.lang.Integer MinutesPerYear
        {
            get => _proxy.getMinutesPerYear();
            set => _proxy.setMinutesPerYear(value);
        }

        public bool FiscalYearStart
        {
            get => _proxy.getFiscalYearStart();
            set => _proxy.setFiscalYearStart(value);
        }

        public net.sf.mpxj.EarnedValueMethod DefaultTaskEarnedValueMethod
        {
            get => _proxy.getDefaultTaskEarnedValueMethod();
            set => _proxy.setDefaultTaskEarnedValueMethod(value);
        }

        public bool RemoveFileProperties
        {
            get => _proxy.getRemoveFileProperties();
            set => _proxy.setRemoveFileProperties(value);
        }

        public bool MoveCompletedEndsBack
        {
            get => _proxy.getMoveCompletedEndsBack();
            set => _proxy.setMoveCompletedEndsBack(value);
        }

        public bool NewTasksEstimated
        {
            get => _proxy.getNewTasksEstimated();
            set => _proxy.setNewTasksEstimated(value);
        }

        public bool SpreadActualCost
        {
            get => _proxy.getSpreadActualCost();
            set => _proxy.setSpreadActualCost(value);
        }

        public bool MultipleCriticalPaths
        {
            get => _proxy.getMultipleCriticalPaths();
            set => _proxy.setMultipleCriticalPaths(value);
        }

        public bool AutoAddNewResourcesAndTasks
        {
            get => _proxy.getAutoAddNewResourcesAndTasks();
            set => _proxy.setAutoAddNewResourcesAndTasks(value);
        }

        public java.time.LocalDateTime LastSaved
        {
            get => _proxy.getLastSaved();
            set => _proxy.setLastSaved(value);
        }

        public java.time.LocalDateTime StatusDate
        {
            get => _proxy.getStatusDate();
            set => _proxy.setStatusDate(value);
        }

        public bool MoveRemainingStartsBack
        {
            get => _proxy.getMoveRemainingStartsBack();
            set => _proxy.setMoveRemainingStartsBack(value);
        }

        public bool Autolink
        {
            get => _proxy.getAutolink();
            set => _proxy.setAutolink(value);
        }

        public bool MicrosoftProjectServerURL
        {
            get => _proxy.getMicrosoftProjectServerURL();
            set => _proxy.setMicrosoftProjectServerURL(value);
        }

        public bool HonorConstraints
        {
            get => _proxy.getHonorConstraints();
            set => _proxy.setHonorConstraints(value);
        }

        public bool AdminProject
        {
            get => _proxy.getAdminProject();
            set => _proxy.setAdminProject(value);
        }

        public bool InsertedProjectsLikeSummary
        {
            get => _proxy.getInsertedProjectsLikeSummary();
            set => _proxy.setInsertedProjectsLikeSummary(value);
        }

        public string Name
        {
            get => _proxy.getName();
            set => _proxy.setName(value);
        }

        public bool SpreadPercentComplete
        {
            get => _proxy.getSpreadPercentComplete();
            set => _proxy.setSpreadPercentComplete(value);
        }

        public bool MoveCompletedEndsForward
        {
            get => _proxy.getMoveCompletedEndsForward();
            set => _proxy.setMoveCompletedEndsForward(value);
        }

        public bool EditableActualCosts
        {
            get => _proxy.getEditableActualCosts();
            set => _proxy.setEditableActualCosts(value);
        }

        public java.lang.Integer UniqueID
        {
            get => _proxy.getUniqueID();
            set => _proxy.setUniqueID(value);
        }

        public UUID GUID
        {
            get => _proxy.getGUID();
            set => _proxy.setGUID(value);
        }

        public java.lang.Integer Revision
        {
            get => _proxy.getRevision();
            set => _proxy.setRevision(value);
        }

        public bool NewTasksEffortDriven
        {
            get => _proxy.getNewTasksEffortDriven();
            set => _proxy.setNewTasksEffortDriven(value);
        }

        public bool MoveRemainingStartsForward
        {
            get => _proxy.getMoveRemainingStartsForward();
            set => _proxy.setMoveRemainingStartsForward(value);
        }

        public bool ActualsInSync
        {
            get => _proxy.getActualsInSync();
            set => _proxy.setActualsInSync(value);
        }

        public net.sf.mpxj.TaskType DefaultTaskType
        {
            get => _proxy.getDefaultTaskType();
            set => _proxy.setDefaultTaskType(value);
        }

        public net.sf.mpxj.EarnedValueMethod EarnedValueMethod
        {
            get => _proxy.getEarnedValueMethod();
            set => _proxy.setEarnedValueMethod(value);
        }

        public java.time.LocalDateTime CreationDate
        {
            get => _proxy.getCreationDate();
            set => _proxy.setCreationDate(value);
        }

        public java.time.LocalDateTime ExtendedCreationDate
        {
            get => _proxy.getExtendedCreationDate();
            set => _proxy.setExtendedCreationDate(value);
        }

        public net.sf.mpxj.AccrueType DefaultFixedCostAccrual
        {
            get => _proxy.getDefaultFixedCostAccrual();
            set => _proxy.setDefaultFixedCostAccrual(value);
        }

        public net.sf.mpxj.Duration CriticalSlackLimit
        {
            get => _proxy.getCriticalSlackLimit();
            set => _proxy.setCriticalSlackLimit(value);
        }

        public java.lang.Integer BaselineForEarnedValue
        {
            get => _proxy.getBaselineForEarnedValue();
            set => _proxy.setBaselineForEarnedValue(value);
        }

        public java.lang.Integer FiscalYearStartMonth
        {
            get => _proxy.getFiscalYearStartMonth();
            set => _proxy.setFiscalYearStartMonth(value);
        }

        public bool NewTaskStartIsProjectStart
        {
            get => _proxy.getNewTaskStartIsProjectStart();
            set => _proxy.setNewTaskStartIsProjectStart(value);
        }

        public bool NewTasksAreManual
        {
            get => _proxy.getNewTasksAreManual();
            set => _proxy.setNewTasksAreManual(value);
        }

        public java.time.DayOfWeek WeekStartDay
        {
            get => _proxy.getWeekStartDay();
            set => _proxy.setWeekStartDay(value);
        }

        public string CurrencyCode
        {
            get => _proxy.getCurrencyCode();
            set => _proxy.setCurrencyCode(value);
        }

        public java.util.Map CustomProperties
        {
            get => _proxy.getCustomProperties();
        }

        public string HyperlinkBase
        {
            get => _proxy.getHyperlinkBase();
            set => _proxy.setHyperlinkBase(value);
        }

        public bool ShowProjectSummaryTask
        {
            get => _proxy.getShowProjectSummaryTask();
            set => _proxy.setShowProjectSummaryTask(value);
        }

        public java.time.LocalDateTime BaselineDate
        {
            get => _proxy.getBaselineDate();
            set => _proxy.setBaselineDate(value);
        }

        public java.time.LocalDateTime GetBaselineDate(int baselineNumber)
        {
            return _proxy.getBaselineDate(baselineNumber);
        }

        public void SetBaselineDate(int baselineNumber, java.time.LocalDateTime date)
        {
            _proxy.setBaselineDate(baselineNumber, date);
        }

        public string Template
        {
            get => _proxy.getTemplate();
            set => _proxy.setTemplate(value);
        }

        public string LastAuthor
        {
            get => _proxy.getLastAuthor();
            set => _proxy.setLastAuthor(value);
        }

        public java.time.LocalDateTime LastPrinted
        {
            get => _proxy.getLastPrinted();
            set => _proxy.setLastPrinted(value);
        }

        public string ShortApplicationName
        {
            get => _proxy.getShortApplicationName();
            set => _proxy.setShortApplicationName(value);
        }

        public java.lang.Integer EditingTime
        {
            get => _proxy.getEditingTime();
            set => _proxy.setEditingTime(value);
        }

        public string PresentationFormat
        {
            get => _proxy.getPresentationFormat();
            set => _proxy.setPresentationFormat(value);
        }

        public string ContentType
        {
            get => _proxy.getContentType();
            set => _proxy.setContentType(value);
        }

        public string ContentStatus
        {
            get => _proxy.getContentStatus();
            set => _proxy.setContentStatus(value);
        }

        public string Language
        {
            get => _proxy.getLanguage();
            set => _proxy.setLanguage(value);
        }

        public string DocumentVersion
        {
            get => _proxy.getDocumentVersion();
            set => _proxy.setDocumentVersion(value);
        }

        public char MpxDelimiter
        {
            get => _proxy.getMpxDelimiter();
            set => _proxy.setMpxDelimiter(value);
        }

        public string MpxProgramName
        {
            get => _proxy.getMpxProgramName();
            set => _proxy.setMpxProgramName(value);
        }

        public net.sf.mpxj.FileVersion MpxFileVersion
        {
            get => _proxy.getMpxFileVersion();
            set => _proxy.setMpxFileVersion(value);
        }

        public net.sf.mpxj.CodePage MpxCodePage
        {
            get => _proxy.getMpxCodePage();
            set => _proxy.setMpxCodePage(value);
        }

        public string ProjectFilePath
        {
            get => _proxy.getProjectFilePath();
            set => _proxy.setProjectFilePath(value);
        }

        public string FullApplicationName
        {
            get => _proxy.getFullApplicationName();
            set => _proxy.setFullApplicationName(value);
        }

        public java.lang.Integer ApplicationVersion
        {
            get => _proxy.getApplicationVersion();
            set => _proxy.setApplicationVersion(value);
        }

        public java.lang.Integer MppFileType
        {
            get => _proxy.getMppFileType();
            set => _proxy.setMppFileType(value);
        }

        public bool AutoFilter
        {
            get => _proxy.getAutoFilter();
            set => _proxy.setAutoFilter(value);
        }

        public string FileApplication
        {
            get => _proxy.getFileApplication();
            set => _proxy.setFileApplication(value);
        }

        public string FileType
        {
            get => _proxy.getFileType();
            set => _proxy.setFileType(value);
        }

        public bool ExportFlag
        {
            get => _proxy.getExportFlag();
            set => _proxy.setExportFlag(value);
        }

        public java.lang.Integer BaselineProjectUniqueID
        {
            get => _proxy.getBaselineProjectUniqueID();
            set => _proxy.setBaselineProjectUniqueID(value);
        }

        public string ProjectID
        {
            get => _proxy.getProjectID();
            set => _proxy.setProjectID(value);
        }

        public net.sf.mpxj.CriticalActivityType CriticalActivityType
        {
            get => _proxy.getCriticalActivityType();
            set => _proxy.setCriticalActivityType(value);
        }

        public java.time.LocalDateTime MustFinishBy
        {
            get => _proxy.getMustFinishBy();
            set => _proxy.setMustFinishBy(value);
        }

        public java.time.LocalDateTime ScheduledFinish
        {
            get => _proxy.getScheduledFinish();
            set => _proxy.setScheduledFinish(value);
        }

        public java.time.LocalDateTime PlannedStart
        {
            get => _proxy.getPlannedStart();
            set => _proxy.setPlannedStart(value);
        }

        public java.lang.Integer LocationUniqueID
        {
            get => _proxy.getLocationUniqueID();
            set => _proxy.setLocationUniqueID(value);
        }

        public net.sf.mpxj.Location Location
        {
            get => _proxy.getLocation();
            set => _proxy.setLocation(value);
        }

        public string ResourcePoolFile
        {
            get => _proxy.getResourcePoolFile();
            set => _proxy.setResourcePoolFile(value);
        }

        public ProjectFile ResourcePoolObject
        {
            get => new ProjectFile(_proxy.getResourcePoolObject());
        }

        public java.util.Set PopulatedFields
        {
            get => _proxy.getPopulatedFields();
        }
    }
}
