
using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
    public class CustomFieldValueMaskTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xml");
            Assert.That(project, Is.Not.Null);

            var field = project.CustomFields.Get(TaskField.OutlineCode1);
            Assert.That(field.Masks, Has.Count.EqualTo(3));

            var mask = field.Masks[0];
            Assert.That(mask.Length, Is.EqualTo(2));
            Assert.That(mask.Level, Is.EqualTo(1));
            Assert.That(mask.Separator, Is.EqualTo("."));
            Assert.That(mask.Type, Is.EqualTo(CustomFieldValueDataType.Text));
            Assert.That(mask.ToString(), Contains.Substring("[CustomFieldValueMask"));

            var newMask = new CustomFieldValueMask(1, 1, ".", CustomFieldValueDataType.Text);
        }
    }
}
