using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class ProjectCalendarTest
    {
        [Test]
        public void DefaultCalendarTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var calendar = project.DefaultCalendar;
            Assert.Multiple(() =>
            {
                Assert.That(calendar.Name, Is.EqualTo("Standard"));
                Assert.That(calendar.MinutesPerDay, Is.EqualTo(480));
                Assert.That(calendar.MinutesPerWeek, Is.EqualTo(2400));
                Assert.That(calendar.MinutesPerMonth, Is.EqualTo(9600));
                Assert.That(calendar.MinutesPerYear, Is.EqualTo(115200));
                Assert.That(calendar.DaysPerMonth, Is.EqualTo(20));
                Assert.That(calendar.CalendarMinutesPerDay, Is.Null);
                Assert.That(calendar.CalendarMinutesPerWeek, Is.Null);
                Assert.That(calendar.CalendarMinutesPerMonth, Is.Null);
                Assert.That(calendar.CalendarMinutesPerYear, Is.Null);
                Assert.That(calendar.WorkWeeks, Has.Count.EqualTo(1));
                Assert.That(calendar.CalendarExceptions, Has.Count.EqualTo(3));
                Assert.That(calendar.UniqueID, Is.EqualTo(1));
                Assert.That(calendar.Parent, Is.Null);
                Assert.That(calendar.ParentUniqueID, Is.Null);
                Assert.That(calendar.Personal, Is.False);
                Assert.That(calendar.Type, Is.EqualTo(CalendarType.Global));
                Assert.That(calendar.Derived, Is.False);
                Assert.That(calendar.ParentFile, Is.EqualTo(project));
                Assert.That(calendar.ToString(), Contains.Substring("[ProjectCalendar"));
                Assert.That(calendar.DerivedCalendars, Has.Count.EqualTo(7));
                Assert.That(calendar.Tasks, Has.Count.EqualTo(0));
                Assert.That(calendar.ResourceCount, Is.EqualTo(0));
                Assert.That(calendar.Resources, Has.Count.EqualTo(0));

            });

            var week = calendar.WorkWeeks[0];
            Assert.Multiple(() =>
            {
                Assert.That(week.Name, Is.EqualTo("Test Week"));
                Assert.That(week.DateRange, Is.EqualTo(new LocalDateRange(new DateOnly(2025, 1, 13), new DateOnly(2025, 1, 17))));
                Assert.That(week.DefaultWorkingMorning, Is.EqualTo(new LocalTimeRange(new TimeOnly(8, 0), new TimeOnly(12, 0))));
                Assert.That(week.DefaultWorkingAfternoon, Is.EqualTo(new LocalTimeRange(new TimeOnly(13, 0), new TimeOnly(17, 0))));
            });

            var exception = calendar.CalendarExceptions[0];
            Assert.Multiple(() =>
            {
                Assert.That(exception.Name, Is.EqualTo("Nonworking Exception"));
                Assert.That(exception.FromDate, Is.EqualTo(new DateOnly(2025, 1, 20)));
                Assert.That(exception.ToDate, Is.EqualTo(new DateOnly(2025, 1, 20)));
                Assert.That(exception.Recurring, Is.Null);
                Assert.That(exception.Working, Is.False);
                Assert.That(exception, Has.Count.EqualTo(0));
            });

            exception = calendar.CalendarExceptions[1];
            Assert.Multiple(() =>
            {
                Assert.That(exception.Name, Is.EqualTo("Working Exception"));
                Assert.That(exception, Has.Count.EqualTo(1));
                Assert.That(exception[0], Is.EqualTo(new LocalTimeRange(new TimeOnly(8, 0), new TimeOnly(12, 0))));
            });

            var recurring = calendar.CalendarExceptions[2].Recurring;
            Assert.That(recurring, Is.Not.Null);

            var expanded = calendar.ExpandedCalendarExceptions;
            Assert.That(expanded, Has.Count.EqualTo(6));


            var resourceCalendar = calendar.DerivedCalendars[1];
            Assert.That(resourceCalendar.Derived, Is.True);
            Assert.That(resourceCalendar.ParentUniqueID, Is.EqualTo(1));
            Assert.That(resourceCalendar.Parent, Is.EqualTo(calendar));
        }

        [Test]
        public void AddCalendarTests()
        {
            var project = new ProjectFile();
            var calendar = project.AddDefaultBaseCalendar();

            calendar.CalendarMinutesPerDay = 480;
            Assert.That(calendar.CalendarMinutesPerDay, Is.EqualTo(480));

            calendar.CalendarMinutesPerWeek = 2400;
            Assert.That(calendar.CalendarMinutesPerWeek, Is.EqualTo(2400));

            calendar.CalendarMinutesPerMonth = 9600;
            Assert.That(calendar.CalendarMinutesPerMonth, Is.EqualTo(9600));

            calendar.CalendarMinutesPerYear = 115200;
            Assert.That(calendar.CalendarMinutesPerYear, Is.EqualTo(115200));

            var week1 = calendar.AddWorkWeek();
            var week2 = calendar.AddWorkWeek();
            Assert.That(calendar.WorkWeeks, Has.Count.EqualTo(2));

            week1.Name = "Week 1";
            Assert.That(week1.Name, Is.EqualTo("Week 1"));

            week1.AddDefaultCalendarDays();
            Assert.That(week1.GetCalendarDayType(DayOfWeek.Monday), Is.EqualTo(DayType.Working));

            week1.AddDefaultCalendarHours(DayOfWeek.Monday);
            Assert.That(week1.GetCalendarHours(DayOfWeek.Monday), Has.Count.EqualTo(2));

            week1.RemoveCalendarHours(DayOfWeek.Monday);
            Assert.That(week1.GetCalendarHours(DayOfWeek.Tuesday), Is.Null);

            week1.AddDefaultCalendarHours();
            Assert.That(week1.GetCalendarHours(DayOfWeek.Tuesday), Has.Count.EqualTo(2));

            Assert.That(week1.ToString(), Contains.Substring("[ProjectCalendarWeek"));

            calendar.RemoveWorkWeek(week1);
            Assert.That(calendar.WorkWeeks, Has.Count.EqualTo(1));

            calendar.ClearWorkWeeks();
            Assert.That(calendar.WorkWeeks, Is.Empty);

            calendar.Type = CalendarType.Project;
            Assert.That(calendar.Type, Is.EqualTo(CalendarType.Project));

            calendar.Personal = true;
            Assert.That(calendar.Personal, Is.True);

            calendar.UniqueID = 999;
            Assert.That(calendar.UniqueID, Is.EqualTo(999));

            var derived = project.AddDefaultDerivedCalendar();
            derived.Parent = calendar;

            Assert.That(derived.Parent, Is.EqualTo(calendar));
            Assert.That(derived.ParentUniqueID, Is.EqualTo(999));

            var exceptionDate = new DateOnly(2024, 4, 15);
            Assert.That(calendar.GetWork(exceptionDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(8, TimeUnit.Hours)));
            var exception = calendar.AddCalendarException(exceptionDate);
            Assert.That(calendar.GetWork(exceptionDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(0, TimeUnit.Hours)));
            Assert.That(calendar.GetException(exceptionDate), Is.EqualTo(exception));
            calendar.RemoveCalendarException(exception);
            Assert.That(calendar.GetWork(exceptionDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(8, TimeUnit.Hours)));

            var exceptionStartDate = new DateTime(2024, 4, 16, 8, 0, 0);
            var exceptionEndDate = new DateTime(2024, 4, 17, 17, 0, 0);
            Assert.That(calendar.GetWork(exceptionStartDate, exceptionEndDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(16, TimeUnit.Hours)));
            calendar.AddCalendarException(DateOnly.FromDateTime(exceptionStartDate), DateOnly.FromDateTime(exceptionEndDate));
            Assert.That(calendar.GetWork(exceptionStartDate, exceptionEndDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(0, TimeUnit.Hours)));

            calendar.ClearCalendarExceptions();
            Assert.That(calendar.GetWork(exceptionStartDate, exceptionEndDate, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(16, TimeUnit.Hours)));

            var recurring = new RecurringData
            {
                StartDate = new DateOnly(2024, 4, 22),
                FinishDate = new DateOnly(2024, 5, 6),
                Frequency = 1,
                RecurrenceType = RecurrenceType.Weekly,
                Occurrences = 3
            };

            exception = calendar.AddCalendarException(recurring);
            Assert.That(exception.Recurring, Is.Not.Null);


            calendar.ClearCalendarExceptions();
            Assert.That(calendar.GetStartTime(new DateOnly(2024, 4, 15)), Is.EqualTo(new TimeOnly(8, 0)));
            Assert.That(calendar.GetFinishTime(new DateOnly(2024, 4, 15)), Is.EqualTo(new TimeOnly(17, 0)));
            Assert.That(calendar.GetDate(new DateTime(2024, 4, 15, 8, 0, 0), Duration.GetInstance(12, TimeUnit.Hours)), Is.EqualTo(new DateTime(2024, 4, 16, 12, 0, 0)));
            Assert.That(calendar.GetNextWorkStart(new DateTime(2024, 4, 15, 17, 0, 0)), Is.EqualTo(new DateTime(2024, 4, 16, 8, 0, 0)));
            Assert.That(calendar.GetPreviousWorkFinish(new DateTime(2024, 4, 16, 8, 0, 0)), Is.EqualTo(new DateTime(2024, 4, 15, 17, 0, 0)));
            Assert.That(calendar.GetDayType(DayOfWeek.Monday), Is.EqualTo(DayType.Working));
            Assert.That(calendar.IsWorkingDay(DayOfWeek.Monday), Is.True);
            Assert.That(calendar.IsWorkingDate(new DateOnly(2024, 4, 15)), Is.True);

            var hours = calendar.GetHours(DayOfWeek.Monday);
            Assert.That(hours, Has.Count.EqualTo(2));

            hours = calendar.GetHours(new DateOnly(2024, 4, 15));
            Assert.That(hours, Has.Count.EqualTo(2));

            hours = calendar.GetHours(new DateTime(2024, 4, 15, 8, 0, 0));
            Assert.That(hours, Has.Count.EqualTo(2));

            var week = calendar.AddWorkWeek();
            week.DateRange = new LocalDateRange(new DateOnly(2024, 4, 22), new DateOnly(2024, 4, 26));
            Assert.That(calendar.GetWorkWeek(new DateOnly(2024, 4, 22)), Is.EqualTo(week));
            Assert.That(calendar.GetWork(DayOfWeek.Monday, TimeUnit.Hours), Is.EqualTo(Duration.GetInstance(8, TimeUnit.Hours)));

            calendar.Remove();
        }
    }
}
