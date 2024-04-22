using NUnit.Framework;

namespace MPXJ.Net
{
    public class NotesTest
    {
        [Test]
        public void TextNotes()
        {
            var notes = new Notes("hello");
            Assert.That(notes.ToString(), Is.EqualTo("hello"));
            Assert.That(notes.Empty, Is.False);
        }
    }
}
