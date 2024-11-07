using NUnit.Framework;

namespace MPXJ.Net
{
    public class WorkContourTest
    {
        [Test]
        public void MethodsTest()
        {
            Assert.Throws<System.NotImplementedException>(() => WorkContour.Turtle.UniqueID = 1);
            Assert.Multiple(() =>
            {
                Assert.That(WorkContour.Turtle.UniqueID, Is.EqualTo(8));
                Assert.That(WorkContour.Turtle.Name, Is.EqualTo("TURTLE"));
                Assert.That(WorkContour.Turtle.ToString(), Is.EqualTo("TURTLE"));
                Assert.That(WorkContour.Turtle.IsContourDefault, Is.True);
                Assert.That(WorkContour.Turtle.IsContourFlat, Is.False);
                Assert.That(WorkContour.Turtle.IsContourManual, Is.False);
                Assert.That(WorkContour.Turtle.CurveValues, Is.EqualTo(new[] { 0.0, 1.0, 1.0, 3.5, 3.5, 5.5, 5.5, 7.5, 7.5, 7.5, 7.5, 7.5, 7.5, 7.5, 7.5, 5.5, 5.5, 3.5, 3.5, 1.0, 1.0 }));
            });
        }
    }
}
