
using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
    public class ExpenseItemTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            var task = project.GetTaskByUniqueID(35846);
            Assert.That(task, Is.Not.Null);
            Assert.That(task.ExpenseItems, Has.Count.EqualTo(3));

            var item = task.ExpenseItems[0];

            Assert.Multiple(() =>
            {
                Assert.That(item.Account.UniqueID, Is.EqualTo(743));
                Assert.That(item.AccountUniqueID, Is.EqualTo(743));
                Assert.That(item.AccrueType, Is.EqualTo(AccrueType.Prorated));
                Assert.That(item.ActualCost, Is.EqualTo(2));
                Assert.That(item.ActualUnits, Is.EqualTo(2));
                Assert.That(item.AtCompletionCost, Is.EqualTo(5));
                Assert.That(item.AtCompletionUnits, Is.EqualTo(5));
                Assert.That(item.AutoComputeActuals, Is.False);
                Assert.That(item.Category.UniqueID, Is.EqualTo(11));
                Assert.That(item.CategoryUniqueID, Is.EqualTo(11));
                Assert.That(item.Description, Is.Null);
                Assert.That(item.DocumentNumber, Is.EqualTo("123"));
                Assert.That(item.Name, Is.EqualTo("Item 1"));
                Assert.That(item.PlannedCost, Is.EqualTo(1));
                Assert.That(item.PlannedUnits, Is.EqualTo(1));
                Assert.That(item.PricePerUnit, Is.EqualTo(1));
                Assert.That(item.RemainingCost, Is.EqualTo(3));
                Assert.That(item.RemainingUnits, Is.EqualTo(3));
                Assert.That(item.Task, Is.EqualTo(task));
                Assert.That(item.UniqueID, Is.EqualTo(753));
                Assert.That(item.UnitOfMeasure, Is.EqualTo("m"));
                Assert.That(item.Vendor, Is.EqualTo("Vendor 1"));
                Assert.That(item.ToString(), Contains.Substring("[ExpenseItem"));
            });
        }
    }
}
