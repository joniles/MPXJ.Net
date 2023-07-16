using org.mpxj.proxy;

namespace org.mpxj
{
    public class UserDefinedField : IFieldType, IJavaObjectProxy<net.sf.mpxj.UserDefinedField>
    {
        public net.sf.mpxj.UserDefinedField JavaObject { get; }

        internal UserDefinedField(net.sf.mpxj.UserDefinedField javaObject)
        {
            JavaObject = javaObject;
        }

        public UserDefinedField(java.lang.Integer id, string internalName, string externalName, FieldTypeClass fieldTypeClass, bool summaryTaskOnly, DataType dataType)
        {
            JavaObject = new net.sf.mpxj.UserDefinedField(id, internalName, externalName, fieldTypeClass.ConvertType(), summaryTaskOnly, dataType.ConvertType());
        }

        public java.lang.Integer UniqueID => JavaObject.getUniqueID();

        public bool SummaryTaskOnly => JavaObject.getSummaryTaskOnly();

        public FieldTypeClass FieldTypeClass => JavaObject.getFieldTypeClass().ConvertType().Value;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

