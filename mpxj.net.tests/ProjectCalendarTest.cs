using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
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
    }
}

