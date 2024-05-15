using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        public int? ID => JavaObject.getID().ConvertType();

        public string Name => JavaObject.getName();

        public bool ShowRelatedSummaryRows => JavaObject.getShowRelatedSummaryRows();

        public GenericCriteria Criteria => _proxyManager.ProxyObject(JavaObject.getCriteria());

        public bool IsTaskFilter => JavaObject.isTaskFilter();

        public bool IsResourceFilter => JavaObject.isResourceFilter();

        // TODO: handle map argument
        //bool Evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);(value);

        public IList<GenericCriteriaPrompt> Prompts => _proxyManager.ProxyList<net.sf.mpxj.GenericCriteriaPrompt, GenericCriteriaPrompt>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getPrompts());

        public override string ToString() => JavaObject.toString();
    }
}

