using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class MicrosoftSchedulerTest
    {
        [Test]
        public void ScheduleTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            var scheduler = new MicrosoftScheduler();
            scheduler.Schedule(project, new DateTime(2025, 4, 7, 8, 0, 0));
        }
    }
}