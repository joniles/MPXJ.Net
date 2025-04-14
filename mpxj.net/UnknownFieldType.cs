namespace MPXJ.Net
{
    internal class UnknownFieldType : IFieldType
    {
        internal UnknownFieldType(org.mpxj.FieldType javaObject)
        {
            JavaObject = javaObject;
        }

        public org.mpxj.FieldType JavaObject { get; }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Unknown;

        public string FieldName => JavaObject.getName();

        public string ObjectName => JavaObject.name();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => JavaObject.ToString();
    }
}
