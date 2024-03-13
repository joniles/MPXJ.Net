using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class CostAccountContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.CostAccounts, Has.Count.EqualTo(3));
            Assert.That(project.CostAccounts.JavaObject, Is.Not.Null);

            var account = project.CostAccounts[0];
            Assert.That(account.Description, Contains.Substring("Desc 1"));
            Assert.That(account.ID, Is.EqualTo("A1"));
            Assert.That(account.Name, Is.EqualTo("Cost Account 1"));
            Assert.That(account.Parent, Is.Null);
            Assert.That(account.ParentUniqueID, Is.Null);
            Assert.That(account.SequenceNumber, Is.EqualTo(0));
            Assert.That(account.UniqueID, Is.EqualTo(743));
            Assert.That(account.ToString(), Is.EqualTo("[CostAccount uniqueID=743 name=Cost Account 1]"));

            account = project.CostAccounts.GetByUniqueID(743);
            Assert.That(account.Name, Is.EqualTo("Cost Account 1"));

            account = project.CostAccounts[2];
            Assert.That(account.UniqueID, Is.EqualTo(745));
            Assert.That(account.ParentUniqueID, Is.EqualTo(744));
            Assert.That(account.Parent.UniqueID, Is.EqualTo(744));
        }
    }
}
