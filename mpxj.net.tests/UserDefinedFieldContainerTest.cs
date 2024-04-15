using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class UserDefinedFieldContainerTest
    {
        [Test]
        public void MethodTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.UserDefinedFields.TaskFields, Has.Count.EqualTo(2));
            Assert.That(project.UserDefinedFields.ResourceFields, Has.Count.EqualTo(0));
            Assert.That(project.UserDefinedFields.AssignmentFields, Has.Count.EqualTo(0));
            Assert.That(project.UserDefinedFields.ProjectFields, Has.Count.EqualTo(0));
        }
    }
}
