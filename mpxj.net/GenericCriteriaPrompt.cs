using org.mpxj.proxy;

namespace org.mpxj
{
    public class GenericCriteriaPrompt : IJavaObjectProxy<net.sf.mpxj.GenericCriteriaPrompt>
    {
        public net.sf.mpxj.GenericCriteriaPrompt JavaObject { get; }

        internal GenericCriteriaPrompt(net.sf.mpxj.GenericCriteriaPrompt javaObject)
        {
            JavaObject = javaObject;
        }

        public GenericCriteriaPrompt(DataType type, string prompt)
        {
            JavaObject = new net.sf.mpxj.GenericCriteriaPrompt(type.ConvertType(), prompt);
        }

        public DataType? Type
        {
            get => JavaObject.getType().ConvertType();
        }

        public string Prompt
        {
            get => JavaObject.getPrompt();
        }

        public override string ToString() => JavaObject.toString();
    }
}

