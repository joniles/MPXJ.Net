using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class Filter : IJavaObjectProxy<net.sf.mpxj.Filter>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Filter JavaObject { get; }

        internal Filter(ProxyManager proxyManager, net.sf.mpxj.Filter javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? ID
        {
            get => JavaObject.getID().ConvertType();
            set => JavaObject.setID(value.ConvertType());
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public bool ShowRelatedSummaryRows
        {
            get => JavaObject.getShowRelatedSummaryRows();
            set => JavaObject.setShowRelatedSummaryRows(value);
        }

        public GenericCriteria Criteria
        {
            get => _proxyManager.ProxyObject(JavaObject.getCriteria());
            set => JavaObject.setCriteria(value.JavaObject);
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

        // TODO: handle map argument
        //bool evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);(value);

        public IList<GenericCriteriaPrompt> Prompts
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GenericCriteriaPrompt, GenericCriteriaPrompt>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getPrompts());
            // TODO: handle list argument
            //set => JavaObject.set
        }

        public override string ToString() => JavaObject.toString();
    }
}

