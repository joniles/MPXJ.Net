using NUnit.Framework;

namespace MPXJ.Net
{
    public class EpsTest
    {
        [Test]
        public void MethodTest()
        {
            var reader = new PrimaveraDatabaseFileReader();
            var eps = reader.ListEPS("TestData/Sample.db");
            Assert.That(eps.EpsNodes, Has.Count.EqualTo(4));
            Assert.That(eps.EpsProjectNodes, Has.Count.EqualTo(4));

            var rootNode = eps.RootEpsNode;
            Assert.That(rootNode.Name, Is.EqualTo("Enterprise"));
            Assert.That(rootNode.ShortName, Is.EqualTo("EPS"));

            var childNodes = rootNode.ChildEpsNodes;
            Assert.That(childNodes, Has.Count.EqualTo(3));

            var eps1 = childNodes[0];
            Assert.That(eps1.Name, Is.EqualTo("EPS One"));
            Assert.That(eps1.ShortName, Is.EqualTo("EPS 1"));
            Assert.That(eps1.UniqueId, Is.EqualTo(3680));
            Assert.That(eps1.ParentUniqueId, Is.EqualTo(3667));
            Assert.That(eps1.ChildEpsNodes, Has.Count.EqualTo(0));

            var projects = eps1.EpsProjectNodes;
            Assert.That(projects, Has.Count.EqualTo(2));

            var project = projects[0];
            Assert.That(project.ShortName, Is.EqualTo("PROJ2"));
            Assert.That(project.Name, Is.EqualTo("Project 2"));
            Assert.That(project.UniqueId, Is.EqualTo(373));
            Assert.That(project.ParentEpsUniqueId, Is.EqualTo(3680));
            
            Assert.That(eps.GetEpsNodeByUniqueId(3680), Is.EqualTo(eps1));
            Assert.That(eps.GetProjectNodeByUniqueId(373), Is.EqualTo(project));
        }
    }
}