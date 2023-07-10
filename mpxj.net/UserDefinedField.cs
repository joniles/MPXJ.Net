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

        public UserDefinedField(java.lang.Integer id, string internalName, string externalName, FieldTypeClass fieldTypeClass, bool summaryTaskOnly, net.sf.mpxj.DataType dataType)
        {
            JavaObject = new net.sf.mpxj.UserDefinedField(id, internalName, externalName, fieldTypeClass.ConvertType(), summaryTaskOnly, dataType);
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

        public net.sf.mpxj.DataType DataType
        {
            get => JavaObject.getDataType();
        }

        public IFieldType UnitsType
        {
            get => null;
            // TODO correctly proxy this
            //get => JavaObject.getUnitsType();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

