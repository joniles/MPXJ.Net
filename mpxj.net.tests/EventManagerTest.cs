using NUnit.Framework;

namespace MPXJ.Net
{
    public class EventManagerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new ProjectFile();
            Assert.That(project.Calendars, Is.Not.Null);
            Assert.That(project.Calendars.JavaObject, Is.Not.Null);
        }
    }
}
