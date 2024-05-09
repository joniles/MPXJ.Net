namespace MPXJ.Net
{
    public class ProjectLibreReader : AbstractProjectReader
    {
        public ProjectLibreReader()
        {
            base.JavaObject = new net.sf.mpxj.projectlibre.ProjectLibreReader();
        }

        public new net.sf.mpxj.projectlibre.ProjectLibreReader JavaObject => (net.sf.mpxj.projectlibre.ProjectLibreReader)base.JavaObject;
    }
}
