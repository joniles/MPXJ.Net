using org.mpxj.proxy;

namespace org.mpxj
{
    public class Filter : IJavaObjectProxy<net.sf.mpxj.Filter>
    {
        public net.sf.mpxj.Filter JavaObject { get; }

        internal Filter(net.sf.mpxj.Filter javaObject)
        {
            JavaObject = javaObject;
        }

        public java.lang.Integer ID
        {
            get => JavaObject.getID();
            set => JavaObject.setID(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        bool ShowRelatedSummaryRows
        {
            get => JavaObject.getShowRelatedSummaryRows();
            set => JavaObject.setShowRelatedSummaryRows(value);
        }

        public net.sf.mpxj.GenericCriteria Criteria
        {
            get => JavaObject.getCriteria();
            set => JavaObject.setCriteria(value);
        }

        public bool IsTaskFilter
        {
            get => JavaObject.isTaskFilter();
            set => JavaObject.setIsTaskFilter(value);
        }

        public bool IsResourceFilter
        {
            get => JavaObject.isResourceFilter();
            set => JavaObject.setIsResourceFilter(value);
        }

        // TODO: handle Map
        //bool evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);(value);

        public java.util.List Prompts
        {
            get => JavaObject.getPrompts();
            // TODO: handle list assignment
            //set => JavaObject.set
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

