namespace MPXJ.Net
{
    public class SynchroReader : AbstractProjectReader
    {
        internal SynchroReader(org.mpxj.synchro.SynchroReader reader) : base(reader) { }

        public SynchroReader() : base(new org.mpxj.synchro.SynchroReader()) { }

        public new org.mpxj.synchro.SynchroReader JavaObject => (org.mpxj.synchro.SynchroReader)base.JavaObject;
    }
}
