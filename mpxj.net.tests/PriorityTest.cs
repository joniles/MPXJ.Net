using NUnit.Framework;

namespace org.mpxj
{
	public class PriorityTest
	{
        [Test]
        public void MethodTest()
        {
            var priority = Priority.GetInstance(123);
            Assert.That(priority.Value, Is.EqualTo(123));
            Assert.That(priority.ToString(), Is.EqualTo("[Priority value=123]"));

            // Coverage
            Assert.That(Priority.Lowest, Is.EqualTo(100));
            Assert.That(Priority.VeryLow, Is.EqualTo(200));
            Assert.That(Priority.Lower, Is.EqualTo(300));
            Assert.That(Priority.Low, Is.EqualTo(400));
            Assert.That(Priority.Medium, Is.EqualTo(500));
            Assert.That(Priority.High, Is.EqualTo(600));
            Assert.That(Priority.Higher, Is.EqualTo(700));
            Assert.That(Priority.VeryHigh, Is.EqualTo(800));
            Assert.That(Priority.Highest, Is.EqualTo(900));
            Assert.That(Priority.DoNotLevel, Is.EqualTo(1000));
        }
    }
}

