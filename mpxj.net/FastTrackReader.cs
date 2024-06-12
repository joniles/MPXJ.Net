namespace MPXJ.Net
{
    public class FastTrackReader : AbstractProjectReader
    {
        public FastTrackReader() : base(new net.sf.mpxj.fasttrack.FastTrackReader()) { }

        public new net.sf.mpxj.fasttrack.FastTrackReader JavaObject => (net.sf.mpxj.fasttrack.FastTrackReader)base.JavaObject;
    }
}
