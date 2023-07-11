using org.mpxj.proxy;

namespace org.mpxj
{
	public class GraphicalIndicator : IJavaObjectProxy<net.sf.mpxj.GraphicalIndicator>
    {
        public net.sf.mpxj.GraphicalIndicator JavaObject { get; }

        internal GraphicalIndicator(net.sf.mpxj.GraphicalIndicator javaObject)
        {
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

        public java.util.List NonSummaryRowCriteria
        {
            get => JavaObject.getNonSummaryRowCriteria();
        }

        public java.util.List ProjectSummaryCriteria
        {
            get => JavaObject.getProjectSummaryCriteria();
        }

        public java.util.List SummaryRowCriteria
        {
            get => JavaObject.getSummaryRowCriteria();
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

        public void AddNonSummaryRowCriteria(net.sf.mpxj.GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addNonSummaryRowCriteria(criteria);
        }

        public void AddSummaryRowCriteria(net.sf.mpxj.GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addSummaryRowCriteria(criteria);
        }

        public void AddProjectSummaryCriteria(net.sf.mpxj.GraphicalIndicatorCriteria criteria)
        {
            JavaObject.addProjectSummaryCriteria(criteria);
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

