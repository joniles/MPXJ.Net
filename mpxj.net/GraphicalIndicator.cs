using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
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

        public int Evaluate(IFieldContainer container)
        {
            return JavaObject.evaluate(container.JavaObject);
        }

        public net.sf.mpxj.FieldType FieldType
        {
            get => JavaObject.getFieldType();
            set => JavaObject.setFieldType(value);
        }

        public bool DisplayGraphicalIndicators
        {
            get => JavaObject.getDisplayGraphicalIndicators();
            set => JavaObject.setDisplayGraphicalIndicators(value);
        }

        public IList<GraphicalIndicatorCriteria> NonSummaryRowCriteria
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getNonSummaryRowCriteria());
        }

        public IList<GraphicalIndicatorCriteria> ProjectSummaryCriteria
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjectSummaryCriteria());
        }

        public IList<GraphicalIndicatorCriteria> SummaryRowCriteria
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GraphicalIndicatorCriteria, GraphicalIndicatorCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSummaryRowCriteria());
        }

        public bool ProjectSummaryInheritsFromSummaryRows
        {
            get => JavaObject.getProjectSummaryInheritsFromSummaryRows();
            set => JavaObject.setProjectSummaryInheritsFromSummaryRows(value);
        }

        public bool SummaryRowsInheritFromNonSummaryRows
        {
            get => JavaObject.getSummaryRowsInheritFromNonSummaryRows();
            set => JavaObject.setSummaryRowsInheritFromNonSummaryRows(value);
        }

        public bool ShowDataValuesInToolTips
        {
            get => JavaObject.getShowDataValuesInToolTips();
            set => JavaObject.setShowDataValuesInToolTips(value);
        }

        public void AddNonSummaryRowCriteria(GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addNonSummaryRowCriteria(criteria.JavaObject);
        }

        public void AddSummaryRowCriteria(GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addSummaryRowCriteria(criteria.JavaObject);
        }

        public void AddProjectSummaryCriteria(GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addProjectSummaryCriteria(criteria.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}

