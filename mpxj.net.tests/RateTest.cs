using NUnit.Framework;

namespace org.mpxj
{
	public class RateTest
	{
        [Test]
        public void MethodTest()
        {
            var rate = new Rate(8, TimeUnit.Hours);
            Assert.Multiple(() =>
            {
                Assert.That(rate.Amount, Is.EqualTo(8));
                Assert.That(rate.Units, Is.EqualTo(TimeUnit.Hours));
                Assert.That(rate.ToString(), Is.EqualTo("8.0h"));
            });
        }
    }
}

