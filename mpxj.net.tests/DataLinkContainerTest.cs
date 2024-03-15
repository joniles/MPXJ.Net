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

            Assert.That(project.DataLinks.JavaObject, Is.Not.Null);
            Assert.That(project.DataLinks, Has.Count.EqualTo(2));

            var link = project.DataLinks[1];
            Assert.Multiple(() =>
            {
                Assert.That(link.ID, Is.EqualTo("C:\\Users\\Jon\\Desktop\\Sample1.mpp!LINK_2"));
                Assert.That(link.SourceField, Is.EqualTo(TaskField.Text3));
                Assert.That(link.TargetField, Is.EqualTo(TaskField.Text4));
                Assert.That(link.SourceUniqueID, Is.EqualTo(3));
                Assert.That(link.TargetUniqueID, Is.EqualTo(3));
                Assert.That(link.ToString(), Contains.Substring("[DataLink"));
            });
        }
    }
}
