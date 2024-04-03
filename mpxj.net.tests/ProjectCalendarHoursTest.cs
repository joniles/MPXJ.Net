
using System;
using NUnit.Framework;

namespace org.mpxj
{
    public class ProjectCalendarHoursTest
    {
        [Test]
        public void MethodsTest()
        {
            var project = new ProjectFile();
            var calendar = project.AddDefaultBaseCalendar();
            var hours = calendar.GetCalendarHours(DayOfWeek.Monday);
            Assert.That(hours, Has.Count.EqualTo(2));

            var range = hours[1];
            Assert.That(hours.IndexOf(range), Is.EqualTo(1));

            range = new LocalTimeRange(new TimeOnly(17, 0), new TimeOnly(20, 0));
            hours[1] = range;
            Assert.That(hours.IndexOf(range), Is.EqualTo(1));
        }
    }
}
