using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
	public class LocationContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Locations.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Locations, Has.Count.EqualTo(2));
            Assert.That(project.Locations.JavaObject, Is.Not.Null);

            var location = project.Locations[0];
            Assert.Multiple(() =>
            {
                Assert.That(location.AddressLine1, Is.EqualTo("Line1"));
                Assert.That(location.AddressLine2, Is.EqualTo("Line2"));
                Assert.That(location.AddressLine3, Is.EqualTo("Line3"));
                Assert.That(location.City, Is.EqualTo("CityName"));
                Assert.That(location.Country, Is.EqualTo("CountryName"));
                Assert.That(location.CountryCode, Is.EqualTo("CountryCode"));
                Assert.That(location.Longitude, Is.EqualTo(1));
                Assert.That(location.Latitude, Is.EqualTo(2));
                Assert.That(location.Municipality, Is.EqualTo("MuniName"));
                Assert.That(location.Name, Is.EqualTo("Point"));
                Assert.That(location.PostalCode, Is.EqualTo("PostalCode"));
                Assert.That(location.State, Is.EqualTo("StateName"));
                Assert.That(location.StateCode, Is.EqualTo("StateCode"));
                Assert.That(location.UniqueID, Is.EqualTo(293));
            });
        }
    }
}

