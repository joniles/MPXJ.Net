using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class ResourceAssignmentContainerTest
    {
        [Test]
        public void MethodsTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);


            var container = project.ResourceAssignments;
            Assert.That(container.JavaObject, Is.Not.Null);
            Assert.That(container.PopulatedFields, Has.Count.EqualTo(22));
            Assert.That(container.PopulatedFields.Contains(AssignmentField.UniqueId), Is.True);
        }
    }
}
