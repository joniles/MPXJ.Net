namespace MPXJ.Net
{
    internal class ProjectCommanderReader : AbstractProjectReader
    {
        internal ProjectCommanderReader(net.sf.mpxj.projectcommander.ProjectCommanderReader reader) : base(reader) { }

        public ProjectCommanderReader() : base(new net.sf.mpxj.projectcommander.ProjectCommanderReader()) { }

        public new net.sf.mpxj.projectcommander.ProjectCommanderReader JavaObject => (net.sf.mpxj.projectcommander.ProjectCommanderReader)base.JavaObject;
    }
}
