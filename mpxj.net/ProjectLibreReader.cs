namespace MPXJ.Net
{
    public class ProjectLibreReader : AbstractProjectReader
    {
        public ProjectLibreReader() : base(new net.sf.mpxj.projectlibre.ProjectLibreReader()) { }

        public new net.sf.mpxj.projectlibre.ProjectLibreReader JavaObject => (net.sf.mpxj.projectlibre.ProjectLibreReader)base.JavaObject;
    }
}
