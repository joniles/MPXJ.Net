using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
    public class GroupContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Groups, Has.Count.EqualTo(3));

            var group = project.Groups[0];
            Assert.Multiple(() =>
            {
                Assert.That(group.ID, Is.EqualTo(19));
                Assert.That(group.Name, Is.EqualTo("Group 1"));
                Assert.That(group.ShowSummaryTasks, Is.False);
                Assert.That(group.GroupClauses, Has.Count.EqualTo(2));
                Assert.That(group.ToString(), Contains.Substring("[Group "));
            });

            var clause = group.GroupClauses[0];
            Assert.Multiple(() =>
            {
                Assert.That(clause.Ascending, Is.True);
                Assert.That(clause.CellBackgroundColor.ToString(), Is.EqualTo("Color [A=255, R=255, G=246, B=193]"));
                Assert.That(clause.Field, Is.EqualTo(TaskField.Text1));
                Assert.That(clause.Font.ToString(), Contains.Substring("Calibri"));
                Assert.That(clause.GroupInterval, Is.Null);
                Assert.That(clause.GroupOn, Is.EqualTo(0));
                Assert.That(clause.Pattern, Is.EqualTo(BackgroundPattern.Solid));
                Assert.That(clause.StartAt, Is.Null);
                Assert.That(clause.ToString(), Contains.Substring("[GroupClause "));
            });

            var groupByName = project.Groups.GetByName("Group 1");
            Assert.That(groupByName, Is.EqualTo(group));
        }
    }
}
