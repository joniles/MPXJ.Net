using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class ShiftTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new ProjectFile();

            var shift = new Shift.Builder(project)
                .UniqueID(1)
                .Name("First Shift")
                .Build();

            Assert.That(shift.UniqueID, Is.EqualTo(1));
            Assert.That(shift.Name, Is.EqualTo("First Shift"));
            Assert.That(shift.Periods, Has.Count.EqualTo(0));

            Assert.That(project.Shifts, Has.Count.EqualTo(0));
            project.Shifts.Add(shift);
            Assert.That(project.Shifts, Has.Count.EqualTo(1));

            var period1 = new ShiftPeriod.Builder(project, shift)
                .UniqueID(1)
                .Start(new TimeOnly(0, 0))
                .Build();

            var period2 = new ShiftPeriod.Builder(project, shift)
                .UniqueID(2)
                .Start(new TimeOnly(12, 0))
                .Build();

            project.ShiftPeriods.Add(period1);
            project.ShiftPeriods.Add(period2);

            Assert.That(period1.UniqueID, Is.EqualTo(1));
            Assert.That(period1.Start, Is.EqualTo(new TimeOnly(0, 0)));

            Assert.That(period2.UniqueID, Is.EqualTo(2));
            Assert.That(period2.Start, Is.EqualTo(new TimeOnly(12, 0)));

            Assert.That(period1.Duration.DurationValue, Is.EqualTo(12));

            Assert.That(shift.Periods, Has.Count.EqualTo(2));
            Assert.That(project.ShiftPeriods, Has.Count.EqualTo(2));
        }
    }
}
