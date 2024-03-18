using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class RelationContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);


            Assert.That(project.Relations, Has.Count.EqualTo(6));
        }
    }
}
