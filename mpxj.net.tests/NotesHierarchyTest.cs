using NUnit.Framework;

namespace MPXJ.Net
{
    public class NotesHierarchyTest
    {
        [Test]
        public void RtfNotesTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);
            Assert.That(project.Tasks[2].Notes, Is.EqualTo("Task 1 Notes"));
            Assert.That(project.Tasks[2].NotesObject, Is.TypeOf(typeof(RtfNotes)));
        }

        [Test]
        public void HtmlNotesTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);
            var account = project.CostAccounts[0];
            Assert.That(account.NotesObject, Is.TypeOf(typeof(HtmlNotes)));
        }

        [Test]
        public void ParentNotesTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);
            var task = project.Tasks[1];
            Assert.That(task.NotesObject, Is.TypeOf(typeof(ParentNotes)));
        }

        [Test]
        public void StructuredNotesTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);
            var task = project.Tasks[1];
            Assert.That(task.NotesObject, Is.TypeOf(typeof(ParentNotes)));
            var parentNotes = task.NotesObject as ParentNotes;
            var notes = parentNotes.ChildNotes[0];
            Assert.That(notes, Is.TypeOf(typeof(StructuredNotes)));
            var structuredNotes = notes as StructuredNotes;

            Assert.That(structuredNotes.NotesTopic.Name, Is.EqualTo("Anticipated Problems"));
            Assert.That(structuredNotes.Notes, Is.TypeOf(typeof(HtmlNotes)));
        }
    }
}
