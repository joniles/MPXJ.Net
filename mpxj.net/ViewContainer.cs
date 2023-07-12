using org.mpxj.proxy;

namespace org.mpxj
{
	public class ViewContainer : ProxyList<net.sf.mpxj.View, IView>
    {
        public new net.sf.mpxj.ViewContainer JavaObject { get => (net.sf.mpxj.ViewContainer)base.JavaObject; }

        internal ViewContainer(ProxyManager proxyManager, net.sf.mpxj.ViewContainer javaObject) : base(proxyManager, javaObject) { }

        public ViewState ViewState
        {
            get => _proxyManager.ProxyObject(JavaObject.getViewState());
            set => JavaObject.setViewState(value.JavaObject);
        }
    }
}

