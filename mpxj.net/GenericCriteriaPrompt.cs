using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GenericCriteriaPrompt : IJavaObjectProxy<net.sf.mpxj.GenericCriteriaPrompt>
    {
        public net.sf.mpxj.GenericCriteriaPrompt JavaObject { get; }

        internal GenericCriteriaPrompt(net.sf.mpxj.GenericCriteriaPrompt javaObject)
        {
            JavaObject = javaObject;
        }

        public DataType? Type => JavaObject.getType().ConvertType();

        public string Prompt => JavaObject.getPrompt();

        public override string ToString() => JavaObject.toString();
    }
}

