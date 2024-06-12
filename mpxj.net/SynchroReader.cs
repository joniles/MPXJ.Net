namespace MPXJ.Net
{
    public class SynchroReader : AbstractProjectReader
    {
        public SynchroReader() : base(new net.sf.mpxj.synchro.SynchroReader()) { }

        public new net.sf.mpxj.synchro.SynchroReader JavaObject => (net.sf.mpxj.synchro.SynchroReader)base.JavaObject;
    }
}
