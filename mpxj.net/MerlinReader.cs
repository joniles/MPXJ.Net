namespace MPXJ.Net
{
    public class MerlinReader : AbstractProjectReader
    {
        internal MerlinReader(org.mpxj.merlin.MerlinReader reader) : base(reader) { }

        public MerlinReader() : base(new org.mpxj.merlin.MerlinReader()) { }

        public new org.mpxj.merlin.MerlinReader JavaObject => (org.mpxj.merlin.MerlinReader)base.JavaObject;
    }
}
