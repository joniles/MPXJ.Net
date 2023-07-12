
using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement the fulle Notes hierarchy
	public class Notes : IJavaObjectProxy<net.sf.mpxj.Notes>
    {
        public net.sf.mpxj.Notes JavaObject { get; }

        internal Notes(net.sf.mpxj.Notes javaObject)
        {
            JavaObject = javaObject;
        }

        public Notes(string text)
        {
            JavaObject = new net.sf.mpxj.Notes(text);
        }

        public bool Empty
        {
            get => JavaObject.isEmpty();
        }

        public override string ToString() => JavaObject.toString();
    }
}

