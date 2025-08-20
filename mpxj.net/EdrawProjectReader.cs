namespace MPXJ.Net
{
    public class EdrawProjectReader : AbstractProjectReader
    {
        internal EdrawProjectReader(org.mpxj.edrawproject.EdrawProjectReader reader) : base(reader) { }

        public EdrawProjectReader() : base(new org.mpxj.edrawproject.EdrawProjectReader()) { }

        public new org.mpxj.edrawproject.EdrawProjectReader JavaObject => (org.mpxj.edrawproject.EdrawProjectReader)base.JavaObject;
    }
}
