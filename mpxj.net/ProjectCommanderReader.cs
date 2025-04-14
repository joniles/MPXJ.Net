namespace MPXJ.Net
{
    public class ProjectCommanderReader : AbstractProjectReader
    {
        internal ProjectCommanderReader(org.mpxj.projectcommander.ProjectCommanderReader reader) : base(reader) { }

        public ProjectCommanderReader() : base(new org.mpxj.projectcommander.ProjectCommanderReader()) { }

        public new org.mpxj.projectcommander.ProjectCommanderReader JavaObject => (org.mpxj.projectcommander.ProjectCommanderReader)base.JavaObject;
    }
}
