using System;
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

        [Obsolete("Please use UserDefinedField.Builder")]
        public UserDefinedField(ProjectFile file, int? id, string internalName, string externalName, FieldTypeClass fieldTypeClass, bool summaryTaskOnly, DataType dataType)
        {
            JavaObject = new net.sf.mpxj.UserDefinedField(file.JavaObject, id.ConvertType(), internalName, externalName, fieldTypeClass.ConvertType(), summaryTaskOnly, dataType.ConvertType());
        }

        public int? UniqueID => ((net.sf.mpxj.UserDefinedField)JavaObject).getUniqueID().ConvertType();

        public bool SummaryTaskOnly => ((net.sf.mpxj.UserDefinedField)JavaObject).getSummaryTaskOnly();

        public FieldTypeClass FieldTypeClass => JavaObject.getFieldTypeClass().ConvertType().Value;

        public string FieldName => JavaObject.getName();

        public string ObjectName => JavaObject.name();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => ((net.sf.mpxj.UserDefinedField)JavaObject).toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.UserDefinedField.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.UserDefinedField.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.UserDefinedField.Builder(file.JavaObject);
            }


            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder FieldTypeClass(FieldTypeClass value)
            {
                JavaObject.fieldTypeClass(value.ConvertType());
                return this;
            }

            public Builder SummaryTaskOnly(bool value)
            {
                JavaObject.summaryTaskOnly(value);
                return this;
            }

            public Builder ExternalName(string value)
            {
                JavaObject.externalName(value);
                return this;
            }

            public Builder InternalName(string value)
            {
                JavaObject.internalName(value);
                return this;
            }

            public Builder DataType(DataType value)
            {
                JavaObject.dataType(value.ConvertType());
                return this;
            }

            public UserDefinedField Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
