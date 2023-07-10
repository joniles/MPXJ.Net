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

        public java.util.List UniqueIdList
        {
            get => JavaObject.getUniqueIdList();
        }

        public Filter Filter
        {
            get => _proxyManager.ProxyObject(JavaObject.getFilter());
        }
    }
}
