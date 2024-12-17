using NUnit.Framework;

namespace MPXJ.Net
{
	public class ActivityCodeTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.ActivityCodes, Has.Count.EqualTo(3));
            Assert.That(project.ActivityCodes.JavaObject, Is.Not.Null);

            var code = project.ActivityCodes[0];
            Assert.That(code.UniqueID, Is.EqualTo(205));
            Assert.That(code.Name, Is.EqualTo("Activity Code 1"));
            Assert.That(code.Scope, Is.EqualTo(ActivityCodeScope.Global));
            Assert.That(code.MaxLength, Is.EqualTo(7));
            Assert.That(code.ScopeEpsUniqueID, Is.Null);
            Assert.That(code.ScopeProjectUniqueID, Is.Null);
            Assert.That(code.Secure, Is.False);
            Assert.That(code.SequenceNumber, Is.EqualTo(0));

            Assert.That(code.ChildValues, Has.Count.EqualTo(2));
            Assert.That(code.Values, Has.Count.EqualTo(2));

            var value = code.Values[0];
            Assert.That(value.ParentCode, Is.EqualTo(code));
            Assert.That(value.UniqueID, Is.EqualTo(3174));
            Assert.That(value.SequenceNumber, Is.EqualTo(0));
            Assert.That(value.Name, Is.EqualTo("AAA"));
            Assert.That(value.Description, Is.EqualTo("Value AAA"));
            Assert.That(value.Color.ToString(), Is.EqualTo("Color [A=255, R=0, G=0, B=255]"));
            Assert.That(value.ParentValue, Is.Null);
            Assert.That(value.ParentValueUniqueId, Is.Null);
            Assert.That(value.ChildValues, Is.Empty);
            Assert.That(value.ToString(), Is.EqualTo("Activity Code 1: AAA"));
        }
    }
}

