using NUnit.Framework;
using System.IO;

namespace MPXJ.Net
{
    public class UniversalProjectReaderTests
    {
        [Test]
        public void ReadMethodTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            // While we're here, retrieve some ProxyList attributes from the project
            // to ensure that caching is working as expected, particularly for Collections.emptyList().
            foreach(var task in project.Tasks)
            {
                Assert.That(task.ToString(), Is.Not.Null);
                foreach (var relation in task.Predecessors)
                {
                    Assert.That(relation.ToString(), Is.Not.Null);
                }

                foreach (var assignment in task.ResourceAssignments)
                {
                    Assert.That(assignment.ToString(), Is.Not.Null);
                }
            }
            
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

        [Test]
        public void ProjectReaderProxyTests()
        {
            var reader = new UniversalProjectReader();

            using (var proxy = reader.GetProjectReaderProxy("TestData/Sample1.mpp"))
            {
                Assert.That(proxy.ProjectReader, Is.TypeOf(typeof(MPPReader)));
                var project = proxy.Read();
                Assert.That(project, Is.Not.Null);
            }

            using (var proxy = reader.GetProjectReaderProxy("TestData/Sample1.mpp"))
            {
                Assert.That(proxy.ProjectReader, Is.TypeOf(typeof(MPPReader)));
                var projectList = proxy.ReadAll();
                Assert.That(projectList, Has.Count.EqualTo(1));
            }

            using (var proxy = reader.GetProjectReaderProxy("TestData/Sample1.xer"))
            {
                Assert.That(proxy.ProjectReader, Is.TypeOf(typeof(PrimaveraXERFileReader)));
                var project = proxy.Read();
                Assert.That(project, Is.Not.Null);
            }

            using (var proxy = reader.GetProjectReaderProxy("TestData/Sample1.xer"))
            {
                Assert.That(proxy.ProjectReader, Is.TypeOf(typeof(PrimaveraXERFileReader)));
                var projectList = proxy.ReadAll();
                Assert.That(projectList, Has.Count.EqualTo(1));
            }
        }
    }
}
