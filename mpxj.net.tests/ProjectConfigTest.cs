using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class ProjectConfigTest
    {
        [Test]
        public void MethodsTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var config = project.ProjectConfig;
            Assert.That(config, Is.Not.Null);

            Assert.That(config.AutoWBS, Is.True);
            config.AutoWBS = false;
            Assert.That(config.AutoWBS, Is.False);

            Assert.That(config.AutoOutlineLevel, Is.False);
            config.AutoOutlineLevel = true;
            Assert.That(config.AutoOutlineLevel, Is.True);

            Assert.That(config.AutoOutlineNumber, Is.False);
            config.AutoOutlineNumber = true;
            Assert.That(config.AutoOutlineNumber, Is.True);

            Assert.That(config.AutoTaskUniqueID, Is.False);
            config.AutoTaskUniqueID = true;
            Assert.That(config.AutoTaskUniqueID, Is.True);

            Assert.That(config.AutoCalendarUniqueID, Is.False);
            config.AutoCalendarUniqueID = true;
            Assert.That(config.AutoCalendarUniqueID, Is.True);

            Assert.That(config.AutoAssignmentUniqueID, Is.False);
            config.AutoAssignmentUniqueID = true;
            Assert.That(config.AutoAssignmentUniqueID, Is.True);

            Assert.That(config.AutoTaskID, Is.True);
            config.AutoTaskID = false;
            Assert.That(config.AutoTaskID, Is.False);

            Assert.That(config.AutoResourceUniqueID, Is.False);
            config.AutoResourceUniqueID = true;
            Assert.That(config.AutoResourceUniqueID, Is.True);

            Assert.That(config.AutoResourceID, Is.False);
            config.AutoResourceID = true;
            Assert.That(config.AutoResourceID, Is.True);

            Assert.That(config.AutoRelationUniqueID, Is.False);
            config.AutoRelationUniqueID = true;
            Assert.That(config.AutoRelationUniqueID, Is.True);

            Assert.That(config.CompleteThroughIsNextWorkStart, Is.False);
            config.CompleteThroughIsNextWorkStart = true;
            Assert.That(config.CompleteThroughIsNextWorkStart, Is.True);
            
            Assert.That(config.SubprojectWorkingDirectory, Is.Null);
            config.SubprojectWorkingDirectory = null;
            Assert.That(config.SubprojectWorkingDirectory, Is.Null);
            config.SubprojectWorkingDirectory = "/test";
            Assert.That(config.SubprojectWorkingDirectory, Is.EqualTo("/test"));
        }
    }
}
