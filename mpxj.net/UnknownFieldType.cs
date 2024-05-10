namespace MPXJ.Net
{
    internal class UnknownFieldType : IFieldType
    {
        internal UnknownFieldType(net.sf.mpxj.FieldType javaObject)
        {
            JavaObject = javaObject;
        }

        public net.sf.mpxj.FieldType JavaObject { get; set; }

        public FieldTypeClass FieldTypeClass => FieldTypeClass.Unknown;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => JavaObject.ToString();
    }
}
