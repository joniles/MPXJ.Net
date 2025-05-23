﻿using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectField : IFieldType, IJavaObjectProxy<org.mpxj.FieldType>
    {
        public org.mpxj.FieldType JavaObject { get; }

        private static List<ProjectField> InternalValues { get; } = new List<ProjectField>();
        public static IReadOnlyList<ProjectField> Values => InternalValues.AsReadOnly();

        public static readonly ProjectField StartDate = new ProjectField(org.mpxj.ProjectField.START_DATE);
        public static readonly ProjectField CurrencySymbol = new ProjectField(org.mpxj.ProjectField.CURRENCY_SYMBOL);
        public static readonly ProjectField CurrencySymbolPosition = new ProjectField(org.mpxj.ProjectField.CURRENCY_SYMBOL_POSITION);
        public static readonly ProjectField CurrencyDigits = new ProjectField(org.mpxj.ProjectField.CURRENCY_DIGITS);
        public static readonly ProjectField ThousandsSeparator = new ProjectField(org.mpxj.ProjectField.THOUSANDS_SEPARATOR);
        public static readonly ProjectField DecimalSeparator = new ProjectField(org.mpxj.ProjectField.DECIMAL_SEPARATOR);
        public static readonly ProjectField DefaultDurationUnits = new ProjectField(org.mpxj.ProjectField.DEFAULT_DURATION_UNITS);
        public static readonly ProjectField DefaultDurationIsFixed = new ProjectField(org.mpxj.ProjectField.DEFAULT_DURATION_IS_FIXED);
        public static readonly ProjectField DefaultWorkUnits = new ProjectField(org.mpxj.ProjectField.DEFAULT_WORK_UNITS);
        public static readonly ProjectField DefaultStandardRate = new ProjectField(org.mpxj.ProjectField.DEFAULT_STANDARD_RATE);
        public static readonly ProjectField DefaultOvertimeRate = new ProjectField(org.mpxj.ProjectField.DEFAULT_OVERTIME_RATE);
        public static readonly ProjectField UpdatingTaskStatusUpdatesResourceStatus = new ProjectField(org.mpxj.ProjectField.UPDATING_TASK_STATUS_UPDATES_RESOURCE_STATUS);
        public static readonly ProjectField SplitInProgressTasks = new ProjectField(org.mpxj.ProjectField.SPLIT_IN_PROGRESS_TASKS);
        public static readonly ProjectField DateOrder = new ProjectField(org.mpxj.ProjectField.DATE_ORDER);
        public static readonly ProjectField TimeFormat = new ProjectField(org.mpxj.ProjectField.TIME_FORMAT);
        public static readonly ProjectField DefaultStartTime = new ProjectField(org.mpxj.ProjectField.DEFAULT_START_TIME);
        public static readonly ProjectField DateSeparator = new ProjectField(org.mpxj.ProjectField.DATE_SEPARATOR);
        public static readonly ProjectField TimeSeparator = new ProjectField(org.mpxj.ProjectField.TIME_SEPARATOR);
        public static readonly ProjectField AmText = new ProjectField(org.mpxj.ProjectField.AM_TEXT);
        public static readonly ProjectField PmText = new ProjectField(org.mpxj.ProjectField.PM_TEXT);
        public static readonly ProjectField DateFormat = new ProjectField(org.mpxj.ProjectField.DATE_FORMAT);
        public static readonly ProjectField BarTextDateFormat = new ProjectField(org.mpxj.ProjectField.BAR_TEXT_DATE_FORMAT);
        public static readonly ProjectField ProjectTitle = new ProjectField(org.mpxj.ProjectField.PROJECT_TITLE);
        public static readonly ProjectField Company = new ProjectField(org.mpxj.ProjectField.COMPANY);
        public static readonly ProjectField Manager = new ProjectField(org.mpxj.ProjectField.MANAGER);
        public static readonly ProjectField DefaultCalendarUniqueId = new ProjectField(org.mpxj.ProjectField.DEFAULT_CALENDAR_UNIQUE_ID);
        public static readonly ProjectField ScheduleFrom = new ProjectField(org.mpxj.ProjectField.SCHEDULE_FROM);
        public static readonly ProjectField CurrentDate = new ProjectField(org.mpxj.ProjectField.CURRENT_DATE);
        public static readonly ProjectField Comments = new ProjectField(org.mpxj.ProjectField.COMMENTS);
        public static readonly ProjectField Cost = new ProjectField(org.mpxj.ProjectField.COST);
        public static readonly ProjectField BaselineCost = new ProjectField(org.mpxj.ProjectField.BASELINE_COST);
        public static readonly ProjectField ActualCost = new ProjectField(org.mpxj.ProjectField.ACTUAL_COST);
        public static readonly ProjectField Work = new ProjectField(org.mpxj.ProjectField.WORK);
        public static readonly ProjectField BaselineWork = new ProjectField(org.mpxj.ProjectField.BASELINE_WORK);
        public static readonly ProjectField ActualWork = new ProjectField(org.mpxj.ProjectField.ACTUAL_WORK);
        public static readonly ProjectField Work2 = new ProjectField(org.mpxj.ProjectField.WORK2);
        public static readonly ProjectField Duration = new ProjectField(org.mpxj.ProjectField.DURATION);
        public static readonly ProjectField BaselineDuration = new ProjectField(org.mpxj.ProjectField.BASELINE_DURATION);
        public static readonly ProjectField ActualDuration = new ProjectField(org.mpxj.ProjectField.ACTUAL_DURATION);
        public static readonly ProjectField PercentageComplete = new ProjectField(org.mpxj.ProjectField.PERCENTAGE_COMPLETE);
        public static readonly ProjectField BaselineStart = new ProjectField(org.mpxj.ProjectField.BASELINE_START);
        public static readonly ProjectField BaselineFinish = new ProjectField(org.mpxj.ProjectField.BASELINE_FINISH);
        public static readonly ProjectField ActualStart = new ProjectField(org.mpxj.ProjectField.ACTUAL_START);
        public static readonly ProjectField ActualFinish = new ProjectField(org.mpxj.ProjectField.ACTUAL_FINISH);
        public static readonly ProjectField StartVariance = new ProjectField(org.mpxj.ProjectField.START_VARIANCE);
        public static readonly ProjectField FinishVariance = new ProjectField(org.mpxj.ProjectField.FINISH_VARIANCE);
        public static readonly ProjectField Subject = new ProjectField(org.mpxj.ProjectField.SUBJECT);
        public static readonly ProjectField Author = new ProjectField(org.mpxj.ProjectField.AUTHOR);
        public static readonly ProjectField Keywords = new ProjectField(org.mpxj.ProjectField.KEYWORDS);
        public static readonly ProjectField HyperlinkBase = new ProjectField(org.mpxj.ProjectField.HYPERLINK_BASE);
        public static readonly ProjectField DefaultEndTime = new ProjectField(org.mpxj.ProjectField.DEFAULT_END_TIME);
        public static readonly ProjectField ProjectExternallyEdited = new ProjectField(org.mpxj.ProjectField.PROJECT_EXTERNALLY_EDITED);
        public static readonly ProjectField Category = new ProjectField(org.mpxj.ProjectField.CATEGORY);
        public static readonly ProjectField MinutesPerDay = new ProjectField(org.mpxj.ProjectField.MINUTES_PER_DAY);
        public static readonly ProjectField DaysPerMonth = new ProjectField(org.mpxj.ProjectField.DAYS_PER_MONTH);
        public static readonly ProjectField MinutesPerWeek = new ProjectField(org.mpxj.ProjectField.MINUTES_PER_WEEK);
        public static readonly ProjectField MinutesPerMonth = new ProjectField(org.mpxj.ProjectField.MINUTES_PER_MONTH);
        public static readonly ProjectField MinutesPerYear = new ProjectField(org.mpxj.ProjectField.MINUTES_PER_YEAR);
        public static readonly ProjectField FiscalYearStart = new ProjectField(org.mpxj.ProjectField.FISCAL_YEAR_START);
        public static readonly ProjectField DefaultTaskEarnedValueMethod = new ProjectField(org.mpxj.ProjectField.DEFAULT_TASK_EARNED_VALUE_METHOD);
        public static readonly ProjectField RemoveFileProperties = new ProjectField(org.mpxj.ProjectField.REMOVE_FILE_PROPERTIES);
        public static readonly ProjectField MoveCompletedEndsBack = new ProjectField(org.mpxj.ProjectField.MOVE_COMPLETED_ENDS_BACK);
        public static readonly ProjectField NewTasksEstimated = new ProjectField(org.mpxj.ProjectField.NEW_TASKS_ESTIMATED);
        public static readonly ProjectField SpreadActualCost = new ProjectField(org.mpxj.ProjectField.SPREAD_ACTUAL_COST);
        public static readonly ProjectField MultipleCriticalPaths = new ProjectField(org.mpxj.ProjectField.MULTIPLE_CRITICAL_PATHS);
        public static readonly ProjectField AutoAddNewResourcesAndTasks = new ProjectField(org.mpxj.ProjectField.AUTO_ADD_NEW_RESOURCES_AND_TASKS);
        public static readonly ProjectField LastSaved = new ProjectField(org.mpxj.ProjectField.LAST_SAVED);
        public static readonly ProjectField StatusDate = new ProjectField(org.mpxj.ProjectField.STATUS_DATE);
        public static readonly ProjectField MoveRemainingStartsBack = new ProjectField(org.mpxj.ProjectField.MOVE_REMAINING_STARTS_BACK);
        public static readonly ProjectField AutoLink = new ProjectField(org.mpxj.ProjectField.AUTO_LINK);
        public static readonly ProjectField MicrosoftProjectServerUrl = new ProjectField(org.mpxj.ProjectField.MICROSOFT_PROJECT_SERVER_URL);
        public static readonly ProjectField HonorConstraints = new ProjectField(org.mpxj.ProjectField.HONOR_CONSTRAINTS);
        public static readonly ProjectField AdminProject = new ProjectField(org.mpxj.ProjectField.ADMIN_PROJECT);
        public static readonly ProjectField InsertedProjectsLikeSummary = new ProjectField(org.mpxj.ProjectField.INSERTED_PROJECTS_LIKE_SUMMARY);
        public static readonly ProjectField Name = new ProjectField(org.mpxj.ProjectField.NAME);
        public static readonly ProjectField SpreadPercentComplete = new ProjectField(org.mpxj.ProjectField.SPREAD_PERCENT_COMPLETE);
        public static readonly ProjectField MoveCompletedEndsForward = new ProjectField(org.mpxj.ProjectField.MOVE_COMPLETED_ENDS_FORWARD);
        public static readonly ProjectField EditableActualCosts = new ProjectField(org.mpxj.ProjectField.EDITABLE_ACTUAL_COSTS);
        public static readonly ProjectField UniqueId = new ProjectField(org.mpxj.ProjectField.UNIQUE_ID);
        public static readonly ProjectField Revision = new ProjectField(org.mpxj.ProjectField.REVISION);
        public static readonly ProjectField NewTasksEffortDriven = new ProjectField(org.mpxj.ProjectField.NEW_TASKS_EFFORT_DRIVEN);
        public static readonly ProjectField MoveRemainingStartsForward = new ProjectField(org.mpxj.ProjectField.MOVE_REMAINING_STARTS_FORWARD);
        public static readonly ProjectField ActualsInSync = new ProjectField(org.mpxj.ProjectField.ACTUALS_IN_SYNC);
        public static readonly ProjectField DefaultTaskType = new ProjectField(org.mpxj.ProjectField.DEFAULT_TASK_TYPE);
        public static readonly ProjectField EarnedValueMethod = new ProjectField(org.mpxj.ProjectField.EARNED_VALUE_METHOD);
        public static readonly ProjectField CreationDate = new ProjectField(org.mpxj.ProjectField.CREATION_DATE);
        public static readonly ProjectField ExtendedCreationDate = new ProjectField(org.mpxj.ProjectField.EXTENDED_CREATION_DATE);
        public static readonly ProjectField DefaultFixedCostAccrual = new ProjectField(org.mpxj.ProjectField.DEFAULT_FIXED_COST_ACCRUAL);
        public static readonly ProjectField CriticalSlackLimit = new ProjectField(org.mpxj.ProjectField.CRITICAL_SLACK_LIMIT);
        public static readonly ProjectField BaselineForEarnedValue = new ProjectField(org.mpxj.ProjectField.BASELINE_FOR_EARNED_VALUE);
        public static readonly ProjectField FiscalYearStartMonth = new ProjectField(org.mpxj.ProjectField.FISCAL_YEAR_START_MONTH);
        public static readonly ProjectField NewTaskStartIsProjectStart = new ProjectField(org.mpxj.ProjectField.NEW_TASK_START_IS_PROJECT_START);
        public static readonly ProjectField NewTasksAreManual = new ProjectField(org.mpxj.ProjectField.NEW_TASKS_ARE_MANUAL);
        public static readonly ProjectField WeekStartDay = new ProjectField(org.mpxj.ProjectField.WEEK_START_DAY);
        public static readonly ProjectField CustomProperties = new ProjectField(org.mpxj.ProjectField.CUSTOM_PROPERTIES);
        public static readonly ProjectField CurrencyCode = new ProjectField(org.mpxj.ProjectField.CURRENCY_CODE);
        public static readonly ProjectField ShowProjectSummaryTask = new ProjectField(org.mpxj.ProjectField.SHOW_PROJECT_SUMMARY_TASK);
        public static readonly ProjectField BaselineDate = new ProjectField(org.mpxj.ProjectField.BASELINE_DATE);
        public static readonly ProjectField Baseline1Date = new ProjectField(org.mpxj.ProjectField.BASELINE1_DATE);
        public static readonly ProjectField Baseline2Date = new ProjectField(org.mpxj.ProjectField.BASELINE2_DATE);
        public static readonly ProjectField Baseline3Date = new ProjectField(org.mpxj.ProjectField.BASELINE3_DATE);
        public static readonly ProjectField Baseline4Date = new ProjectField(org.mpxj.ProjectField.BASELINE4_DATE);
        public static readonly ProjectField Baseline5Date = new ProjectField(org.mpxj.ProjectField.BASELINE5_DATE);
        public static readonly ProjectField Baseline6Date = new ProjectField(org.mpxj.ProjectField.BASELINE6_DATE);
        public static readonly ProjectField Baseline7Date = new ProjectField(org.mpxj.ProjectField.BASELINE7_DATE);
        public static readonly ProjectField Baseline8Date = new ProjectField(org.mpxj.ProjectField.BASELINE8_DATE);
        public static readonly ProjectField Baseline9Date = new ProjectField(org.mpxj.ProjectField.BASELINE9_DATE);
        public static readonly ProjectField Baseline10Date = new ProjectField(org.mpxj.ProjectField.BASELINE10_DATE);
        public static readonly ProjectField Template = new ProjectField(org.mpxj.ProjectField.TEMPLATE);
        public static readonly ProjectField LastAuthor = new ProjectField(org.mpxj.ProjectField.LAST_AUTHOR);
        public static readonly ProjectField Lastprinted = new ProjectField(org.mpxj.ProjectField.LASTPRINTED);
        public static readonly ProjectField ShortApplicationName = new ProjectField(org.mpxj.ProjectField.SHORT_APPLICATION_NAME);
        public static readonly ProjectField EditingTime = new ProjectField(org.mpxj.ProjectField.EDITING_TIME);
        public static readonly ProjectField PresentationFormat = new ProjectField(org.mpxj.ProjectField.PRESENTATION_FORMAT);
        public static readonly ProjectField ContentType = new ProjectField(org.mpxj.ProjectField.CONTENT_TYPE);
        public static readonly ProjectField ContentStatus = new ProjectField(org.mpxj.ProjectField.CONTENT_STATUS);
        public static readonly ProjectField Language = new ProjectField(org.mpxj.ProjectField.LANGUAGE);
        public static readonly ProjectField DocumentVersion = new ProjectField(org.mpxj.ProjectField.DOCUMENT_VERSION);
        public static readonly ProjectField MpxDelimiter = new ProjectField(org.mpxj.ProjectField.MPX_DELIMITER);
        public static readonly ProjectField MpxProgramName = new ProjectField(org.mpxj.ProjectField.MPX_PROGRAM_NAME);
        public static readonly ProjectField MpxFileVersion = new ProjectField(org.mpxj.ProjectField.MPX_FILE_VERSION);
        public static readonly ProjectField MpxCodePage = new ProjectField(org.mpxj.ProjectField.MPX_CODE_PAGE);
        public static readonly ProjectField ProjectFilePath = new ProjectField(org.mpxj.ProjectField.PROJECT_FILE_PATH);
        public static readonly ProjectField FullApplicationName = new ProjectField(org.mpxj.ProjectField.FULL_APPLICATION_NAME);
        public static readonly ProjectField ApplicationVersion = new ProjectField(org.mpxj.ProjectField.APPLICATION_VERSION);
        public static readonly ProjectField MppFileType = new ProjectField(org.mpxj.ProjectField.MPP_FILE_TYPE);
        public static readonly ProjectField Autofilter = new ProjectField(org.mpxj.ProjectField.AUTOFILTER);
        public static readonly ProjectField FileApplication = new ProjectField(org.mpxj.ProjectField.FILE_APPLICATION);
        public static readonly ProjectField FileType = new ProjectField(org.mpxj.ProjectField.FILE_TYPE);
        public static readonly ProjectField ExportFlag = new ProjectField(org.mpxj.ProjectField.EXPORT_FLAG);
        public static readonly ProjectField Guid = new ProjectField(org.mpxj.ProjectField.GUID);
        public static readonly ProjectField ProjectId = new ProjectField(org.mpxj.ProjectField.PROJECT_ID);
        public static readonly ProjectField BaselineProjectUniqueId = new ProjectField(org.mpxj.ProjectField.BASELINE_PROJECT_UNIQUE_ID);
        public static readonly ProjectField CriticalActivityType = new ProjectField(org.mpxj.ProjectField.CRITICAL_ACTIVITY_TYPE);
        public static readonly ProjectField MustFinishBy = new ProjectField(org.mpxj.ProjectField.MUST_FINISH_BY);
        public static readonly ProjectField ScheduledFinish = new ProjectField(org.mpxj.ProjectField.SCHEDULED_FINISH);
        public static readonly ProjectField PlannedStart = new ProjectField(org.mpxj.ProjectField.PLANNED_START);
        public static readonly ProjectField FinishDate = new ProjectField(org.mpxj.ProjectField.FINISH_DATE);
        public static readonly ProjectField LocationUniqueId = new ProjectField(org.mpxj.ProjectField.LOCATION_UNIQUE_ID);
        public static readonly ProjectField ResourcePoolFile = new ProjectField(org.mpxj.ProjectField.RESOURCE_POOL_FILE);
        public static readonly ProjectField TotalSlackCalculationType = new ProjectField(org.mpxj.ProjectField.TOTAL_SLACK_CALCULATION_TYPE);
        public static readonly ProjectField RelationshipLagCalendar = new ProjectField(org.mpxj.ProjectField.RELATIONSHIP_LAG_CALENDAR);
        public static readonly ProjectField WbsCodeSeparator = new ProjectField(org.mpxj.ProjectField.WBS_CODE_SEPARATOR);
        public static readonly ProjectField ConsiderAssignmentsInOtherProjects = new ProjectField(org.mpxj.ProjectField.CONSIDER_ASSIGNMENTS_IN_OTHER_PROJECTS);
        public static readonly ProjectField ConsiderAssignmentsInOtherProjectsWithPriorityEqualHigherThan = new ProjectField(org.mpxj.ProjectField.CONSIDER_ASSIGNMENTS_IN_OTHER_PROJECTS_WITH_PRIORITY_EQUAL_HIGHER_THAN);
        public static readonly ProjectField PreserveScheduledEarlyAndLateDates = new ProjectField(org.mpxj.ProjectField.PRESERVE_SCHEDULED_EARLY_AND_LATE_DATES);
        public static readonly ProjectField LevelAllResources = new ProjectField(org.mpxj.ProjectField.LEVEL_ALL_RESOURCES);
        public static readonly ProjectField LevelResourcesOnlyWithinActivityTotalFloat = new ProjectField(org.mpxj.ProjectField.LEVEL_RESOURCES_ONLY_WITHIN_ACTIVITY_TOTAL_FLOAT);
        public static readonly ProjectField PreserveMinimumFloatWhenLeveling = new ProjectField(org.mpxj.ProjectField.PRESERVE_MINIMUM_FLOAT_WHEN_LEVELING);
        public static readonly ProjectField MaxPercentToOverallocateResources = new ProjectField(org.mpxj.ProjectField.MAX_PERCENT_TO_OVERALLOCATE_RESOURCES);
        public static readonly ProjectField LevelingPriorities = new ProjectField(org.mpxj.ProjectField.LEVELING_PRIORITIES);
        public static readonly ProjectField DataDateAndPlannedStartSetToProjectForecastStart = new ProjectField(org.mpxj.ProjectField.DATA_DATE_AND_PLANNED_START_SET_TO_PROJECT_FORECAST_START);
        public static readonly ProjectField IgnoreRelationshipsToAndFromOtherProjects = new ProjectField(org.mpxj.ProjectField.IGNORE_RELATIONSHIPS_TO_AND_FROM_OTHER_PROJECTS);
        public static readonly ProjectField MakeOpenEndedActivitiesCritical = new ProjectField(org.mpxj.ProjectField.MAKE_OPEN_ENDED_ACTIVITIES_CRITICAL);
        public static readonly ProjectField UseExpectedFinishDates = new ProjectField(org.mpxj.ProjectField.USE_EXPECTED_FINISH_DATES);
        public static readonly ProjectField ComputeStartToStartLagFromEarlyStart = new ProjectField(org.mpxj.ProjectField.COMPUTE_START_TO_START_LAG_FROM_EARLY_START);
        public static readonly ProjectField CalculateFloatBasedOnFinishDateOfEachProject = new ProjectField(org.mpxj.ProjectField.CALCULATE_FLOAT_BASED_ON_FINISH_DATE_OF_EACH_PROJECT);
        public static readonly ProjectField CalculateMultipleFloatPaths = new ProjectField(org.mpxj.ProjectField.CALCULATE_MULTIPLE_FLOAT_PATHS);
        public static readonly ProjectField CalculateMultipleFloatPathsUsingTotalFloat = new ProjectField(org.mpxj.ProjectField.CALCULATE_MULTIPLE_FLOAT_PATHS_USING_TOTAL_FLOAT);
        public static readonly ProjectField DisplayMultipleFloatPathsEndingWithActivityUniqueId = new ProjectField(org.mpxj.ProjectField.DISPLAY_MULTIPLE_FLOAT_PATHS_ENDING_WITH_ACTIVITY_UNIQUE_ID);
        public static readonly ProjectField LimitNumberOfFloatPathsToCalculate = new ProjectField(org.mpxj.ProjectField.LIMIT_NUMBER_OF_FLOAT_PATHS_TO_CALCULATE);
        public static readonly ProjectField MaximumNumberOfFloatPathsToCalculate = new ProjectField(org.mpxj.ProjectField.MAXIMUM_NUMBER_OF_FLOAT_PATHS_TO_CALCULATE);
        public static readonly ProjectField SchedulingProgressedActivities = new ProjectField(org.mpxj.ProjectField.SCHEDULING_PROGRESSED_ACTIVITIES);
        public static readonly ProjectField BaselineTypeName = new ProjectField(org.mpxj.ProjectField.BASELINE_TYPE_NAME);
        public static readonly ProjectField BaselineTypeUniqueId = new ProjectField(org.mpxj.ProjectField.BASELINE_TYPE_UNIQUE_ID);
        public static readonly ProjectField LastBaselineUpdateDate = new ProjectField(org.mpxj.ProjectField.LAST_BASELINE_UPDATE_DATE);
        public static readonly ProjectField ActivityIdPrefix = new ProjectField(org.mpxj.ProjectField.ACTIVITY_ID_PREFIX);
        public static readonly ProjectField ActivityIdSuffix = new ProjectField(org.mpxj.ProjectField.ACTIVITY_ID_SUFFIX);
        public static readonly ProjectField ActivityIdIncrement = new ProjectField(org.mpxj.ProjectField.ACTIVITY_ID_INCREMENT);
        public static readonly ProjectField ActivityIdIncrementBasedOnSelectedActivity = new ProjectField(org.mpxj.ProjectField.ACTIVITY_ID_INCREMENT_BASED_ON_SELECTED_ACTIVITY);
        public static readonly ProjectField BaselineCalendarName = new ProjectField(org.mpxj.ProjectField.BASELINE_CALENDAR_NAME);
        public static readonly ProjectField ProjectIsBaseline = new ProjectField(org.mpxj.ProjectField.PROJECT_IS_BASELINE);
        public static readonly ProjectField ProjectWebsiteUrl = new ProjectField(org.mpxj.ProjectField.PROJECT_WEBSITE_URL);
        public static readonly ProjectField Notes = new ProjectField(org.mpxj.ProjectField.NOTES);
        public static readonly ProjectField EnableSummarization = new ProjectField(org.mpxj.ProjectField.ENABLE_SUMMARIZATION);
        public static readonly ProjectField EnablePublication = new ProjectField(org.mpxj.ProjectField.ENABLE_PUBLICATION);

        private ProjectField(org.mpxj.ProjectField javaObject)
        {
            JavaObject = javaObject;
            InternalValues.Add(this);
        }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Project;

        public string FieldName => JavaObject.getName();

        public string ObjectName => JavaObject.name();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => JavaObject.ToString();
    }
}
