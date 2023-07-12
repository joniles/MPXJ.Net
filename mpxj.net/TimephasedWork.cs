using org.mpxj.proxy;

namespace org.mpxj
{
	public class TimephasedWork : IJavaObjectProxy<net.sf.mpxj.TimephasedWork>
    {
        public net.sf.mpxj.TimephasedWork JavaObject { get; }

        internal TimephasedWork(net.sf.mpxj.TimephasedWork javaObject)
        {
            JavaObject = javaObject;
        }
	}
}

