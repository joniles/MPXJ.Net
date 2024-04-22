using System;
using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
	public class ProjectFileTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.Multiple(() =>
            {
                Assert.That(project.EarliestStartDate, Is.EqualTo(new DateTime(2023, 7, 28, 8, 0, 0)));
                Assert.That(project.LatestFinishDate, Is.EqualTo(new DateTime(2023, 8, 22, 17, 0, 0)));
                Assert.That(project.DefaultCalendar.Name, Is.EqualTo("Standard"));
            });
        }
    }
}

