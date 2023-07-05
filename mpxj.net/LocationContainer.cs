namespace org.mpxj
{
    // TODO: ProjectEntityContainer
    public class LocationContainer : ShallowProxyList<net.sf.mpxj.Location>, IJavaObjectProxy<net.sf.mpxj.LocationContainer>
    {
        public new net.sf.mpxj.LocationContainer JavaObject { get => (net.sf.mpxj.LocationContainer)base.JavaObject; }

        internal LocationContainer(net.sf.mpxj.LocationContainer javaObject) : base(javaObject) { }
    }
}
