using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class ProjectPropertiesTest
    {
        [Test]
        public void PropertyGetTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);
            var props = project.ProjectProperties;
            Assert.Multiple(() =>
            {
                Assert.That(props.StartDate, Is.EqualTo(props.Get(ProjectField.StartDate)));
                Assert.That(props.CurrencySymbol, Is.EqualTo(props.Get(ProjectField.CurrencySymbol)));
                Assert.That(props.SymbolPosition, Is.EqualTo(props.Get(ProjectField.CurrencySymbolPosition)));
                Assert.That(props.CurrencyDigits, Is.EqualTo(props.Get(ProjectField.CurrencyDigits)));
                Assert.That(props.ThousandsSeparator, Is.EqualTo(props.Get(ProjectField.ThousandsSeparator)));
                Assert.That(props.DecimalSeparator, Is.EqualTo(props.Get(ProjectField.DecimalSeparator)));
                Assert.That(props.DefaultDurationUnits, Is.EqualTo(props.Get(ProjectField.DefaultDurationUnits)));
                Assert.That(props.DefaultDurationIsFixed, Is.EqualTo(props.Get(ProjectField.DefaultDurationIsFixed)));
                Assert.That(props.DefaultWorkUnits, Is.EqualTo(props.Get(ProjectField.DefaultWorkUnits)));
                Assert.That(props.DefaultStandardRate, Is.EqualTo(props.Get(ProjectField.DefaultStandardRate)));
                Assert.That(props.DefaultOvertimeRate, Is.EqualTo(props.Get(ProjectField.DefaultOvertimeRate)));
                Assert.That(props.UpdatingTaskStatusUpdatesResourceStatus, Is.EqualTo(props.Get(ProjectField.UpdatingTaskStatusUpdatesResourceStatus)));
                Assert.That(props.SplitInProgressTasks, Is.EqualTo(props.Get(ProjectField.SplitInProgressTasks)));
                Assert.That(props.DateOrder, Is.EqualTo(props.Get(ProjectField.DateOrder)));
                Assert.That(props.TimeFormat, Is.EqualTo(props.Get(ProjectField.TimeFormat)));
                Assert.That(props.DefaultStartTime, Is.EqualTo(props.Get(ProjectField.DefaultStartTime)));
                Assert.That(props.DateSeparator, Is.EqualTo(props.Get(ProjectField.DateSeparator)));
                Assert.That(props.TimeSeparator, Is.EqualTo(props.Get(ProjectField.TimeSeparator)));
                Assert.That(props.AMText, Is.EqualTo(props.Get(ProjectField.AmText)));
                Assert.That(props.PMText, Is.EqualTo(props.Get(ProjectField.PmText)));
                Assert.That(props.DateFormat, Is.EqualTo(props.Get(ProjectField.DateFormat)));
                Assert.That(props.BarTextDateFormat, Is.EqualTo(props.Get(ProjectField.BarTextDateFormat)));
                Assert.That(props.ProjectTitle, Is.EqualTo(props.Get(ProjectField.ProjectTitle)));
                Assert.That(props.Company, Is.EqualTo(props.Get(ProjectField.Company)));
                Assert.That(props.Manager, Is.EqualTo(props.Get(ProjectField.Manager)));
                Assert.That(props.DefaultCalendarUniqueID, Is.EqualTo(props.Get(ProjectField.DefaultCalendarUniqueId)));
                Assert.That(props.ScheduleFrom, Is.EqualTo(props.Get(ProjectField.ScheduleFrom)));
                Assert.That(props.CurrentDate, Is.EqualTo(props.Get(ProjectField.CurrentDate)));
                Assert.That(props.Comments, Is.EqualTo(props.Get(ProjectField.Comments)));
                Assert.That(props.Cost, Is.EqualTo(props.Get(ProjectField.Cost)));
                Assert.That(props.BaselineCost, Is.EqualTo(props.Get(ProjectField.BaselineCost)));
                Assert.That(props.ActualCost, Is.EqualTo(props.Get(ProjectField.ActualCost)));
                Assert.That(props.Work, Is.EqualTo(props.Get(ProjectField.Work)));
                Assert.That(props.BaselineWork, Is.EqualTo(props.Get(ProjectField.BaselineWork)));
                Assert.That(props.ActualWork, Is.EqualTo(props.Get(ProjectField.ActualWork)));
                Assert.That(props.Work2, Is.EqualTo(props.Get(ProjectField.Work2)));
                Assert.That(props.Duration, Is.EqualTo(props.Get(ProjectField.Duration)));
                Assert.That(props.BaselineDuration, Is.EqualTo(props.Get(ProjectField.BaselineDuration)));
                Assert.That(props.ActualDuration, Is.EqualTo(props.Get(ProjectField.ActualDuration)));
                Assert.That(props.PercentageComplete, Is.EqualTo(props.Get(ProjectField.PercentageComplete)));
                Assert.That(props.BaselineStart, Is.EqualTo(props.Get(ProjectField.BaselineStart)));
                Assert.That(props.BaselineFinish, Is.EqualTo(props.Get(ProjectField.BaselineFinish)));
                Assert.That(props.ActualStart, Is.EqualTo(props.Get(ProjectField.ActualStart)));
                Assert.That(props.ActualFinish, Is.EqualTo(props.Get(ProjectField.ActualFinish)));
                Assert.That(props.StartVariance, Is.EqualTo(props.Get(ProjectField.StartVariance)));
                Assert.That(props.FinishVariance, Is.EqualTo(props.Get(ProjectField.FinishVariance)));
                Assert.That(props.Subject, Is.EqualTo(props.Get(ProjectField.Subject)));
                Assert.That(props.Author, Is.EqualTo(props.Get(ProjectField.Author)));
                Assert.That(props.Keywords, Is.EqualTo(props.Get(ProjectField.Keywords)));
                Assert.That(props.HyperlinkBase, Is.EqualTo(props.Get(ProjectField.HyperlinkBase)));
                Assert.That(props.DefaultEndTime, Is.EqualTo(props.Get(ProjectField.DefaultEndTime)));
                Assert.That(props.ProjectExternallyEdited, Is.EqualTo(props.Get(ProjectField.ProjectExternallyEdited)));
                Assert.That(props.Category, Is.EqualTo(props.Get(ProjectField.Category)));
                Assert.That(props.MinutesPerDay, Is.EqualTo(props.Get(ProjectField.MinutesPerDay)));
                Assert.That(props.DaysPerMonth, Is.EqualTo(props.Get(ProjectField.DaysPerMonth)));
                Assert.That(props.MinutesPerWeek, Is.EqualTo(props.Get(ProjectField.MinutesPerWeek)));
                Assert.That(props.MinutesPerMonth, Is.EqualTo(props.Get(ProjectField.MinutesPerMonth)));
                Assert.That(props.MinutesPerYear, Is.EqualTo(props.Get(ProjectField.MinutesPerYear)));
                Assert.That(props.FiscalYearStart, Is.EqualTo(props.Get(ProjectField.FiscalYearStart)));
                Assert.That(props.DefaultTaskEarnedValueMethod, Is.EqualTo(props.Get(ProjectField.DefaultTaskEarnedValueMethod)));
                Assert.That(props.RemoveFileProperties, Is.False);
                Assert.That(props.Get(ProjectField.RemoveFileProperties), Is.Null);
                Assert.That(props.MoveCompletedEndsBack, Is.False);
                Assert.That(props.Get(ProjectField.MoveCompletedEndsBack), Is.Null);
                Assert.That(props.NewTasksEstimated, Is.EqualTo(props.Get(ProjectField.NewTasksEstimated)));
                Assert.That(props.SpreadActualCost, Is.False);
                Assert.That(props.Get(ProjectField.SpreadActualCost), Is.Null);
                Assert.That(props.MultipleCriticalPaths, Is.EqualTo(props.Get(ProjectField.MultipleCriticalPaths)));
                Assert.That(props.AutoAddNewResourcesAndTasks, Is.EqualTo(props.Get(ProjectField.AutoAddNewResourcesAndTasks)));
                Assert.That(props.LastSaved, Is.EqualTo(props.Get(ProjectField.LastSaved)));
                Assert.That(props.StatusDate, Is.EqualTo(props.Get(ProjectField.StatusDate)));
                Assert.That(props.MoveRemainingStartsBack, Is.False);
                Assert.That(props.Get(ProjectField.MoveRemainingStartsBack), Is.Null);
                Assert.That(props.Autolink, Is.EqualTo(props.Get(ProjectField.AutoLink)));
                Assert.That(props.MicrosoftProjectServerURL, Is.EqualTo(props.Get(ProjectField.MicrosoftProjectServerUrl)));
                Assert.That(props.HonorConstraints, Is.EqualTo(props.Get(ProjectField.HonorConstraints)));
                Assert.That(props.AdminProject, Is.False);
                Assert.That(props.Get(ProjectField.AdminProject), Is.Null);
                Assert.That(props.InsertedProjectsLikeSummary, Is.False);
                Assert.That(props.Get(ProjectField.InsertedProjectsLikeSummary), Is.Null);
                Assert.That(props.Name, Is.EqualTo(props.Get(ProjectField.Name)));
                Assert.That(props.SpreadPercentComplete, Is.False);
                Assert.That(props.Get(ProjectField.SpreadPercentComplete), Is.Null);
                Assert.That(props.MoveCompletedEndsForward, Is.False);
                Assert.That(props.Get(ProjectField.MoveCompletedEndsForward), Is.Null);
                Assert.That(props.EditableActualCosts, Is.EqualTo(props.Get(ProjectField.EditableActualCosts)));
                Assert.That(props.UniqueID, Is.EqualTo(props.Get(ProjectField.UniqueId)));
                Assert.That(props.Revision, Is.EqualTo(props.Get(ProjectField.Revision)));
                Assert.That(props.NewTasksEffortDriven, Is.False);
                Assert.That(props.Get(ProjectField.NewTasksEffortDriven), Is.Null);
                Assert.That(props.MoveRemainingStartsForward, Is.False);
                Assert.That(props.Get(ProjectField.MoveRemainingStartsForward), Is.Null);
                Assert.That(props.ActualsInSync, Is.False);
                Assert.That(props.Get(ProjectField.ActualsInSync), Is.Null);
                Assert.That(props.DefaultTaskType, Is.EqualTo(props.Get(ProjectField.DefaultTaskType)));
                Assert.That(props.EarnedValueMethod, Is.EqualTo(props.Get(ProjectField.EarnedValueMethod)));
                Assert.That(props.CreationDate, Is.EqualTo(props.Get(ProjectField.CreationDate)));
                Assert.That(props.ExtendedCreationDate, Is.EqualTo(props.Get(ProjectField.ExtendedCreationDate)));
                Assert.That(props.DefaultFixedCostAccrual, Is.EqualTo(props.Get(ProjectField.DefaultFixedCostAccrual)));
                Assert.That(props.CriticalSlackLimit, Is.EqualTo(props.Get(ProjectField.CriticalSlackLimit)));
                Assert.That(props.BaselineForEarnedValue, Is.EqualTo(props.Get(ProjectField.BaselineForEarnedValue)));
                Assert.That(props.FiscalYearStartMonth, Is.EqualTo(props.Get(ProjectField.FiscalYearStartMonth)));
                Assert.That(props.NewTaskStartIsProjectStart, Is.EqualTo(props.Get(ProjectField.NewTaskStartIsProjectStart)));
                Assert.That(props.NewTasksAreManual, Is.EqualTo(props.Get(ProjectField.NewTasksAreManual)));
                Assert.That(props.WeekStartDay, Is.EqualTo(props.Get(ProjectField.WeekStartDay)));
                //Assert.That(props.CustomProperties, Is.EqualTo(props.Get(ProjectField.CustomProperties)));
                Assert.That(props.CurrencyCode, Is.EqualTo(props.Get(ProjectField.CurrencyCode)));
                Assert.That(props.ShowProjectSummaryTask, Is.EqualTo(props.Get(ProjectField.ShowProjectSummaryTask)));
                Assert.That(props.BaselineDate, Is.EqualTo(props.Get(ProjectField.BaselineDate)));
                Assert.That(props.GetBaselineDate(1), Is.EqualTo(props.Get(ProjectField.Baseline1Date)));
                Assert.That(props.GetBaselineDate(2), Is.EqualTo(props.Get(ProjectField.Baseline2Date)));
                Assert.That(props.GetBaselineDate(3), Is.EqualTo(props.Get(ProjectField.Baseline3Date)));
                Assert.That(props.GetBaselineDate(4), Is.EqualTo(props.Get(ProjectField.Baseline4Date)));
                Assert.That(props.GetBaselineDate(5), Is.EqualTo(props.Get(ProjectField.Baseline5Date)));
                Assert.That(props.GetBaselineDate(6), Is.EqualTo(props.Get(ProjectField.Baseline6Date)));
                Assert.That(props.GetBaselineDate(7), Is.EqualTo(props.Get(ProjectField.Baseline7Date)));
                Assert.That(props.GetBaselineDate(8), Is.EqualTo(props.Get(ProjectField.Baseline8Date)));
                Assert.That(props.GetBaselineDate(9), Is.EqualTo(props.Get(ProjectField.Baseline9Date)));
                Assert.That(props.GetBaselineDate(10), Is.EqualTo(props.Get(ProjectField.Baseline10Date)));
                Assert.That(props.Template, Is.EqualTo(props.Get(ProjectField.Template)));
                Assert.That(props.LastAuthor, Is.EqualTo(props.Get(ProjectField.LastAuthor)));
                Assert.That(props.LastPrinted, Is.EqualTo(props.Get(ProjectField.Lastprinted)));
                Assert.That(props.ShortApplicationName, Is.EqualTo(props.Get(ProjectField.ShortApplicationName)));
                Assert.That(props.EditingTime, Is.EqualTo(props.Get(ProjectField.EditingTime)));
                Assert.That(props.PresentationFormat, Is.EqualTo(props.Get(ProjectField.PresentationFormat)));
                Assert.That(props.ContentType, Is.EqualTo(props.Get(ProjectField.ContentType)));
                Assert.That(props.ContentStatus, Is.EqualTo(props.Get(ProjectField.ContentStatus)));
                Assert.That(props.Language, Is.EqualTo(props.Get(ProjectField.Language)));
                Assert.That(props.DocumentVersion, Is.EqualTo(props.Get(ProjectField.DocumentVersion)));
                Assert.That(props.MpxDelimiter, Is.EqualTo(props.Get(ProjectField.MpxDelimiter)));
                Assert.That(props.MpxProgramName, Is.EqualTo(props.Get(ProjectField.MpxProgramName)));
                Assert.That(props.MpxFileVersion, Is.EqualTo(props.Get(ProjectField.MpxFileVersion)));
                Assert.That(props.MpxCodePage, Is.EqualTo(props.Get(ProjectField.MpxCodePage)));
                Assert.That(props.ProjectFilePath, Is.EqualTo(props.Get(ProjectField.ProjectFilePath)));
                Assert.That(props.FullApplicationName, Is.EqualTo(props.Get(ProjectField.FullApplicationName)));
                Assert.That(props.ApplicationVersion, Is.EqualTo(props.Get(ProjectField.ApplicationVersion)));
                Assert.That(props.MppFileType, Is.EqualTo(props.Get(ProjectField.MppFileType)));
                Assert.That(props.AutoFilter, Is.EqualTo(props.Get(ProjectField.Autofilter)));
                Assert.That(props.FileApplication, Is.EqualTo(props.Get(ProjectField.FileApplication)));
                Assert.That(props.FileType, Is.EqualTo(props.Get(ProjectField.FileType)));
                Assert.That(props.ExportFlag, Is.False);
                Assert.That(props.Get(ProjectField.ExportFlag), Is.Null);
                Assert.That(props.GUID, Is.EqualTo(props.Get(ProjectField.Guid)));
                Assert.That(props.ProjectID, Is.EqualTo(props.Get(ProjectField.ProjectId)));
                Assert.That(props.BaselineProjectUniqueID, Is.EqualTo(props.Get(ProjectField.BaselineProjectUniqueId)));
                Assert.That(props.CriticalActivityType, Is.EqualTo(props.Get(ProjectField.CriticalActivityType)));
                Assert.That(props.MustFinishBy, Is.EqualTo(props.Get(ProjectField.MustFinishBy)));
                Assert.That(props.ScheduledFinish, Is.EqualTo(props.Get(ProjectField.ScheduledFinish)));
                Assert.That(props.PlannedStart, Is.EqualTo(props.Get(ProjectField.PlannedStart)));
                Assert.That(props.FinishDate, Is.EqualTo(props.Get(ProjectField.FinishDate)));
                Assert.That(props.LocationUniqueID, Is.EqualTo(props.Get(ProjectField.LocationUniqueId)));
                Assert.That(props.ResourcePoolFile, Is.EqualTo(props.Get(ProjectField.ResourcePoolFile)));
            });
        }

        [Test]
        public void CustomPropertiesTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var custom = project.ProjectProperties.CustomProperties;
            Assert.Multiple(() =>
            {
                Assert.That(custom.IsReadOnly, Is.False);
                Assert.That(custom, Has.Count.EqualTo(7));
                Assert.That(custom.Keys, Has.Count.EqualTo(7));
                Assert.That(custom.Values, Has.Count.EqualTo(7));

                Assert.That(custom["% Complete"], Is.EqualTo("0%"));
                Assert.That(custom["% Work Complete"], Is.EqualTo("0%"));
                Assert.That(custom["Cost"], Is.EqualTo("£2,446.00"));
                Assert.That(custom["Scheduled Duration"], Is.EqualTo("18d"));
                Assert.That(custom["Scheduled Finish"], Is.EqualTo(new DateTime(2023, 8, 22, 16, 0, 0, DateTimeKind.Utc).ToLocalTime()));
                Assert.That(custom["Scheduled Start"], Is.EqualTo(new DateTime(2023, 7, 28, 7, 0, 0, DateTimeKind.Utc).ToLocalTime()));
                Assert.That(custom["Work"], Is.EqualTo("192h"));

                Assert.That(custom.ContainsKey("Work"), Is.True);
                Assert.That(custom.Contains(new KeyValuePair<string, object>("Work", "192h")), Is.True);
                Assert.That(custom.Contains(new KeyValuePair<string, object>("XWork", "192h")), Is.False);

                Assert.That(custom.ContainsKey("TestKey"), Is.False);
                custom["TestKey"] = "TestValue";
                Assert.That(custom.ContainsKey("TestKey"), Is.True);

                Assert.That(custom.TryGetValue("XTestKey", out var value), Is.False);
                Assert.That(custom.TryGetValue("TestKey", out value), Is.True);
                Assert.That(value, Is.EqualTo("TestValue"));

                Assert.That(custom.Remove("TestKey"), Is.True);
                Assert.That(custom, Has.Count.EqualTo(7));
                Assert.That(custom.Remove("TestKey"), Is.False);

                custom.Add("TestKey", "TestValue");
                Assert.That(custom, Has.Count.EqualTo(8));

                var pair = new KeyValuePair<string, object>("TestKey", "TestValue");
                Assert.That(custom.Remove(pair), Is.True);
                Assert.That(custom, Has.Count.EqualTo(7));
                Assert.That(custom.Remove(pair), Is.False);

                custom.Add(pair);
                Assert.That(custom, Has.Count.EqualTo(8));

                var array = new KeyValuePair<string, object>[8];
                custom.CopyTo(array, 0);
            });


            var enumerator = custom.GetEnumerator();
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(new KeyValuePair<string, object>("% Complete", "0%")));

            enumerator.Reset();
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(new KeyValuePair<string, object>("% Complete", "0%")));

            var OldEnumerator = (custom as IEnumerable).GetEnumerator();
            Assert.That(OldEnumerator.MoveNext(), Is.True);
            Assert.That(OldEnumerator.Current, Is.EqualTo(new KeyValuePair<string, object>("% Complete", "0%")));

            foreach (var pair in custom)
            {
                Assert.That(pair.ToString(), Is.Not.Null);
            }


            custom.Clear();
            Assert.That(custom, Is.Empty);
        }

        [Test]
        public void SetterTests()
        {
            var project = new ProjectFile();
            var props = project.ProjectProperties;

            props.DefaultFixedCostAccrual = AccrueType.Prorated;

            props.ActualsInSync = true;
            props.AdminProject = true;
            props.AutoAddNewResourcesAndTasks = true;
            props.AutoFilter = true;
            props.Autolink = true;
            props.DefaultDurationIsFixed = true;
            props.EditableActualCosts = true;
            props.ExportFlag = true;
            props.FiscalYearStart = true;
            props.HonorConstraints = true;
            props.InsertedProjectsLikeSummary = true;
            props.MicrosoftProjectServerURL = true;
            props.MoveCompletedEndsBack = true;
            props.MoveCompletedEndsForward = true;
            props.MoveRemainingStartsBack = true;
            props.MoveRemainingStartsForward = true;
            props.MultipleCriticalPaths = true;
            props.NewTasksAreManual = true;
            props.NewTasksEffortDriven = true;
            props.NewTasksEstimated = true;
            props.NewTaskStartIsProjectStart = true;
            props.ProjectExternallyEdited = true;
            props.RemoveFileProperties = true;
            props.ShowProjectSummaryTask = true;
            props.SplitInProgressTasks = true;
            props.SpreadActualCost = true;
            props.SpreadPercentComplete = true;
            props.UpdatingTaskStatusUpdatesResourceStatus = true;

            props.DateSeparator = 'x';
            props.DecimalSeparator = 'x';
            props.MpxDelimiter = 'x';
            props.ThousandsSeparator = 'x';
            props.TimeSeparator = 'x';

            props.MpxCodePage = CodePage.ANSI;

            props.CriticalActivityType = CriticalActivityType.TotalFloat;

            props.SymbolPosition = CurrencySymbolPosition.Before;

            props.DateOrder = DateOrder.DMY;

            props.ActualFinish = DateTime.Now;
            props.ActualStart = DateTime.Now;
            props.BaselineDate = DateTime.Now;
            props.BaselineFinish = DateTime.Now;
            props.BaselineStart = DateTime.Now;
            props.CreationDate = DateTime.Now;
            props.CurrentDate = DateTime.Now;
            props.ExtendedCreationDate = DateTime.Now;
            props.FinishDate = DateTime.Now;
            props.LastPrinted = DateTime.Now;
            props.LastSaved = DateTime.Now;
            props.MustFinishBy = DateTime.Now;
            props.PlannedStart = DateTime.Now;
            props.ScheduledFinish = DateTime.Now;
            props.StartDate = DateTime.Now;
            props.StatusDate = DateTime.Now;

            props.WeekStartDay = DayOfWeek.Monday;

            props.ActualCost = 1.0;
            props.BaselineCost = 1.0;
            props.Cost = 1.0;
            props.PercentageComplete = 1.0;
            props.Work2 = 1.0;

            props.ActualDuration = Duration.GetInstance(1.0, TimeUnit.Days);
            props.ActualWork = Duration.GetInstance(1.0, TimeUnit.Days);
            props.BaselineDuration = Duration.GetInstance(1.0, TimeUnit.Days);
            props.BaselineWork = Duration.GetInstance(1.0, TimeUnit.Days);
            props.CriticalSlackLimit = Duration.GetInstance(1.0, TimeUnit.Days);
            props.Duration = Duration.GetInstance(1.0, TimeUnit.Days);
            props.FinishVariance = Duration.GetInstance(1.0, TimeUnit.Days);
            props.StartVariance = Duration.GetInstance(1.0, TimeUnit.Days);
            props.Work = Duration.GetInstance(1.0, TimeUnit.Days);

            props.DefaultTaskEarnedValueMethod = EarnedValueMethod.PercentComplete;
            props.EarnedValueMethod = EarnedValueMethod.PercentComplete;

            props.MpxFileVersion = FileVersion.Version4;

            props.GUID = Guid.NewGuid();

            props.ApplicationVersion = 1;
            props.BaselineForEarnedValue = 1;
            props.BaselineProjectUniqueID = 1;
            props.CurrencyDigits = 1;
            props.DaysPerMonth = 1;
            props.DefaultCalendarUniqueID = 1;
            props.EditingTime = 1;
            props.FiscalYearStartMonth = 1;
            props.LocationUniqueID = 1;
            props.MinutesPerDay = 1;
            props.MinutesPerMonth = 1;
            props.MinutesPerWeek = 1;
            props.MinutesPerYear = 1;
            props.MppFileType = 1;
            props.Revision = 1;
            props.UniqueID = 1;

            props.BarTextDateFormat = ProjectDateFormat.DD_MM_YY;
            props.DateFormat = ProjectDateFormat.DD_MM_YY;

            props.TimeFormat = ProjectTimeFormat.TwentyFourHour;

            props.DefaultOvertimeRate = new Rate(1, TimeUnit.Hours);
            props.DefaultStandardRate = new Rate(1, TimeUnit.Hours);

            props.ScheduleFrom = ScheduleFrom.Start;

            props.AMText = "baz";
            props.Author = "baz";
            props.Category = "baz";
            props.Comments = "baz";
            props.Company = "baz";
            props.ContentStatus = "baz";
            props.ContentType = "baz";
            props.CurrencyCode = "baz";
            props.CurrencySymbol = "baz";
            props.DocumentVersion = "baz";
            props.FileApplication = "baz";
            props.FileType = "baz";
            props.FullApplicationName = "baz";
            props.HyperlinkBase = "baz";
            props.Keywords = "baz";
            props.Language = "baz";
            props.LastAuthor = "baz";
            props.Manager = "baz";
            props.MpxProgramName = "baz";
            props.Name = "baz";
            props.PMText = "baz";
            props.PresentationFormat = "baz";
            props.ProjectFilePath = "baz";
            props.ProjectID = "baz";
            props.ProjectTitle = "baz";
            props.ResourcePoolFile = "baz";
            props.ShortApplicationName = "baz";
            props.Subject = "baz";
            props.Template = "baz";

            props.DefaultTaskType = TaskType.FixedWork;

            props.DefaultEndTime = new TimeOnly(17, 0);
            props.DefaultStartTime = new TimeOnly(8, 0);

            props.DefaultDurationUnits = TimeUnit.Hours;
            props.DefaultWorkUnits = TimeUnit.Hours;
        }
    }
}