using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
	public class LocationContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Locations, Has.Count.EqualTo(0));
        }
    }
}

