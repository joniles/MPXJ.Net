using org.mpxj.proxy;

namespace org.mpxj
{
    public class ConstraintField : IFieldType, IJavaObjectProxy<net.sf.mpxj.ConstraintField>
    {
        public net.sf.mpxj.ConstraintField JavaObject { get; }

        public static readonly ConstraintField UniqueId = new ConstraintField(net.sf.mpxj.ConstraintField.UNIQUE_ID);
        public static readonly ConstraintField Task1 = new ConstraintField(net.sf.mpxj.ConstraintField.TASK1);
        public static readonly ConstraintField Task2 = new ConstraintField(net.sf.mpxj.ConstraintField.TASK2);

        internal ConstraintField(net.sf.mpxj.ConstraintField javaObject)
        {
            JavaObject = javaObject;
        }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Constraint;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();
    }
}

