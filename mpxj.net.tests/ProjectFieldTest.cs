
using NUnit.Framework;

namespace MPXJ.Net
{
	public class ProjectFieldTest
	{
        [Test]
        public void TestPropertiesAndMethods()
        {
            Assert.Multiple(() =>
            {
                Assert.That(ProjectField.StartDate.FieldTypeClass, Is.EqualTo(FieldTypeClass.Project));
                Assert.That(ProjectField.StartDate.FieldName, Is.EqualTo("Start Date"));
                Assert.That(ProjectField.StartDate.DataType, Is.EqualTo(DataType.Date));
                Assert.That(ProjectField.StartDate.ToString(), Is.EqualTo("Start Date"));
            });
        }
    }
}
