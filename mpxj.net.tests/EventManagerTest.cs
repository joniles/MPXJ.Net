using NUnit.Framework;

namespace org.mpxj
{
    public class EventManagerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new ProjectFile();
            Assert.That(project.EventManager, Is.Not.Null);
            Assert.That(project.EventManager.JavaObject, Is.Not.Null);
        }
    }
}
