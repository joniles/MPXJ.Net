using NUnit.Framework;

namespace MPXJ.Net
{
    public class RelationContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Relations, Has.Count.EqualTo(6));
            Assert.That(project.Relations.JavaObject, Is.Not.Null);

            var relation = project.Relations[0];
            Assert.Multiple(() =>
            {
                Assert.That(relation.SourceTask.UniqueID, Is.EqualTo(4));
                Assert.That(relation.TargetTask.UniqueID, Is.EqualTo(3));
                Assert.That(relation.Type, Is.EqualTo(RelationType.FinishStart));
                Assert.That(relation.Lag, Is.EqualTo(Duration.GetInstance(1, TimeUnit.Days)));
                Assert.That(relation.UniqueID, Is.EqualTo(1));
                Assert.That(relation.ToString(), Contains.Substring("[Relation "));
            });

            var task1 = project.Tasks.GetByUniqueID(4);
            var task2 = project.Tasks.GetByUniqueID(3);

            Assert.That(task1.Predecessors, Has.Count.EqualTo(1));
            Assert.That(task1.IsPredecessor(task2));
            
            Assert.That(task2.Successors, Has.Count.EqualTo(1));
            Assert.That(task2.IsSuccessor(task1));
        }
    }
}
