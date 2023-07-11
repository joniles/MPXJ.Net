using net.sf.mpxj;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class GraphicalIndicatorCriteria : GenericCriteria, IJavaObjectProxy<net.sf.mpxj.GraphicalIndicatorCriteria>
    {
        public new net.sf.mpxj.GraphicalIndicatorCriteria JavaObject { get => (net.sf.mpxj.GraphicalIndicatorCriteria)base.JavaObject; }

        internal GraphicalIndicatorCriteria(ProxyManager proxyManager, net.sf.mpxj.GenericCriteria javaObject) : base(proxyManager, javaObject) { }

        public GraphicalIndicatorCriteria(ProjectProperties properties) : base(properties) { }

        public int Indicator
        {
            get => JavaObject.getIndicator();
            set => JavaObject.setIndicator(value);
        }

        public int Evaluate(FieldContainer container)
        {
            return JavaObject.getIndicator();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

