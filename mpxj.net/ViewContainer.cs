using org.mpxj.proxy;

namespace org.mpxj
{
    public class ViewContainer : ProxyList<net.sf.mpxj.View, IView>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ViewContainer JavaObject { get => (net.sf.mpxj.ViewContainer)base.JavaObject; }

        internal ViewContainer(ProxyManager proxyManager, net.sf.mpxj.ViewContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ViewState ViewState
        {
            get => _proxyManager.ProxyObject(JavaObject.getViewState());
            set => JavaObject.setViewState(value.JavaObject);
        }
    }
}
