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


        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
        }

        public bool SummaryTaskOnly
        {
            get => JavaObject.getSummaryTaskOnly();
        }

        public FieldTypeClass FieldTypeClass
        {
            get => JavaObject.getFieldTypeClass().ConvertType().Value;
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public DataType? DataType
        {
            get => JavaObject.getDataType().ConvertType();
        }

        public IFieldType UnitsType
        {
            get => null;
            // TODO correctly proxy this
            //get => JavaObject.getUnitsType();
        }

        public override string ToString() => JavaObject.toString();
    }
}

