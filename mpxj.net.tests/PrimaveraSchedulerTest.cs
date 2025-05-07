using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class PrimaveraSchedulerTest
    {
        [Test]
        public void ScheduleTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            var scheduler = new PrimaveraScheduler();
            scheduler.Schedule(project, new DateTime(2025, 4, 7, 8, 0, 0));
        }
    }
}