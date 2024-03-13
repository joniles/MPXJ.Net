using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class DataLinkContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var container = project.DataLinks;
            Assert.That(container, Is.Not.Null);
        }
    }
}
