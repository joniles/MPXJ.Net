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

            var convertedDuration = testDuration.ConvertUnits(TimeUnit.Hours, project.ProjectProperties);
            Assert.That(convertedDuration.DurationValue, Is.EqualTo(144));
            Assert.That(convertedDuration.Units, Is.EqualTo(TimeUnit.Hours));
            Assert.That(convertedDuration.ToString(), Is.EqualTo("144.0h"));

            var convertedDuration2 = Duration.ConvertUnits(project, 18.0, TimeUnit.Days, TimeUnit.Hours, project.ProjectProperties);
            Assert.That(convertedDuration2.DurationValue, Is.EqualTo(144));
            Assert.That(convertedDuration2.Units, Is.EqualTo(TimeUnit.Hours));
            Assert.That(convertedDuration2.ToString(), Is.EqualTo("144.0h"));

            var convertedDuration3 = Duration.ConvertUnits(project, 18.0, TimeUnit.Days, TimeUnit.Hours, 480.0, 2400.0, 20.0);
            Assert.That(convertedDuration3.DurationValue, Is.EqualTo(144));
            Assert.That(convertedDuration3.Units, Is.EqualTo(TimeUnit.Hours));
            Assert.That(convertedDuration3.ToString(), Is.EqualTo("144.0h"));

            var instance1 = Duration.GetInstance(project, 18, TimeUnit.Days);
            Assert.That(instance1.DurationValue, Is.EqualTo(18));
            Assert.That(instance1.Units, Is.EqualTo(TimeUnit.Days));
            Assert.That(instance1.ToString(), Is.EqualTo("18.0d"));

            var instance2 = Duration.GetInstance(project, 18.0, TimeUnit.Days);
            Assert.That(instance2.DurationValue, Is.EqualTo(18));
            Assert.That(instance2.Units, Is.EqualTo(TimeUnit.Days));
            Assert.That(instance2.ToString(), Is.EqualTo("18.0d"));

            Assert.That(Duration.DurationValueEquals(1.0, 1.0), Is.True);

            var add1 = Duration.GetInstance(project, 2.5, TimeUnit.Days);
            var add2 = Duration.GetInstance(project, 3.5, TimeUnit.Days);
            var addedDuration = Duration.Add(add1, add2, project.ProjectProperties);
            Assert.That(addedDuration.DurationValue, Is.EqualTo(6));
            Assert.That(addedDuration.Units, Is.EqualTo(TimeUnit.Days));
            Assert.That(addedDuration.ToString(), Is.EqualTo("6.0d"));
        }
    }
}

