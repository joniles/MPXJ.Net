using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GraphicalIndicatorCriteria : GenericCriteria, IJavaObjectProxy<org.mpxj.GraphicalIndicatorCriteria>
    {
        public new org.mpxj.GraphicalIndicatorCriteria JavaObject => (org.mpxj.GraphicalIndicatorCriteria)base.JavaObject;

        internal GraphicalIndicatorCriteria(ProxyManager proxyManager, org.mpxj.GenericCriteria javaObject) : base(proxyManager, javaObject) { }

        public int Indicator => JavaObject.getIndicator();

        public int Evaluate(IFieldContainer container) => JavaObject.evaluate(container.JavaObject);

        public override string ToString() => JavaObject.toString();
    }
}

