using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ViewState : IJavaObjectProxy<net.sf.mpxj.ViewState>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ViewState JavaObject { get; }

        internal ViewState(ProxyManager proxyManager, net.sf.mpxj.ViewState javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public string ViewName => JavaObject.getViewName();

        public IList<int> UniqueIdList => _proxyManager.ProxyList<java.lang.Integer, int>(v => v.intValue(), java.lang.Integer.valueOf, JavaObject.getUniqueIdList());

        public Filter Filter => _proxyManager.ProxyObject(JavaObject.getFilter());
    }
}
