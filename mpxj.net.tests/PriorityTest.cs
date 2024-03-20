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
        }
    }
}

