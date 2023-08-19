using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class TaskTest
    {
        [Test]
        public void PropertyGetTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);
            foreach (var task in project.Tasks)
            {
                TestTask(task);
            }
        }

        private void TestTask(Task task)
        {
            Assert.Multiple(() =>
            {
//                Assert.That(resource.Start, Is.EqualTo(resource.Get(ResourceField.Start)));
            });
        }
    }
}
