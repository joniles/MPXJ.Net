using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GraphicalIndicatorCriteria : GenericCriteria, IJavaObjectProxy<net.sf.mpxj.GraphicalIndicatorCriteria>
    {
        public new net.sf.mpxj.GraphicalIndicatorCriteria JavaObject { get => (net.sf.mpxj.GraphicalIndicatorCriteria)base.JavaObject; }

        internal GraphicalIndicatorCriteria(ProxyManager proxyManager, net.sf.mpxj.GenericCriteria javaObject) : base(proxyManager, javaObject) { }

        public int Indicator => JavaObject.getIndicator();

        public int Evaluate(IFieldContainer container) => JavaObject.evaluate(container.JavaObject);

        public override string ToString() => JavaObject.toString();
    }
}

