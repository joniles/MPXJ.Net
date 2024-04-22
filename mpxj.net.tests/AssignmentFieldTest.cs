using NUnit.Framework;

namespace MPXJ.Net
{
	public class AssignmentFieldTest
	{
        [Test]
        public void TestPropertiesAndMethods()
        {
            Assert.Multiple(() =>
            {
                Assert.That(AssignmentField.Start.FieldTypeClass, Is.EqualTo(FieldTypeClass.Assignment));
                Assert.That(AssignmentField.Start.FieldName, Is.EqualTo("Start"));
                Assert.That(AssignmentField.Start.DataType, Is.EqualTo(DataType.Date));
                Assert.That(AssignmentField.Start.ToString(), Is.EqualTo("Start"));
            });
        }
    }
}

