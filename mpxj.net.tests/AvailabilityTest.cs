using System;
using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
	public class AvailabilityTest
	{
        [Test]
        public void GeneralTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Resources, Has.Count.EqualTo(7));

            var resource = project.Resources[1];
            Assert.That(resource.Name, Is.EqualTo("Resource 1"));

            Assert.That(resource.Availability, Has.Count.EqualTo(1));
            var availability = resource.Availability[0];

            Assert.That(resource.Availability.JavaObject, Is.Not.Null);

            Assert.That(availability.Units, Is.EqualTo(100.0));
            Assert.That(availability.Range.Start, Is.EqualTo(new DateTime(1984, 1, 1)));
            Assert.That(availability.Range.End, Is.EqualTo(new DateTime(2049, 12, 31, 23, 59, 0)));

            availability = resource.Availability.GetEntryByDate(DateTime.Now);

            Assert.That(availability.Units, Is.EqualTo(100.0));
            Assert.That(availability.Range.Start, Is.EqualTo(new DateTime(1984, 1, 1)));
            Assert.That(availability.Range.End, Is.EqualTo(new DateTime(2049, 12, 31, 23, 59, 0)));
        }
    }
}

