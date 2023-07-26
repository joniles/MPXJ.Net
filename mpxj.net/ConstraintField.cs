using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ConstraintField : IFieldType, IJavaObjectProxy<net.sf.mpxj.FieldType>
    {
        public net.sf.mpxj.FieldType JavaObject { get; }

        public static readonly ConstraintField UniqueId = CreateField(net.sf.mpxj.ConstraintField.UNIQUE_ID);
        public static readonly ConstraintField Task1 = CreateField(net.sf.mpxj.ConstraintField.TASK1);
        public static readonly ConstraintField Task2 = CreateField(net.sf.mpxj.ConstraintField.TASK2);

        internal ConstraintField(net.sf.mpxj.ConstraintField javaObject)
        {
            JavaObject = javaObject;
        }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Constraint;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        private static ConstraintField CreateField(net.sf.mpxj.ConstraintField javaField)
        {
            return EnumExtensionMethods.RegisterFieldType(javaField, new ConstraintField(javaField));
        }
    }
}

