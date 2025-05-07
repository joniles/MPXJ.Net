namespace MPXJ.Net
{
    public class AstaFileReader : AbstractProjectReader
    {
        internal AstaFileReader(org.mpxj.asta.AstaFileReader reader) : base(reader) { }

        public AstaFileReader() : base(new org.mpxj.asta.AstaFileReader()) { }

        public new org.mpxj.asta.AstaFileReader JavaObject => (org.mpxj.asta.AstaFileReader)base.JavaObject;
    }
}
