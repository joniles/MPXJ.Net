using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class GroupContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Groups, Has.Count.EqualTo(3));
        }
    }
}
