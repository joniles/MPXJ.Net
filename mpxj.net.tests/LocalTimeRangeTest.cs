using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Assertion", "NUnit2010:Use EqualConstraint for better assertion messages in case of failure")]
    public class LocalTimeRangeTest
    {
        [Test]
        public void MethodTest()
        {
            var start = new TimeOnly(8, 0);
            var end = new TimeOnly(12, 0);
            var range = new TimeOnlyRange(start, end);

            Assert.That(range.Start, Is.EqualTo(start));
            Assert.That(range.End, Is.EqualTo(end));
            Assert.That(range.DurationAsMilliseconds, Is.EqualTo(14400000));
            Assert.That(range.ToString(), Is.EqualTo("[LocalTimeRange start=08:00 end=12:00]"));
            Assert.That(range.GetHashCode(), Is.EqualTo(-849166981));

            var range1 = new TimeOnlyRange(new TimeOnly(8, 0), new TimeOnly(12, 0));
            Assert.That(range == range1, Is.True);
            Assert.That(range != range1, Is.False);
        }
    }
}
