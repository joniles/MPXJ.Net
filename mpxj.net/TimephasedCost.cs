using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimephasedCost : TimephasedItem<java.lang.Number>, IJavaObjectProxy<net.sf.mpxj.TimephasedCost>
    {
        public new net.sf.mpxj.TimephasedCost JavaObject => (net.sf.mpxj.TimephasedCost)base.JavaObject;

        internal TimephasedCost(net.sf.mpxj.TimephasedCost javaObject) : base(javaObject) { }
    }
}
