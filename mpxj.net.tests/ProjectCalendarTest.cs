using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class ProjectCalendarTest
    {
        [Test]
        public void MethodTest()
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
            });

            Assert.That(calendar.WorkWeeks, Has.Count.EqualTo(1));
            var week = calendar.WorkWeeks[0];
            Assert.That(week.Name, Is.EqualTo("Test Week"));
            Assert.That(week.DateRange, Is.EqualTo(new LocalDateRange(new DateOnly(2025, 1, 13), new DateOnly(2025, 1, 17))));
            Assert.That(week.DefaultWorkingMorning, Is.EqualTo(new LocalTimeRange(new TimeOnly(8, 0), new TimeOnly(12, 0))));
            Assert.That(week.DefaultWorkingAfternoon, Is.EqualTo(new LocalTimeRange(new TimeOnly(13, 0), new TimeOnly(17, 0))));

            Assert.That(calendar.CalendarExceptions, Has.Count.EqualTo(3));
        }
    }
}

