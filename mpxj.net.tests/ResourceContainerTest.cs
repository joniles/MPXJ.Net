using NUnit.Framework;

namespace MPXJ.Net
{
    public class ResourceContainerTest
    {
        [Test]
        public void TestResourceContainer()
        {
            var project = new ProjectFile();
            var container = project.Resources;
            Assert.That(container, Is.SameAs(project.Resources));

            var resource1 = project.AddResource();
            resource1.Name = "Resource 1";

            var resource2 = container.Add();
            resource2.Name = "Resource 2";

            Assert.That(container.Count, Is.EqualTo(2));

            var resource3 = resource2.AddResource();
            resource3.Name = "Resource 3";

            Assert.That(container.Count, Is.EqualTo(3));

            Assert.That(project.ChildResources.Count, Is.EqualTo(2));
            Assert.That(resource1.ChildResources.Count, Is.EqualTo(0));
            Assert.That(resource2.ChildResources.Count, Is.EqualTo(1));
            Assert.That(resource3.ChildResources.Count, Is.EqualTo(0));

            Assert.That(container.PopulatedFields, Has.Count.EqualTo(4));
            Assert.That(container.PopulatedFields.Contains(ResourceField.Name), Is.True);
        }

        [Test]
        public void CustomFieldTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var container = project.Resources;
            Assert.That(container.GetFieldTypeByAlias("CustomText1"), Is.EqualTo(ResourceField.Text1));
        }
    }
}

