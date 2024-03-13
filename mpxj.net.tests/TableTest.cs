using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class TableTest
    {
        [Test]
        public void GeneralTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Tables, Has.Count.EqualTo(3));

            var table = project.Tables[0];
            Assert.That(table.ID, Is.EqualTo(1));
            Assert.That(table.Name, Is.EqualTo("Entry"));
            Assert.That(table.ResourceFlag, Is.False);
            Assert.That(table.ToString(), Contains.Substring("[TABLE id=1 name=Entry"));

            Assert.That(table.Columns, Has.Count.EqualTo(11));

            var column = table.Columns[0];
            Assert.That(column.AlignData, Is.EqualTo(2));
            Assert.That(column.AlignTitle, Is.EqualTo(1));
            Assert.That(column.FieldType, Is.EqualTo(TaskField.Id));
            Assert.That(column.Title, Is.EqualTo("ID"));
            Assert.That(column.Width, Is.EqualTo(6));
            Assert.That(column.ToString(), Contains.Substring("[Column type=ID width=6"));
        }
    }
}
