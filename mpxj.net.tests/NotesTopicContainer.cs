using NUnit.Framework;

namespace MPXJ.Net
{
    public class NotesTopicContainer
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.NotesTopics, Has.Count.EqualTo(2));
            Assert.That(project.NotesTopics.JavaObject, Is.Not.Null);
            Assert.That(project.NotesTopics.DefaultTopic.Name, Is.EqualTo("Notes"));

            var topic = project.NotesTopics[0];
            Assert.Multiple(() =>
            {
                Assert.That(topic.AvailableForActivity, Is.True);
                Assert.That(topic.AvailableForEPS, Is.True);
                Assert.That(topic.AvailableForProject, Is.True);
                Assert.That(topic.AvailableForWBS, Is.True);
                Assert.That(topic.Name, Is.EqualTo("Anticipated Problems"));
                Assert.That(topic.SequenceNumber, Is.EqualTo(10));
                Assert.That(topic.UniqueID, Is.EqualTo(30));
            });
        }
    }
}

