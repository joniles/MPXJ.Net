using System;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class TimephasedItemTest
    {
        private const string Path = "TestData/Results/";

        [SetUp]
        public void SetUp()
        {
            Directory.CreateDirectory(Path);
        }

        [TearDown]
        public void TearDown()
        {
            Directory.Delete(Path, true);
        }

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

        [Test]
        public void WriteTimephaseData()
        {
            var file = new ProjectFile();

            //
            // Add a default calendar called "Standard"
            //
            var calendar = file.AddDefaultBaseCalendar();
            file.DefaultCalendar = calendar;

            //
            // Retrieve the project properties and set the start date. Note Microsoft
            // Project appears to reset all task dates relative to this date, so this
            // date must match the start date of the earliest task for you to see
            // the expected results. If this value is not set, it will default to
            // today's date.
            //
            file.ProjectProperties.StartDate = new DateTime(2003, 1, 1, 3, 0, 0);

            //
            // Add a resource
            //
            var resource1 = file.AddResource();
            resource1.Name = "Timephased Resource";

            //
            // Add a task
            //
            var task1 = file.AddTask();
            task1.Name = "Timephased Task";
            task1.Duration = Duration.GetInstance(3, TimeUnit.Days);
            task1.Start = new DateTime(2003, 1, 1, 3, 0, 0);
            task1.Finish = new DateTime(2003, 1, 3, 10, 0, 0);

            var assignment1 = task1.AddResourceAssignment(resource1);

            //
            // Our task is 3 days long - 24h of work.
            // We split this as 20h, 2h and 2h
            //
            var day1 = new TimephasedWork();
            day1.AmountPerDay = Duration.GetInstance(20, TimeUnit.Hours);
            day1.Start = new DateTime(2003, 1, 1, 3, 0, 0);
            day1.Finish = new DateTime(2003, 1, 1, 23, 0, 0);
            day1.Modified = true;
            day1.TotalAmount = Duration.GetInstance(20, TimeUnit.Hours);

            var day2 = new TimephasedWork();
            day2.AmountPerDay = Duration.GetInstance(2, TimeUnit.Hours);
            day2.Start = new DateTime(2003, 1, 2, 8, 0, 0);
            day2.Finish = new DateTime(2003, 1, 1, 10, 0, 0);
            day2.Modified = true;
            day2.TotalAmount = Duration.GetInstance(2, TimeUnit.Hours);

            var day3 = new TimephasedWork();
            day3.AmountPerDay = Duration.GetInstance(2, TimeUnit.Hours);
            day3.Start = new DateTime(2003, 1, 3, 8, 0, 0);
            day3.Finish = new DateTime(2003, 1, 1, 10, 0, 0);
            day3.Modified = true;
            day3.TotalAmount = Duration.GetInstance(2, TimeUnit.Hours);

            //
            // Add the timephased data to the assignment
            //
            assignment1.TimephasedWork = new[] { day1, day2, day3 }.ToList();

            //
            // Write the file
            //
            var writer = new MSPDIWriter();

            // By default, timephased data is not written so we need to enable it here
            writer.WriteTimephasedData = true;

            // Also, tell the writer not to get clever with our timephased data, just write it as it is...
            writer.SplitTimephasedAsDays = false;

            //
            // If you look at the resulting project in the Resource Usage view in MS Project
            // you should see the work split as 20h, 8h and 8h over the three days of the task.
            //
            writer.Write(file, Path + "test.xml");
        }
    }
}