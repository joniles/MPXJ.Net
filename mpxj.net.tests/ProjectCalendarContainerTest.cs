using NUnit.Framework;

namespace MPXJ.Net
{
    public class ProjectCalendarContainerTest
    {
        [Test]
        public void MethodTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var calendar = project.Calendars.Add();
            Assert.That(calendar, Is.Not.Null);

            calendar = project.Calendars.AddDefaultBaseCalendar();
            Assert.That(calendar, Is.Not.Null);

            calendar = project.Calendars.AddDefaultDerivedCalendar();
            Assert.That(calendar, Is.Not.Null);

            calendar = project.Calendars.FindOrCreateDefaultCalendar();
            Assert.That(calendar.Name, Is.EqualTo("Standard"));

            calendar = project.Calendars.GetByName("Standard");
            Assert.That(calendar.Name, Is.EqualTo("Standard"));
        }
    }
}
