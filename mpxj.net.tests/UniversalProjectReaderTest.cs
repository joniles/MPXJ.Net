using NUnit.Framework;

namespace org.mpxj
{
    public class UniversalProjectReaderTests
    {
        [Test]
        public void Test1()
        {
            var project = new UniversalProjectReader().Read("/Users/joniles/Downloads/EC00515.xer");
            Assert.That(project, Is.Not.Null);
            var config = project.ProjectConfig;
            Assert.That(config, Is.Not.Null);
        }
    }
}
