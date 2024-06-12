namespace MPXJ.Net
{
    public class MerlinReader : AbstractProjectReader
    {
        internal MerlinReader(net.sf.mpxj.merlin.MerlinReader reader) : base(reader) { }

        public MerlinReader() : base(new net.sf.mpxj.merlin.MerlinReader()) { }

        public new net.sf.mpxj.merlin.MerlinReader JavaObject => (net.sf.mpxj.merlin.MerlinReader)base.JavaObject;
    }
}
