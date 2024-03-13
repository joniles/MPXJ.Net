using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
	public class FilterContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var container = project.Filters;
            Assert.That(container, Is.Not.Null);

            var taskFilters = container.TaskFilters;
            Assert.That(taskFilters, Has.Count.EqualTo(2));

            var resourceFilters = container.ResourceFilters;
            Assert.That(taskFilters, Has.Count.EqualTo(2));
        }
    }
}

