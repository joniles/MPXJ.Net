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
            Assert.That(calendar.Name, Is.EqualTo("Standard"));
            Assert.That(calendar.MinutesPerDay, Is.EqualTo(480));
            Assert.That(calendar.MinutesPerWeek, Is.EqualTo(2400));
            Assert.That(calendar.MinutesPerMonth, Is.EqualTo(9600));
            Assert.That(calendar.MinutesPerYear, Is.EqualTo(115200));
        }
    }
}

