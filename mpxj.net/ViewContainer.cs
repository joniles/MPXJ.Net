using org.mpxj.proxy;

namespace org.mpxj
{
	public class ViewContainer : DeepProxyList<net.sf.mpxj.View, IView>
    {
        public new net.sf.mpxj.ViewContainer JavaObject { get => (net.sf.mpxj.ViewContainer)base.JavaObject; }

        internal ViewContainer(ProxyManager proxyManager, net.sf.mpxj.ViewContainer javaObject) : base(proxyManager, javaObject) { }

        public net.sf.mpxj.ViewState ViewState
        {
            get => JavaObject.getViewState();
            set => JavaObject.setViewState(value);
        }
    }
}

