using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ViewContainer : ProxyList<org.mpxj.View, IView>
    {
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.ViewContainer JavaObject => (org.mpxj.ViewContainer)base.JavaObject;

        internal ViewContainer(ProxyManager proxyManager, org.mpxj.ViewContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ViewState ViewState => _proxyManager.ProxyObject(JavaObject.getViewState());
    }
}
