
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class Notes : IJavaObjectProxy<org.mpxj.Notes>
    {
        public org.mpxj.Notes JavaObject { get; }

        internal Notes(org.mpxj.Notes javaObject)
        {
            JavaObject = javaObject;
        }

        public Notes(string text)
        {
            JavaObject = new org.mpxj.Notes(text);
        }

        public bool Empty => JavaObject.isEmpty();

        public override string ToString() => JavaObject.toString();
    }
}

