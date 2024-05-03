
using NUnit.Framework;

namespace MPXJ.Net
{
    public class StepTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            var task = project.Tasks[1];
            Assert.That(task.Steps, Has.Count.EqualTo(2));

            var step = task.Steps[0];
            Assert.That(step.Complete, Is.True);
            Assert.That(step.Description, Is.EqualTo("Step 1 notes"));
            Assert.That(step.DescriptionObject.ToString(), Contains.Substring("Step 1 notes"));
            Assert.That(step.Name, Is.EqualTo("Step 1"));
            Assert.That(step.PercentComplete, Is.EqualTo(100.0));
            Assert.That(step.SequenceNumber, Is.EqualTo(0));
            Assert.That(step.Task, Is.EqualTo(task));
            Assert.That(step.UniqueID, Is.EqualTo(5743));
            Assert.That(step.Weight, Is.EqualTo(1));
        }
    }
}
