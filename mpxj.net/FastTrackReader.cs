namespace MPXJ.Net
{
    public class FastTrackReader : AbstractProjectReader
    {
        internal FastTrackReader(net.sf.mpxj.fasttrack.FastTrackReader reader) : base(reader) { }

        public FastTrackReader() : base(new net.sf.mpxj.fasttrack.FastTrackReader()) { }

        public new net.sf.mpxj.fasttrack.FastTrackReader JavaObject => (net.sf.mpxj.fasttrack.FastTrackReader)base.JavaObject;
    }
}
