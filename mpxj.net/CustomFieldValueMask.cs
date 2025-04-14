using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CustomFieldValueMask : IJavaObjectProxy<org.mpxj.CustomFieldValueMask>
    {
        public org.mpxj.CustomFieldValueMask JavaObject { get; }

        internal CustomFieldValueMask(org.mpxj.CustomFieldValueMask javaObject)
        {
            JavaObject = javaObject;
        }

        public CustomFieldValueMask(int length, int level, string separator, CustomFieldValueDataType type)
        {
            JavaObject = new org.mpxj.CustomFieldValueMask(length, level, separator, type.ConvertType());
        }

        public int Length => JavaObject.getLength();

        public int Level => JavaObject.getLevel();

        public string Separator => JavaObject.getSeparator();

        public CustomFieldValueDataType? Type => JavaObject.getType().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}
