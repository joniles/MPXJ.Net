using NUnit.Framework;

namespace MPXJ.Net
{
	public class CalendarContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Calendars, Has.Count.EqualTo(9));
        }
    }
}

