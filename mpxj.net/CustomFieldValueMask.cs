using org.mpxj.proxy;

namespace org.mpxj
{
    public class CustomFieldValueMask : IJavaObjectProxy<net.sf.mpxj.CustomFieldValueMask>
    {
        public net.sf.mpxj.CustomFieldValueMask JavaObject { get; }

        internal CustomFieldValueMask(net.sf.mpxj.CustomFieldValueMask javaObject)
        {
            JavaObject = javaObject;
        }

        public CustomFieldValueMask(int length, int level, string separator, CustomFieldValueDataType type)
        {
            JavaObject = new net.sf.mpxj.CustomFieldValueMask(length, level, separator, type.ConvertType());
        }

        public int Length
        {
            get => JavaObject.getLength();
        }

        public int Level
        {
            get => JavaObject.getLevel();
        }

        public string Separator
        {
            get => JavaObject.getSeparator();
        }

        public CustomFieldValueDataType? Type
        {
            get => JavaObject.getType().ConvertType();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}
