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

            var task1 = project.Tasks.GetByUniqueID(3);
            var task2 = project.Tasks.GetByUniqueID(4);
            var relation = task2.Predecessors[0];

            Assert.Multiple(() =>
            {
                Assert.That(relation.PredecessorTask.UniqueID, Is.EqualTo(task1.UniqueID));
                Assert.That(relation.SuccessorTask.UniqueID, Is.EqualTo(task2.UniqueID));
                Assert.That(relation.Type, Is.EqualTo(RelationType.FinishStart));
                Assert.That(relation.Lag, Is.EqualTo(Duration.GetInstance(1, TimeUnit.Days)));
                Assert.That(relation.UniqueID, Is.EqualTo(1));
                Assert.That(relation.ToString(), Contains.Substring("[Relation "));
            });


            Assert.That(task2.Predecessors, Has.Count.EqualTo(1));
            Assert.That(task2.IsPredecessor(task1));
            
            Assert.That(task1.Successors, Has.Count.EqualTo(1));
            Assert.That(task1.IsSuccessor(task2));
        }
    }
}
