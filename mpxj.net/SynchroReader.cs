namespace MPXJ.Net
{
    public class SynchroReader : AbstractProjectReader
    {
        internal SynchroReader(net.sf.mpxj.synchro.SynchroReader reader) : base(reader) { }

        public SynchroReader() : base(new net.sf.mpxj.synchro.SynchroReader()) { }

        public new net.sf.mpxj.synchro.SynchroReader JavaObject => (net.sf.mpxj.synchro.SynchroReader)base.JavaObject;
    }
}
