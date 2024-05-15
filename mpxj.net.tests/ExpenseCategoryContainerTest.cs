using NUnit.Framework;

namespace MPXJ.Net
{
    public class ExpenseCategoryContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.ExpenseCategories, Has.Count.EqualTo(3));
            Assert.That(project.ExpenseCategories.JavaObject, Is.Not.Null);

            var category = project.ExpenseCategories[0];
            Assert.Multiple(() =>
            {
                Assert.That(category.UniqueID, Is.EqualTo(10));
                Assert.That(category.Name, Is.EqualTo("Facilities"));
                Assert.That(category.SequenceNumber, Is.EqualTo(10001));
                Assert.That(category.ToString(), Is.EqualTo("[ExpenseCategory uniqueID=10 name=Facilities]"));
            });
        }
    }
}
