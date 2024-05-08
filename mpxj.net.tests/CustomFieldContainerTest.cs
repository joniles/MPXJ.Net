using System;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class CustomFieldContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.CustomFields.GetCustomFieldsByFieldTypeClass(FieldTypeClass.Task), Has.Count.EqualTo(2));
            Assert.That(project.Tasks.CustomFields, Has.Count.EqualTo(2));

            Assert.That(project.CustomFields.GetCustomFieldsByFieldTypeClass(FieldTypeClass.Resource), Has.Count.EqualTo(2));
            Assert.That(project.Resources.CustomFields, Has.Count.EqualTo(2));

            var field = project.CustomFields.Get(TaskField.Text2);
            Assert.That(field.Alias, Is.EqualTo("CustomFieldText2"));
            Assert.That(field.FieldType, Is.EqualTo(TaskField.Text2));
            Assert.That(field.Masks, Is.Empty);
            Assert.That(field.ToString(), Is.EqualTo("[CustomField field=Text2 alias=CustomFieldText2]"));
            Assert.That(field.UniqueID, Is.EqualTo(188743734));

            var table = field.LookupTable;
            Assert.That(table, Has.Count.EqualTo(3));

            Assert.That(table.AllLevelsRequired, Is.False);
            Assert.That(table.Enterprise, Is.False);
            Assert.That(table.GUID, Is.EqualTo(new Guid("{34b49930-ef96-487c-81fa-5d371f263505}")));
            Assert.That(table.LeafOnly, Is.False);
            Assert.That(table.OnlyTableValuesAllowed, Is.True);
            Assert.That(table.ResourceSubstitutionEnabled, Is.False);
            Assert.That(table.ShowIndent, Is.True);
            Assert.That(table.ToString, Is.EqualTo("MPXJ.Net.CustomFieldLookupTable"));

            Assert.That(project.CustomFields.Size, Is.EqualTo(4));

            var getOrCreateField = project.CustomFields.GetOrCreate(TaskField.Text2);
            Assert.That(getOrCreateField, Is.EqualTo(field));

            var addedField = project.CustomFields.Add(TaskField.Text3);
            Assert.That(addedField.FieldType, Is.EqualTo(TaskField.Text3));
            addedField.Alias = "New Alias";
            addedField.UniqueID = 123;

            var addedTable = addedField.LookupTable;
            table.AllLevelsRequired = false;
            table.Enterprise = false;
            table.GUID = Guid.NewGuid();
            table.LeafOnly = false;
            table.OnlyTableValuesAllowed = true;
            table.ResourceSubstitutionEnabled = false;
            table.ShowIndent = true;

            var typeByAlias = project.CustomFields.GetFieldTypeByAlias(FieldTypeClass.Task, "CustomFieldText2");
            Assert.That(typeByAlias, Is.EqualTo(TaskField.Text2));

            var indicator = field.GraphicalIndicator;
            Assert.That(indicator.DisplayGraphicalIndicators, Is.False);
            Assert.That(indicator.FieldType, Is.EqualTo(TaskField.Text2));
            Assert.That(indicator.NonSummaryRowCriteria, Is.Empty);
            Assert.That(indicator.ProjectSummaryCriteria, Is.Empty);
            Assert.That(indicator.ProjectSummaryInheritsFromSummaryRows, Is.False);
            Assert.That(indicator.ShowDataValuesInToolTips, Is.False);
            Assert.That(indicator.SummaryRowCriteria, Is.Empty);
            Assert.That(indicator.SummaryRowsInheritFromNonSummaryRows, Is.False);
            Assert.That(indicator.ToString(), Contains.Substring("[GraphicalIndicator"));

            Assert.That(indicator.Evaluate(project.Tasks[0]), Is.EqualTo(0));

            var item = field.LookupTable[0];
            Assert.That(item.Collapsed, Is.False);
            Assert.That(item.Description, Is.Null);
            Assert.That(item.GUID, Is.EqualTo(new Guid("{87b89f99-396b-4c6f-bfc4-65b391762a4c}")));
            Assert.That(item.ParentUniqueID, Is.EqualTo(0));
            Assert.That(item.ToString(), Contains.Substring("[CustomFieldValueItem"));
            Assert.That(item.Type, Is.EqualTo(CustomFieldValueDataType.Text));
            Assert.That(item.UniqueID, Is.EqualTo(1));
            Assert.That(item.Value, Is.EqualTo("Value 1"));

            var lookupItem = project.CustomFields.GetCustomFieldValueItemByUniqueID(item.UniqueID);
            Assert.That(lookupItem, Is.EqualTo(item));

            lookupItem = project.CustomFields.GetCustomFieldValueItemByGuid(item.GUID);
            Assert.That(lookupItem, Is.EqualTo(item));

            var newItem = new CustomFieldValueItem(123)
            {
                Value = "Value",
                Description = "Description",
                ParentUniqueID = 456,
                GUID = Guid.NewGuid(),
                Type = CustomFieldValueDataType.Text,
                Collapsed = false
            };
        }
    }
}
