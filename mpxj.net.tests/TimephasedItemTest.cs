using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class TimephasedItemTest
    {
        [Test]
        public void ReadTimephasedData()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var task = project.GetTaskByID(2);
            Assert.That(task.Name, Is.EqualTo("Task 1"));
            Assert.That(task.ResourceAssignments.Count, Is.EqualTo(1));

            var assignment = task.ResourceAssignments[0];
            var timephasedWorkItems = assignment.TimephasedWork;
            Assert.That(timephasedWorkItems.Count, Is.EqualTo(1));

            var timephasedWorkItem = timephasedWorkItems[0];
            Assert.That(timephasedWorkItem.AmountPerDay, Is.EqualTo(Duration.GetInstance(8, TimeUnit.Hours)));
            Assert.That(timephasedWorkItem.Finish, Is.EqualTo(new DateTime(2023,8,1,17,0, 0)));
            Assert.That(timephasedWorkItem.Modified, Is.False);
            Assert.That(timephasedWorkItem.Start, Is.EqualTo(new DateTime(2023,7,28,8,0, 0)));
            Assert.That(timephasedWorkItem.TotalAmount, Is.EqualTo(Duration.GetInstance(24, TimeUnit.Hours)));
            
            var timephasedCostItems = assignment.TimephasedCost;
            Assert.That(timephasedCostItems.Count, Is.EqualTo(1));

            var timephasedCostItem = timephasedCostItems[0];
            Assert.That(timephasedCostItem.AmountPerDay, Is.EqualTo(80));
            Assert.That(timephasedCostItem.Finish, Is.EqualTo(new DateTime(2023,8,1,17,0, 0)));
            Assert.That(timephasedCostItem.Modified, Is.False);
            Assert.That(timephasedCostItem.Start, Is.EqualTo(new DateTime(2023,7,28,8,0, 0)));
            Assert.That(timephasedCostItem.TotalAmount, Is.EqualTo(240));
        }
    }
}