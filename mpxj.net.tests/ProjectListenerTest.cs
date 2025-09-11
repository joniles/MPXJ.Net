using NUnit.Framework;

namespace MPXJ.Net
{
    public class ProjectListenerTest
    {
        [Test]
        public void TestRead()
        {
            var listener = new TestListener();
            var reader = new UniversalProjectReader();
            reader.AddProjectListener(listener);
            reader.Read("TestData/Sample1.mpp");

            Assert.Multiple(() =>
            {
                Assert.That(listener.TaskCount, Is.EqualTo(15));
                Assert.That(listener.ResourceCount, Is.EqualTo(7));
                Assert.That(listener.CalendarCount, Is.EqualTo(9));
                Assert.That(listener.AssignmentCount, Is.EqualTo(10));
                Assert.That(listener.RelationCount, Is.EqualTo(6));
            });
        }
        
        private class TestListener : DefaultProjectListener
        {
            public int TaskCount { get; set; }
            public int ResourceCount { get; set; }
            public int CalendarCount { get; set; }
            public int AssignmentCount { get; set; }
            public int RelationCount { get; set; }

            public override void TaskRead(Task task) => TaskCount++;
            
            public override void ResourceRead(Resource resource) => ResourceCount++;
            
            public override void CalendarRead(ProjectCalendar calendar) => CalendarCount++;

            public override void AssignmentRead(ResourceAssignment assignment) => AssignmentCount++;

            public override void RelationRead(Relation relation) => RelationCount++;
        }
    }
}