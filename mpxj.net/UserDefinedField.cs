using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UserDefinedField : IFieldType, IJavaObjectProxy<net.sf.mpxj.FieldType>
    {
        public net.sf.mpxj.FieldType JavaObject { get; }
       
        internal UserDefinedField(net.sf.mpxj.UserDefinedField javaObject)
        {
            JavaObject = javaObject;
        }

        public int? UniqueID => ((net.sf.mpxj.UserDefinedField)JavaObject).getUniqueID().ConvertType();

        public bool SummaryTaskOnly => ((net.sf.mpxj.UserDefinedField)JavaObject).getSummaryTaskOnly();

        public FieldTypeClass FieldTypeClass => JavaObject.getFieldTypeClass().ConvertType().Value;

        public string FieldName => JavaObject.getName();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => ((net.sf.mpxj.UserDefinedField)JavaObject).toString();
    }
}
