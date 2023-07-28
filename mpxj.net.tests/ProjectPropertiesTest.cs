using NUnit.Framework;

namespace org.mpxj
{
	public class ProjectPropertiesTest
	{
        [Test]
        public void Test1()
        {
            var project = new UniversalProjectReader().Read("/Users/joniles/Downloads/three-tasks.mpp");
            Assert.That(project, Is.Not.Null);

            var props = project.ProjectProperties;
            Assert.That(props, Is.Not.Null);
            Assert.That(props.AMText, Is.EqualTo("am"));

            var a = project.ActivityCodes;
            var c = project.CostAccounts;
            var e = project.ExpenseCategories;

            foreach(var field in project.PopulatedFields)
            {
                System.Console.WriteLine(field);
            }

            var t = project.Tasks[0];
            var ac = t.ActivityCodes;
            System.Console.WriteLine();
        }
    }
}

