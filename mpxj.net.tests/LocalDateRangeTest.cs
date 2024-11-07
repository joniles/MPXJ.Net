using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Assertion", "NUnit2010:Use EqualConstraint for better assertion messages in case of failure")]
    public class LocalDateRangeTest
    {
        [Test]
        public void MethodTest()
        {
            var start = new DateOnly(2025, 1, 13);
            var end = new DateOnly(2025, 1, 17);
            var range = new DateOnlyRange(start, end);

            Assert.That(range.Start, Is.EqualTo(start));
            Assert.That(range.End, Is.EqualTo(end));
            Assert.That(range.ToString(), Is.EqualTo("[LocalDateRange start=2025-01-13 end=2025-01-17]"));
            Assert.That(range.GetHashCode, Is.EqualTo(12));

            var range1 = new DateOnlyRange(new DateOnly(2025, 1, 13), new DateOnly(2025, 1, 17));
            Assert.That(range == range1, Is.True);
            Assert.That(range != range1, Is.False);
        }
    }
}
