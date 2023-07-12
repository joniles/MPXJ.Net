using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
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

        public string ViewName
        {
            get => JavaObject.getViewName();
        }

        public IList<int> UniqueIdList
        {
            get => _proxyManager.ProxyList<java.lang.Integer, int>(v => v.intValue(), v => java.lang.Integer.valueOf(v), JavaObject.getUniqueIdList());
        }

        public Filter Filter
        {
            get => _proxyManager.ProxyObject(JavaObject.getFilter());
        }
    }
}
