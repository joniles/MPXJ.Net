
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
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

        public bool Empty => JavaObject.isEmpty();

        public override string ToString() => JavaObject.toString();
    }
}

