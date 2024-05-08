namespace MPXJ.Net
{
    internal class ProjectCommanderReader : AbstractProjectReader
    {
        public ProjectCommanderReader()
        {
            base.JavaObject = new net.sf.mpxj.projectcommander.ProjectCommanderReader();
        }

        public new net.sf.mpxj.projectcommander.ProjectCommanderReader JavaObject => (net.sf.mpxj.projectcommander.ProjectCommanderReader)base.JavaObject;
    }
}
