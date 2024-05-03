using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class RecurringTaskTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var task = project.Tasks.GetByID(12);
            Assert.That(task.RecurringTask, Is.Not.Null);

            var recurring = task.RecurringTask;
            Assert.Multiple(() =>
            {
                Assert.That(recurring.Duration, Is.EqualTo(Duration.GetInstance(2, TimeUnit.Days)));
                Assert.That(recurring.CalculatedFirstDate, Is.EqualTo(new DateOnly(2023, 7, 31)));
                Assert.That(recurring.CalculatedLastDate, Is.EqualTo(new DateOnly(2023, 8, 7)));
                Assert.That(recurring.Dates, Has.Length.EqualTo(2));
                Assert.That(recurring.Dates[0], Is.EqualTo(new DateOnly(2023, 7, 31)));
                Assert.That(recurring.Dates[1], Is.EqualTo(new DateOnly(2023, 8, 7)));
                Assert.That(recurring.DayNumber, Is.Null);
                Assert.That(recurring.DayOfWeek, Is.EqualTo(DayOfWeek.Monday));
                Assert.That(recurring.FinishDate, Is.EqualTo(new DateOnly(2023, 8, 7)));
                Assert.That(recurring.Frequency, Is.EqualTo(1));
                Assert.That(recurring.MonthNumber, Is.Null);
                Assert.That(recurring.RecurrenceType, Is.EqualTo(RecurrenceType.Weekly));
                Assert.That(recurring.Relative, Is.False);
                Assert.That(recurring.StartDate, Is.EqualTo(new DateOnly(2023, 7, 28)));
                Assert.That(recurring.UseEndDate, Is.False);
                Assert.That(recurring.Valid, Is.True);
                Assert.That(recurring.WorkingDaysOnly, Is.False);
                Assert.That(recurring.Occurrences, Is.EqualTo(2));
            });

            recurring.Duration = Duration.GetInstance(3, TimeUnit.Days);
            Assert.That(recurring.Duration, Is.EqualTo(Duration.GetInstance(3, TimeUnit.Days)));
        }
    }
}
