using NUnit.Framework;

namespace MPXJ.Net
{
	public class ViewContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Views, Has.Count.EqualTo(5));


            var state = project.Views.ViewState;
            Assert.Multiple(() =>
            {
                Assert.That(state.ViewName, Is.EqualTo("Gantt Chart"));
                Assert.That(state.UniqueIdList, Has.Count.EqualTo(12));
                Assert.That(state.Filter.Name, Is.EqualTo("All Tasks"));
            });
        }
    }
}

