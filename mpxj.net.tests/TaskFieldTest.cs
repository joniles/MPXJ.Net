using NUnit.Framework;

namespace org.mpxj
{
	public class TaskFieldTest
	{
        [Test]
        public void TestPropertiesAndMethods()
        {
            Assert.Multiple(() =>
            {
                Assert.That(TaskField.Start.FieldTypeClass, Is.EqualTo(FieldTypeClass.Task));
                Assert.That(TaskField.Start.FieldName, Is.EqualTo("Start"));
                Assert.That(TaskField.Start.DataType, Is.EqualTo(DataType.Date));
                Assert.That(TaskField.Start.ToString(), Is.EqualTo("Start"));
            });
        }
    }
}

