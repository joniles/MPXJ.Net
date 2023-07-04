
using NUnit.Framework;

namespace org.mpxj
{
	public class TaskContainerTest
	{
        [Test]
        public void TestResourceContainer()
        {
            var project = new ProjectFile();
            var container = project.Tasks;
            Assert.That(container, Is.SameAs(project.Tasks));

            var task1 = project.AddTask();
            task1.Name = "Task 1";

            var task2 = project.AddTask();
            task2.Name = "Task 2";

            Assert.That(container.Count, Is.EqualTo(2));

            var task3 = task2.AddTask();
            task3.Name = "Resource 3";

            Assert.That(container.Count, Is.EqualTo(3));

            Assert.That(project.ChildTasks.Count, Is.EqualTo(2));
            Assert.That(task1.ChildTasks.Count, Is.EqualTo(0));
            Assert.That(task2.ChildTasks.Count, Is.EqualTo(1));
            Assert.That(task3.ChildTasks.Count, Is.EqualTo(0));
        }
    }
}

