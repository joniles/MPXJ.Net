using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class TimephasedWork : TimephasedItem<Duration>, IJavaObjectProxy<net.sf.mpxj.TimephasedWork>
    {
        public new net.sf.mpxj.TimephasedWork JavaObject => (net.sf.mpxj.TimephasedWork)base.JavaObject;

        internal TimephasedWork(net.sf.mpxj.TimephasedWork javaObject) : base(javaObject) { }

        public TimephasedWork() : base(new net.sf.mpxj.TimephasedWork()) { }
    }
}
