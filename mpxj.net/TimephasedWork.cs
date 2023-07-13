using org.mpxj.proxy;

namespace org.mpxj
{
	public class TimephasedWork : TimephasedItem<net.sf.mpxj.Duration>, IJavaObjectProxy<net.sf.mpxj.TimephasedWork>
    {
        public new net.sf.mpxj.TimephasedWork JavaObject => (net.sf.mpxj.TimephasedWork)base.JavaObject;

        internal TimephasedWork(net.sf.mpxj.TimephasedWork javaObject) : base(javaObject) { }
	}
}
