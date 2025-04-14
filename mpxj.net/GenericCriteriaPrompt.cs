using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GenericCriteriaPrompt : IJavaObjectProxy<org.mpxj.GenericCriteriaPrompt>
    {
        public org.mpxj.GenericCriteriaPrompt JavaObject { get; }

        internal GenericCriteriaPrompt(org.mpxj.GenericCriteriaPrompt javaObject)
        {
            JavaObject = javaObject;
        }

        public DataType? Type => JavaObject.getType().ConvertType();

        public string Prompt => JavaObject.getPrompt();

        public override string ToString() => JavaObject.toString();
    }
}

