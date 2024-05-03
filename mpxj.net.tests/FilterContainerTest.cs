using NUnit.Framework;

namespace MPXJ.Net
{
    public class FilterContainerTest
	{
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            var container = project.Filters;
            Assert.That(container, Is.Not.Null);

            var taskFilters = container.TaskFilters;
            Assert.That(taskFilters, Has.Count.EqualTo(3));

            var resourceFilters = container.ResourceFilters;
            Assert.That(resourceFilters, Has.Count.EqualTo(2));


            var filter = container.GetFilterByID(14);
            Assert.That(filter.ID, Is.EqualTo(14));

            filter = container.GetFilterByName("Filter 1");
            Assert.Multiple(() =>
            {
                Assert.That(filter.ID, Is.EqualTo(14));
                Assert.That(filter.IsResourceFilter, Is.False);
                Assert.That(filter.IsTaskFilter, Is.True);
                Assert.That(filter.Name, Is.EqualTo("Filter 1"));
                Assert.That(filter.ShowRelatedSummaryRows, Is.False);
                Assert.That(filter.Prompts, Has.Count.EqualTo(1));
                Assert.That(filter.ToString(), Contains.Substring("[Filter"));
            });

            
            var prompt = filter.Prompts[0];
            Assert.Multiple(() =>
            {
                Assert.That(prompt.Prompt, Is.EqualTo("Value is"));
                Assert.That(prompt.Type, Is.EqualTo(DataType.String));
                Assert.That(prompt.ToString(), Is.EqualTo("PROMPT(Value is)"));
            });

            var criteria = filter.Criteria;
            Assert.Multiple(() =>
            {
                Assert.That(criteria.LeftValue, Is.Null);
                Assert.That(criteria.Operator, Is.EqualTo(TestOperator.And));
                Assert.That(criteria.CriteriaList, Has.Count.EqualTo(3));
            });

            criteria = criteria.CriteriaList[0];
            Assert.Multiple(() =>
            {
                Assert.That(criteria.CriteriaList, Has.Count.EqualTo(0));
                Assert.That(criteria.LeftValue, Is.EqualTo(TaskField.Text1));
                Assert.That(criteria.Operator, Is.EqualTo(TestOperator.Equals));
                Assert.That(criteria.GetValue(0), Is.EqualTo("hello"));
                Assert.That(criteria.ToString(), Is.EqualTo("(Text1 EQUALS hello)"));
            });
        }
    }
}

