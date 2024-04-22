using System;
using NUnit.Framework;
using MPXJ.Net.Reader;

namespace MPXJ.Net
{
	public class CostRateTableTest
	{
        [Test]
        public void GeneralTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Resources, Has.Count.EqualTo(7));

            var resource = project.Resources[1];
            Assert.That(resource.Name, Is.EqualTo("Resource 1"));

            var table = resource.GetCostRateTable(0);
            Assert.That(table, Has.Count.EqualTo(1));
            Assert.That(table.TableIsPopulated, Is.True);
            Assert.That(table.GetEntryByDate(DateTime.Now), Is.Not.Null);
            Assert.That(table.GetIndexByDate(DateTime.Now), Is.EqualTo(0));

            var entry = table[0];

            Assert.That(entry.CostPerUse, Is.EqualTo(0));
            Assert.That(entry.EndDate, Is.EqualTo(new DateTime(2049, 12, 31, 23, 59, 0)));
            Assert.That(entry.OvertimeRate.Amount, Is.EqualTo(21.0));
            Assert.That(entry.OvertimeRate.Units, Is.EqualTo(TimeUnit.Hours));
            Assert.That(entry.StandardRate.Amount, Is.EqualTo(10.0));
            Assert.That(entry.StandardRate.Units, Is.EqualTo(TimeUnit.Hours));
            Assert.That(entry.StartDate, Is.EqualTo(new DateTime(1984, 1, 1)));
            Assert.That(entry.GetRate(0).Amount, Is.EqualTo(10.0));
            Assert.That(entry.GetRate(0).Units, Is.EqualTo(TimeUnit.Hours));
        }
    }
}
