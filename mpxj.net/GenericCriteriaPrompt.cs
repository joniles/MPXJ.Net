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

        public GenericCriteriaPrompt(net.sf.mpxj.DataType type, string prompt)
        {
            JavaObject = new net.sf.mpxj.GenericCriteriaPrompt(type, prompt);
        }

        public net.sf.mpxj.DataType Type
        {
            get => JavaObject.getType();
        }

        public string Prompt
        {
            get => JavaObject.getPrompt();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

