using org.mpxj.proxy;

namespace org.mpxj
{
    public class ActivityCodeContainer : ShallowProxyList<net.sf.mpxj.ActivityCode>, IJavaObjectProxy<net.sf.mpxj.ActivityCodeContainer>
    {
        public new net.sf.mpxj.ActivityCodeContainer JavaObject { get => (net.sf.mpxj.ActivityCodeContainer)base.JavaObject; }

        internal ActivityCodeContainer(net.sf.mpxj.ActivityCodeContainer javaObject) : base(javaObject) { }
    }
}
