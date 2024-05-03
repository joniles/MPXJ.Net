using NUnit.Framework;
using System.IO;

namespace MPXJ.Net
{
    public class UniversalProjectReaderTests
    {
        [Test]
        public void Test1()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var config = project.ProjectConfig;
            Assert.That(config, Is.Not.Null);

            var projects = new UniversalProjectReader().ReadAll("TestData/Sample1.xml");
            Assert.That(projects, Has.Count.EqualTo(1));

            using (var stream1 = new FileStream("TestData/Sample1.mpp", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                project = new UniversalProjectReader().Read(stream1);
                Assert.That(project, Is.Not.Null);
            }

            using (var stream2 = new FileStream("TestData/Sample1.xer", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                projects = new UniversalProjectReader().ReadAll(stream2);
                Assert.That(projects, Has.Count.EqualTo(1));
            }
        }
    }
}
