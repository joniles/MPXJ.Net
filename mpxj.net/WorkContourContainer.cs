namespace org.mpxj
{
    // TODO: ProjectEntityContainer
    public class WorkContourContainer : ShallowProxyList<net.sf.mpxj.WorkContour>, IJavaObjectProxy<net.sf.mpxj.WorkContourContainer>
    {
        public new net.sf.mpxj.WorkContourContainer JavaObject { get => (net.sf.mpxj.WorkContourContainer)base.JavaObject; }

        internal WorkContourContainer(net.sf.mpxj.WorkContourContainer javaObject) : base(javaObject) { }
    }
}
