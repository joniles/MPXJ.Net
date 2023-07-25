using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectField : IFieldType, IJavaObjectProxy<net.sf.mpxj.ProjectField>
    {
        public net.sf.mpxj.ProjectField JavaObject { get; }

        public static readonly ProjectField StartDate = CreateField(net.sf.mpxj.ProjectField.START_DATE);
        public static readonly ProjectField CurrencySymbol = CreateField(net.sf.mpxj.ProjectField.CURRENCY_SYMBOL);
        public static readonly ProjectField CurrencySymbolPosition = CreateField(net.sf.mpxj.ProjectField.CURRENCY_SYMBOL_POSITION);
        public static readonly ProjectField CurrencyDigits = CreateField(net.sf.mpxj.ProjectField.CURRENCY_DIGITS);
        public static readonly ProjectField ThousandsSeparator = CreateField(net.sf.mpxj.ProjectField.THOUSANDS_SEPARATOR);
        public static readonly ProjectField DecimalSeparator = CreateField(net.sf.mpxj.ProjectField.DECIMAL_SEPARATOR);
        public static readonly ProjectField DefaultDurationUnits = CreateField(net.sf.mpxj.ProjectField.DEFAULT_DURATION_UNITS);
        public static readonly ProjectField DefaultDurationIsFixed = CreateField(net.sf.mpxj.ProjectField.DEFAULT_DURATION_IS_FIXED);
        public static readonly ProjectField DefaultWorkUnits = CreateField(net.sf.mpxj.ProjectField.DEFAULT_WORK_UNITS);
        public static readonly ProjectField DefaultStandardRate = CreateField(net.sf.mpxj.ProjectField.DEFAULT_STANDARD_RATE);
        public static readonly ProjectField DefaultOvertimeRate = CreateField(net.sf.mpxj.ProjectField.DEFAULT_OVERTIME_RATE);
        public static readonly ProjectField UpdatingTaskStatusUpdatesResourceStatus = CreateField(net.sf.mpxj.ProjectField.UPDATING_TASK_STATUS_UPDATES_RESOURCE_STATUS);
        public static readonly ProjectField SplitInProgressTasks = CreateField(net.sf.mpxj.ProjectField.SPLIT_IN_PROGRESS_TASKS);
        public static readonly ProjectField DateOrder = CreateField(net.sf.mpxj.ProjectField.DATE_ORDER);
        public static readonly ProjectField TimeFormat = CreateField(net.sf.mpxj.ProjectField.TIME_FORMAT);
        public static readonly ProjectField DefaultStartTime = CreateField(net.sf.mpxj.ProjectField.DEFAULT_START_TIME);
        public static readonly ProjectField DateSeparator = CreateField(net.sf.mpxj.ProjectField.DATE_SEPARATOR);
        public static readonly ProjectField TimeSeparator = CreateField(net.sf.mpxj.ProjectField.TIME_SEPARATOR);
        public static readonly ProjectField AmText = CreateField(net.sf.mpxj.ProjectField.AM_TEXT);
        public static readonly ProjectField PmText = CreateField(net.sf.mpxj.ProjectField.PM_TEXT);
        public static readonly ProjectField DateFormat = CreateField(net.sf.mpxj.ProjectField.DATE_FORMAT);
        public static readonly ProjectField BarTextDateFormat = CreateField(net.sf.mpxj.ProjectField.BAR_TEXT_DATE_FORMAT);
        public static readonly ProjectField ProjectTitle = CreateField(net.sf.mpxj.ProjectField.PROJECT_TITLE);
        public static readonly ProjectField Company = CreateField(net.sf.mpxj.ProjectField.COMPANY);
        public static readonly ProjectField Manager = CreateField(net.sf.mpxj.ProjectField.MANAGER);
        public static readonly ProjectField DefaultCalendarUniqueId = CreateField(net.sf.mpxj.ProjectField.DEFAULT_CALENDAR_UNIQUE_ID);
        public static readonly ProjectField ScheduleFrom = CreateField(net.sf.mpxj.ProjectField.SCHEDULE_FROM);
        public static readonly ProjectField CurrentDate = CreateField(net.sf.mpxj.ProjectField.CURRENT_DATE);
        public static readonly ProjectField Comments = CreateField(net.sf.mpxj.ProjectField.COMMENTS);
        public static readonly ProjectField Cost = CreateField(net.sf.mpxj.ProjectField.COST);
        public static readonly ProjectField BaselineCost = CreateField(net.sf.mpxj.ProjectField.BASELINE_COST);
        public static readonly ProjectField ActualCost = CreateField(net.sf.mpxj.ProjectField.ACTUAL_COST);
        public static readonly ProjectField Work = CreateField(net.sf.mpxj.ProjectField.WORK);
        public static readonly ProjectField BaselineWork = CreateField(net.sf.mpxj.ProjectField.BASELINE_WORK);
        public static readonly ProjectField ActualWork = CreateField(net.sf.mpxj.ProjectField.ACTUAL_WORK);
        public static readonly ProjectField Work2 = CreateField(net.sf.mpxj.ProjectField.WORK2);
        public static readonly ProjectField Duration = CreateField(net.sf.mpxj.ProjectField.DURATION);
        public static readonly ProjectField BaselineDuration = CreateField(net.sf.mpxj.ProjectField.BASELINE_DURATION);
        public static readonly ProjectField ActualDuration = CreateField(net.sf.mpxj.ProjectField.ACTUAL_DURATION);
        public static readonly ProjectField PercentageComplete = CreateField(net.sf.mpxj.ProjectField.PERCENTAGE_COMPLETE);
        public static readonly ProjectField BaselineStart = CreateField(net.sf.mpxj.ProjectField.BASELINE_START);
        public static readonly ProjectField BaselineFinish = CreateField(net.sf.mpxj.ProjectField.BASELINE_FINISH);
        public static readonly ProjectField ActualStart = CreateField(net.sf.mpxj.ProjectField.ACTUAL_START);
        public static readonly ProjectField ActualFinish = CreateField(net.sf.mpxj.ProjectField.ACTUAL_FINISH);
        public static readonly ProjectField StartVariance = CreateField(net.sf.mpxj.ProjectField.START_VARIANCE);
        public static readonly ProjectField FinishVariance = CreateField(net.sf.mpxj.ProjectField.FINISH_VARIANCE);
        public static readonly ProjectField Subject = CreateField(net.sf.mpxj.ProjectField.SUBJECT);
        public static readonly ProjectField Author = CreateField(net.sf.mpxj.ProjectField.AUTHOR);
        public static readonly ProjectField Keywords = CreateField(net.sf.mpxj.ProjectField.KEYWORDS);
        public static readonly ProjectField HyperlinkBase = CreateField(net.sf.mpxj.ProjectField.HYPERLINK_BASE);
        public static readonly ProjectField DefaultEndTime = CreateField(net.sf.mpxj.ProjectField.DEFAULT_END_TIME);
        public static readonly ProjectField ProjectExternallyEdited = CreateField(net.sf.mpxj.ProjectField.PROJECT_EXTERNALLY_EDITED);
        public static readonly ProjectField Category = CreateField(net.sf.mpxj.ProjectField.CATEGORY);
        public static readonly ProjectField MinutesPerDay = CreateField(net.sf.mpxj.ProjectField.MINUTES_PER_DAY);
        public static readonly ProjectField DaysPerMonth = CreateField(net.sf.mpxj.ProjectField.DAYS_PER_MONTH);
        public static readonly ProjectField MinutesPerWeek = CreateField(net.sf.mpxj.ProjectField.MINUTES_PER_WEEK);
        public static readonly ProjectField MinutesPerMonth = CreateField(net.sf.mpxj.ProjectField.MINUTES_PER_MONTH);
        public static readonly ProjectField MinutesPerYear = CreateField(net.sf.mpxj.ProjectField.MINUTES_PER_YEAR);
        public static readonly ProjectField FiscalYearStart = CreateField(net.sf.mpxj.ProjectField.FISCAL_YEAR_START);
        public static readonly ProjectField DefaultTaskEarnedValueMethod = CreateField(net.sf.mpxj.ProjectField.DEFAULT_TASK_EARNED_VALUE_METHOD);
        public static readonly ProjectField RemoveFileProperties = CreateField(net.sf.mpxj.ProjectField.REMOVE_FILE_PROPERTIES);
        public static readonly ProjectField MoveCompletedEndsBack = CreateField(net.sf.mpxj.ProjectField.MOVE_COMPLETED_ENDS_BACK);
        public static readonly ProjectField NewTasksEstimated = CreateField(net.sf.mpxj.ProjectField.NEW_TASKS_ESTIMATED);
        public static readonly ProjectField SpreadActualCost = CreateField(net.sf.mpxj.ProjectField.SPREAD_ACTUAL_COST);
        public static readonly ProjectField MultipleCriticalPaths = CreateField(net.sf.mpxj.ProjectField.MULTIPLE_CRITICAL_PATHS);
        public static readonly ProjectField AutoAddNewResourcesAndTasks = CreateField(net.sf.mpxj.ProjectField.AUTO_ADD_NEW_RESOURCES_AND_TASKS);
        public static readonly ProjectField LastSaved = CreateField(net.sf.mpxj.ProjectField.LAST_SAVED);
        public static readonly ProjectField StatusDate = CreateField(net.sf.mpxj.ProjectField.STATUS_DATE);
        public static readonly ProjectField MoveRemainingStartsBack = CreateField(net.sf.mpxj.ProjectField.MOVE_REMAINING_STARTS_BACK);
        public static readonly ProjectField AutoLink = CreateField(net.sf.mpxj.ProjectField.AUTO_LINK);
        public static readonly ProjectField MicrosoftProjectServerUrl = CreateField(net.sf.mpxj.ProjectField.MICROSOFT_PROJECT_SERVER_URL);
        public static readonly ProjectField HonorConstraints = CreateField(net.sf.mpxj.ProjectField.HONOR_CONSTRAINTS);
        public static readonly ProjectField AdminProject = CreateField(net.sf.mpxj.ProjectField.ADMIN_PROJECT);
        public static readonly ProjectField InsertedProjectsLikeSummary = CreateField(net.sf.mpxj.ProjectField.INSERTED_PROJECTS_LIKE_SUMMARY);
        public static readonly ProjectField Name = CreateField(net.sf.mpxj.ProjectField.NAME);
        public static readonly ProjectField SpreadPercentComplete = CreateField(net.sf.mpxj.ProjectField.SPREAD_PERCENT_COMPLETE);
        public static readonly ProjectField MoveCompletedEndsForward = CreateField(net.sf.mpxj.ProjectField.MOVE_COMPLETED_ENDS_FORWARD);
        public static readonly ProjectField EditableActualCosts = CreateField(net.sf.mpxj.ProjectField.EDITABLE_ACTUAL_COSTS);
        public static readonly ProjectField UniqueId = CreateField(net.sf.mpxj.ProjectField.UNIQUE_ID);
        public static readonly ProjectField Revision = CreateField(net.sf.mpxj.ProjectField.REVISION);
        public static readonly ProjectField NewTasksEffortDriven = CreateField(net.sf.mpxj.ProjectField.NEW_TASKS_EFFORT_DRIVEN);
        public static readonly ProjectField MoveRemainingStartsForward = CreateField(net.sf.mpxj.ProjectField.MOVE_REMAINING_STARTS_FORWARD);
        public static readonly ProjectField ActualsInSync = CreateField(net.sf.mpxj.ProjectField.ACTUALS_IN_SYNC);
        public static readonly ProjectField DefaultTaskType = CreateField(net.sf.mpxj.ProjectField.DEFAULT_TASK_TYPE);
        public static readonly ProjectField EarnedValueMethod = CreateField(net.sf.mpxj.ProjectField.EARNED_VALUE_METHOD);
        public static readonly ProjectField CreationDate = CreateField(net.sf.mpxj.ProjectField.CREATION_DATE);
        public static readonly ProjectField ExtendedCreationDate = CreateField(net.sf.mpxj.ProjectField.EXTENDED_CREATION_DATE);
        public static readonly ProjectField DefaultFixedCostAccrual = CreateField(net.sf.mpxj.ProjectField.DEFAULT_FIXED_COST_ACCRUAL);
        public static readonly ProjectField CriticalSlackLimit = CreateField(net.sf.mpxj.ProjectField.CRITICAL_SLACK_LIMIT);
        public static readonly ProjectField BaselineForEarnedValue = CreateField(net.sf.mpxj.ProjectField.BASELINE_FOR_EARNED_VALUE);
        public static readonly ProjectField FiscalYearStartMonth = CreateField(net.sf.mpxj.ProjectField.FISCAL_YEAR_START_MONTH);
        public static readonly ProjectField NewTaskStartIsProjectStart = CreateField(net.sf.mpxj.ProjectField.NEW_TASK_START_IS_PROJECT_START);
        public static readonly ProjectField NewTasksAreManual = CreateField(net.sf.mpxj.ProjectField.NEW_TASKS_ARE_MANUAL);
        public static readonly ProjectField WeekStartDay = CreateField(net.sf.mpxj.ProjectField.WEEK_START_DAY);
        public static readonly ProjectField CustomProperties = CreateField(net.sf.mpxj.ProjectField.CUSTOM_PROPERTIES);
        public static readonly ProjectField CurrencyCode = CreateField(net.sf.mpxj.ProjectField.CURRENCY_CODE);
        public static readonly ProjectField ShowProjectSummaryTask = CreateField(net.sf.mpxj.ProjectField.SHOW_PROJECT_SUMMARY_TASK);
        public static readonly ProjectField BaselineDate = CreateField(net.sf.mpxj.ProjectField.BASELINE_DATE);
        public static readonly ProjectField Baseline1Date = CreateField(net.sf.mpxj.ProjectField.BASELINE1_DATE);
        public static readonly ProjectField Baseline2Date = CreateField(net.sf.mpxj.ProjectField.BASELINE2_DATE);
        public static readonly ProjectField Baseline3Date = CreateField(net.sf.mpxj.ProjectField.BASELINE3_DATE);
        public static readonly ProjectField Baseline4Date = CreateField(net.sf.mpxj.ProjectField.BASELINE4_DATE);
        public static readonly ProjectField Baseline5Date = CreateField(net.sf.mpxj.ProjectField.BASELINE5_DATE);
        public static readonly ProjectField Baseline6Date = CreateField(net.sf.mpxj.ProjectField.BASELINE6_DATE);
        public static readonly ProjectField Baseline7Date = CreateField(net.sf.mpxj.ProjectField.BASELINE7_DATE);
        public static readonly ProjectField Baseline8Date = CreateField(net.sf.mpxj.ProjectField.BASELINE8_DATE);
        public static readonly ProjectField Baseline9Date = CreateField(net.sf.mpxj.ProjectField.BASELINE9_DATE);
        public static readonly ProjectField Baseline10Date = CreateField(net.sf.mpxj.ProjectField.BASELINE10_DATE);
        public static readonly ProjectField Template = CreateField(net.sf.mpxj.ProjectField.TEMPLATE);
        public static readonly ProjectField LastAuthor = CreateField(net.sf.mpxj.ProjectField.LAST_AUTHOR);
        public static readonly ProjectField Lastprinted = CreateField(net.sf.mpxj.ProjectField.LASTPRINTED);
        public static readonly ProjectField ShortApplicationName = CreateField(net.sf.mpxj.ProjectField.SHORT_APPLICATION_NAME);
        public static readonly ProjectField EditingTime = CreateField(net.sf.mpxj.ProjectField.EDITING_TIME);
        public static readonly ProjectField PresentationFormat = CreateField(net.sf.mpxj.ProjectField.PRESENTATION_FORMAT);
        public static readonly ProjectField ContentType = CreateField(net.sf.mpxj.ProjectField.CONTENT_TYPE);
        public static readonly ProjectField ContentStatus = CreateField(net.sf.mpxj.ProjectField.CONTENT_STATUS);
        public static readonly ProjectField Language = CreateField(net.sf.mpxj.ProjectField.LANGUAGE);
        public static readonly ProjectField DocumentVersion = CreateField(net.sf.mpxj.ProjectField.DOCUMENT_VERSION);
        public static readonly ProjectField MpxDelimiter = CreateField(net.sf.mpxj.ProjectField.MPX_DELIMITER);
        public static readonly ProjectField MpxProgramName = CreateField(net.sf.mpxj.ProjectField.MPX_PROGRAM_NAME);
        public static readonly ProjectField MpxFileVersion = CreateField(net.sf.mpxj.ProjectField.MPX_FILE_VERSION);
        public static readonly ProjectField MpxCodePage = CreateField(net.sf.mpxj.ProjectField.MPX_CODE_PAGE);
        public static readonly ProjectField ProjectFilePath = CreateField(net.sf.mpxj.ProjectField.PROJECT_FILE_PATH);
        public static readonly ProjectField FullApplicationName = CreateField(net.sf.mpxj.ProjectField.FULL_APPLICATION_NAME);
        public static readonly ProjectField ApplicationVersion = CreateField(net.sf.mpxj.ProjectField.APPLICATION_VERSION);
        public static readonly ProjectField MppFileType = CreateField(net.sf.mpxj.ProjectField.MPP_FILE_TYPE);
        public static readonly ProjectField Autofilter = CreateField(net.sf.mpxj.ProjectField.AUTOFILTER);
        public static readonly ProjectField FileApplication = CreateField(net.sf.mpxj.ProjectField.FILE_APPLICATION);
        public static readonly ProjectField FileType = CreateField(net.sf.mpxj.ProjectField.FILE_TYPE);
        public static readonly ProjectField ExportFlag = CreateField(net.sf.mpxj.ProjectField.EXPORT_FLAG);
        public static readonly ProjectField Guid = CreateField(net.sf.mpxj.ProjectField.GUID);
        public static readonly ProjectField ProjectId = CreateField(net.sf.mpxj.ProjectField.PROJECT_ID);
        public static readonly ProjectField BaselineProjectUniqueId = CreateField(net.sf.mpxj.ProjectField.BASELINE_PROJECT_UNIQUE_ID);
        public static readonly ProjectField CriticalActivityType = CreateField(net.sf.mpxj.ProjectField.CRITICAL_ACTIVITY_TYPE);
        public static readonly ProjectField MustFinishBy = CreateField(net.sf.mpxj.ProjectField.MUST_FINISH_BY);
        public static readonly ProjectField ScheduledFinish = CreateField(net.sf.mpxj.ProjectField.SCHEDULED_FINISH);
        public static readonly ProjectField PlannedStart = CreateField(net.sf.mpxj.ProjectField.PLANNED_START);
        public static readonly ProjectField FinishDate = CreateField(net.sf.mpxj.ProjectField.FINISH_DATE);
        public static readonly ProjectField LocationUniqueId = CreateField(net.sf.mpxj.ProjectField.LOCATION_UNIQUE_ID);
        public static readonly ProjectField ResourcePoolFile = CreateField(net.sf.mpxj.ProjectField.RESOURCE_POOL_FILE);

        internal ProjectField(net.sf.mpxj.ProjectField javaObject)
        {
            JavaObject = javaObject;
        }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Constraint;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        private static ProjectField CreateField(net.sf.mpxj.ProjectField javaField)
        {
            return EnumExtensionMethods.RegisterFieldType(javaField, CreateField(javaField));
        }
    }
}

