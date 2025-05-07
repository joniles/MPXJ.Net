namespace MPXJ.Net
{
    public class P3PRXFileReader : AbstractProjectReader
    {
        internal P3PRXFileReader(org.mpxj.primavera.p3.P3PRXFileReader reader) : base(reader) { }

        public P3PRXFileReader() : base(new org.mpxj.primavera.p3.P3PRXFileReader()) { }

        public new org.mpxj.primavera.p3.P3PRXFileReader JavaObject => (org.mpxj.primavera.p3.P3PRXFileReader)base.JavaObject;
    }
}
