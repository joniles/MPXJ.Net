using NUnit.Framework;

namespace org.mpxj
{
	public class ConstraintFieldTest
	{
        [Test]
        public void TestPropertiesAndMethods()
        {
            Assert.Multiple(() =>
            {
                Assert.That(ConstraintField.UniqueId.FieldTypeClass, Is.EqualTo(FieldTypeClass.Constraint));
                Assert.That(ConstraintField.UniqueId.FieldName, Is.EqualTo("Unique ID"));
                Assert.That(ConstraintField.UniqueId.DataType, Is.EqualTo(DataType.Integer));
                Assert.That(ConstraintField.UniqueId.ToString(), Is.EqualTo("Unique ID"));
            });
        }
    }
}

