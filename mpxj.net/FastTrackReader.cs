namespace MPXJ.Net
{
    public class FastTrackReader : AbstractProjectReader
    {
        internal FastTrackReader(org.mpxj.fasttrack.FastTrackReader reader) : base(reader) { }

        public FastTrackReader() : base(new org.mpxj.fasttrack.FastTrackReader()) { }

        public new org.mpxj.fasttrack.FastTrackReader JavaObject => (org.mpxj.fasttrack.FastTrackReader)base.JavaObject;
    }
}
