namespace MPXJ.Net
{
    public class ProjectLibreReader : AbstractProjectReader
    {
        internal ProjectLibreReader(org.mpxj.projectlibre.ProjectLibreReader reader) : base(reader) { }

        public ProjectLibreReader() : base(new org.mpxj.projectlibre.ProjectLibreReader()) { }

        public new org.mpxj.projectlibre.ProjectLibreReader JavaObject => (org.mpxj.projectlibre.ProjectLibreReader)base.JavaObject;
    }
}
