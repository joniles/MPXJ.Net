using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class FilterContainer : IJavaObjectProxy<net.sf.mpxj.FilterContainer>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.FilterContainer JavaObject { get; }

        internal FilterContainer(ProxyManager proxyManager, net.sf.mpxj.FilterContainer javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public void AddFilter(Filter filter)
        {
            JavaObject.addFilter(filter.JavaObject);
        }

        public void RemoveFilter(string filterName)
        {
            JavaObject.removeFilter(filterName);
        }

        public IList<Filter> ResourceFilters
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Filter, Filter>(JavaObject.getResourceFilters());
        }

        public IList<Filter> TaskFilters
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Filter, Filter>(JavaObject.getTaskFilters());
        }

        public Filter GetFilterByName(string name)
        {
            return _proxyManager.ProxyObject(JavaObject.getFilterByName(name));
        }

        public Filter GetFilterByID(java.lang.Integer id)
        {
            return _proxyManager.ProxyObject(JavaObject.getFilterByID(id));
        }
    }
}
