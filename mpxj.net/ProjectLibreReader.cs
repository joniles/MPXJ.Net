namespace MPXJ.Net
{
    public class ProjectLibreReader : AbstractProjectReader
    {
        internal ProjectLibreReader(net.sf.mpxj.projectlibre.ProjectLibreReader reader) : base(reader) { }

        public ProjectLibreReader() : base(new net.sf.mpxj.projectlibre.ProjectLibreReader()) { }

        public new net.sf.mpxj.projectlibre.ProjectLibreReader JavaObject => (net.sf.mpxj.projectlibre.ProjectLibreReader)base.JavaObject;
    }
}
