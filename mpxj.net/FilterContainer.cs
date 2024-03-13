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

        public IList<Filter> ResourceFilters => _proxyManager.ProxyList<net.sf.mpxj.Filter, Filter>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResourceFilters());

        public IList<Filter> TaskFilters => _proxyManager.ProxyList<net.sf.mpxj.Filter, Filter>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTaskFilters());

        public Filter GetFilterByName(string name) => _proxyManager.ProxyObject(JavaObject.getFilterByName(name));

        public Filter GetFilterByID(int id) => _proxyManager.ProxyObject(JavaObject.getFilterByID(id.ConvertType()));
    }
}
