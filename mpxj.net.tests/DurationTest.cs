using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class DurationTest
    {

        [Test]
        public void MethodsTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);
            var task = project.GetTaskByID(1);
            Assert.That(task.Name, Is.EqualTo("Summary Task 1"));

            var duration = task.Duration;
            Assert.That(duration.DurationValue, Is.EqualTo(18));
            Assert.That(duration.Units, Is.EqualTo(TimeUnit.Days));
            Assert.That(duration.ToString(), Is.EqualTo("18.0d"));

            var testDuration = Duration.GetInstance(project, 18.0, TimeUnit.Days);
            Assert.That(duration.DurationComponentEquals(testDuration), Is.True);
        }
    }
}

