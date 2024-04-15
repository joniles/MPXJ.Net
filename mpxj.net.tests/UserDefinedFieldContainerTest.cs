using System.Collections.Generic;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class UserDefinedFieldContainerTest
    {
        [Test]
        public void MethodTests()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.xer");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.UserDefinedFields.TaskFields, Has.Count.EqualTo(2));
            Assert.That(project.UserDefinedFields.ResourceFields, Has.Count.EqualTo(0));
            Assert.That(project.UserDefinedFields.AssignmentFields, Has.Count.EqualTo(0));
            Assert.That(project.UserDefinedFields.ProjectFields, Has.Count.EqualTo(0));

            var list = new List<UserDefinedField>(project.UserDefinedFields.TaskFields);
            var udf = list[0];
            Assert.That(udf.DataType, Is.EqualTo(DataType.String));
            Assert.That(udf.FieldName, Is.EqualTo("UDF 1"));
            Assert.That(udf.FieldTypeClass, Is.EqualTo(FieldTypeClass.Task));
            Assert.That(udf.SummaryTaskOnly, Is.False);
            Assert.That(udf.UniqueID, Is.EqualTo(128));
            Assert.That(udf.ToString(), Is.EqualTo("UDF 1"));
        }
    }
}
