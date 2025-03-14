﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ViewContainer : ProxyList<net.sf.mpxj.View, IView>
    {
        private readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ViewContainer JavaObject => (net.sf.mpxj.ViewContainer)base.JavaObject;

        internal ViewContainer(ProxyManager proxyManager, net.sf.mpxj.ViewContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ViewState ViewState => _proxyManager.ProxyObject(JavaObject.getViewState());
    }
}
