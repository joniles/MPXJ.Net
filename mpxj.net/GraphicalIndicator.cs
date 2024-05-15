using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GraphicalIndicator : IJavaObjectProxy<net.sf.mpxj.GraphicalIndicator>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.GraphicalIndicator JavaObject { get; }

        internal GraphicalIndicator(ProxyManager proxyManager, net.sf.mpxj.GraphicalIndicator javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int Evaluate(IFieldContainer container) => JavaObject.evaluate(container.JavaObject);

        public IFieldType FieldType => _proxyManager.ProxyObject(JavaObject.getFieldType());

        public bool DisplayGraphicalIndicators => JavaObject.getDisplayGraphicalIndicators();

        public IList<GraphicalIndicatorCriteria> NonSummaryRowCriteria => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getNonSummaryRowCriteria());

        public IList<GraphicalIndicatorCriteria> ProjectSummaryCriteria => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjectSummaryCriteria());

        public IList<GraphicalIndicatorCriteria> SummaryRowCriteria => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSummaryRowCriteria());

        public bool ProjectSummaryInheritsFromSummaryRows => JavaObject.getProjectSummaryInheritsFromSummaryRows();

        public bool SummaryRowsInheritFromNonSummaryRows => JavaObject.getSummaryRowsInheritFromNonSummaryRows();

        public bool ShowDataValuesInToolTips => JavaObject.getShowDataValuesInToolTips();

        public override string ToString() => JavaObject.toString();
    }
}

