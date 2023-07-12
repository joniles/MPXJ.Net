﻿using org.mpxj.proxy;

namespace org.mpxj
{
    public class ActivityCodeContainer : ProxyList<net.sf.mpxj.ActivityCode, ActivityCode>
    {
        public new net.sf.mpxj.ActivityCodeContainer JavaObject { get => (net.sf.mpxj.ActivityCodeContainer)base.JavaObject; }

        internal ActivityCodeContainer(ProxyManager proxyManager, net.sf.mpxj.ActivityCodeContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
