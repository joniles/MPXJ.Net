namespace MPXJ.Net
{
    public class AstaFileReader : AbstractProjectReader
    {
        internal AstaFileReader(net.sf.mpxj.asta.AstaFileReader reader) : base(reader) { }

        public AstaFileReader() : base(new net.sf.mpxj.asta.AstaFileReader()) { }

        public new net.sf.mpxj.asta.AstaFileReader JavaObject => (net.sf.mpxj.asta.AstaFileReader)base.JavaObject;
    }
}
