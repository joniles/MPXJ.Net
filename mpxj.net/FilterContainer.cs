using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class FilterContainer : IJavaObjectProxy<org.mpxj.FilterContainer>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.FilterContainer JavaObject { get; }

        internal FilterContainer(ProxyManager proxyManager, org.mpxj.FilterContainer javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public IList<Filter> ResourceFilters => _proxyManager.ProxyList<org.mpxj.Filter, Filter>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResourceFilters());

        public IList<Filter> TaskFilters => _proxyManager.ProxyList<org.mpxj.Filter, Filter>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTaskFilters());

        public Filter GetFilterByName(string name) => _proxyManager.ProxyObject(JavaObject.getFilterByName(name));

        public Filter GetFilterByID(int id) => _proxyManager.ProxyObject(JavaObject.getFilterByID(id.ConvertType()));
    }
}
