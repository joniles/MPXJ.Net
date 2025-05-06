using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UserDefinedField : IFieldType, IJavaObjectProxy<org.mpxj.FieldType>
    {
        public org.mpxj.FieldType JavaObject { get; }
       
        internal UserDefinedField(org.mpxj.UserDefinedField javaObject)
        {
            JavaObject = javaObject;
        }
        
        public int? UniqueID => ((org.mpxj.UserDefinedField)JavaObject).getUniqueID().ConvertType();

        public bool SummaryTaskOnly => ((org.mpxj.UserDefinedField)JavaObject).getSummaryTaskOnly();

        public FieldTypeClass FieldTypeClass => JavaObject.getFieldTypeClass().ConvertType().Value;

        public string FieldName => JavaObject.getName();

        public string ObjectName => JavaObject.name();

        public DataType? DataType => JavaObject.getDataType().ConvertType();

        public override string ToString() => ((org.mpxj.UserDefinedField)JavaObject).toString();

        public class Builder : IJavaObjectProxy<org.mpxj.UserDefinedField.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.UserDefinedField.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.UserDefinedField.Builder(file.JavaObject);
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
