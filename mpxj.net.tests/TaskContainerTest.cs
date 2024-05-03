
using NUnit.Framework;

namespace MPXJ.Net
{
    public class TaskContainerTest
    {
        [Test]
        public void MethodsTest()
        {
            var project = new ProjectFile();
            var container = project.Tasks;
            Assert.That(container, Is.SameAs(project.Tasks));

            var task1 = project.AddTask();
            task1.Name = "Task 1";

            var task2 = container.Add();
            task2.Name = "Task 2";

            Assert.That(container.Count, Is.EqualTo(2));

            var task3 = task2.AddTask();
            task3.Name = "Resource 3";

            Assert.That(container.Count, Is.EqualTo(3));

            Assert.That(project.ChildTasks.Count, Is.EqualTo(2));
            Assert.That(task1.ChildTasks.Count, Is.EqualTo(0));
            Assert.That(task2.ChildTasks.Count, Is.EqualTo(1));
            Assert.That(task3.ChildTasks.Count, Is.EqualTo(0));

            Assert.That(container.PopulatedFields, Has.Count.EqualTo(7));
            Assert.That(container.PopulatedFields.Contains(TaskField.Name), Is.True);
        }

        [Test]
        public void CustomFieldTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var container = project.Tasks;
            Assert.That(container.GetFieldTypeByAlias("CustomFieldText1"), Is.EqualTo(TaskField.Text1));
        }
    }
}

