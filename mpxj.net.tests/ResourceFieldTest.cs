using NUnit.Framework;

namespace org.mpxj
{
	public class ResourceFieldTest
	{
        [Test]
        public void TestPropertiesAndMethods()
        {
            Assert.Multiple(() =>
            {
                Assert.That(ResourceField.Start.FieldTypeClass, Is.EqualTo(FieldTypeClass.Resource));
                Assert.That(ResourceField.Start.FieldName, Is.EqualTo("Start"));
                Assert.That(ResourceField.Start.DataType, Is.EqualTo(DataType.Date));
                Assert.That(ResourceField.Start.ToString(), Is.EqualTo("Start"));
            });
        }
    }
}

