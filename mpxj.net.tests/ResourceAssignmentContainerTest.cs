using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
    public class ResourceAssignmentContainerTest
    {
        [Test]
        public void MethodTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);


            var container = project.ResourceAssignments;
            Assert.That(container.JavaObject, Is.Not.Null);
            Assert.That(container.PopulatedFields, Has.Count.EqualTo(22));
            Assert.That(container.PopulatedFields.Contains(AssignmentField.UniqueId), Is.True);
            Assert.That(container.CustomFields, Has.Count.EqualTo(0));
            Assert.That(container.GetFieldTypeByAlias("foo"), Is.Null);
        }
    }
}
