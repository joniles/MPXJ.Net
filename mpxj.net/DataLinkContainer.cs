namespace org.mpxj
{
    public class DataLinkContainer : ShallowProxyList<net.sf.mpxj.DataLink>, IJavaObjectProxy<net.sf.mpxj.DataLinkContainer>
    {
        public new net.sf.mpxj.DataLinkContainer JavaObject { get => (net.sf.mpxj.DataLinkContainer)base.JavaObject; }

        internal DataLinkContainer(net.sf.mpxj.DataLinkContainer javaObject) : base(javaObject) { }
    }
}
