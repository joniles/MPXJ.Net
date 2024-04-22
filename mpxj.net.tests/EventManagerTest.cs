using NUnit.Framework;

namespace MPXJ.Net
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
