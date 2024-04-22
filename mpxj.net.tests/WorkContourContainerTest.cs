using NUnit.Framework;

namespace MPXJ.Net
{
    public class WorkContourContainerTest
    {
        [Test]
        public void MethodsTest()
        {
            var file = new ProjectFile();
            Assert.That(file.WorkContours, Is.Empty);

            file.WorkContours.Add(WorkContour.Flat);
            Assert.That(file.WorkContours, Has.Count.EqualTo(1));

            var contour = file.WorkContours.GetByUniqueID(WorkContour.Flat.UniqueID);
            Assert.That(contour, Is.EqualTo(WorkContour.Flat));

            Assert.That(file.WorkContours.JavaObject, Is.Not.Null);
        }
    }
}
