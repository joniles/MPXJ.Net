using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ConstraintField : IFieldType, IJavaObjectProxy<org.mpxj.FieldType>
    {
        public org.mpxj.FieldType JavaObject { get; }

        private static List<ConstraintField> InternalValues { get; } = new List<ConstraintField>();
        public static IReadOnlyList<ConstraintField> Values => InternalValues.AsReadOnly();

        public static readonly ConstraintField UniqueId = new ConstraintField(org.mpxj.ConstraintField.UNIQUE_ID);
        public static readonly ConstraintField Task1 = new ConstraintField(org.mpxj.ConstraintField.TASK1);
        public static readonly ConstraintField Task2 = new ConstraintField(org.mpxj.ConstraintField.TASK2);

        private ConstraintField(org.mpxj.ConstraintField javaObject)
        {
            JavaObject = javaObject;
            InternalValues.Add(this);
        }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Constraint;

        public string FieldName => JavaObject.getName();

        public string ObjectName => JavaObject.name();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => JavaObject.ToString();
    }
}

