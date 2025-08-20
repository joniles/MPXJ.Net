namespace MPXJ.Net
{
    public class AstaTextFileReader : AbstractProjectReader
    {
        internal AstaTextFileReader(org.mpxj.asta.AstaTextFileReader reader) : base(reader) { }

        public AstaTextFileReader() : base(new org.mpxj.asta.AstaTextFileReader()) { }

        public new org.mpxj.asta.AstaTextFileReader JavaObject => (org.mpxj.asta.AstaTextFileReader)base.JavaObject;
    }
}
