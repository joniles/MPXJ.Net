namespace MPXJ.Net
{
    public class P3PRXFileReader : AbstractProjectReader
    {
        internal P3PRXFileReader(net.sf.mpxj.primavera.p3.P3PRXFileReader reader) : base(reader) { }

        public P3PRXFileReader() : base(new net.sf.mpxj.primavera.p3.P3PRXFileReader()) { }

        public new net.sf.mpxj.primavera.p3.P3PRXFileReader JavaObject => (net.sf.mpxj.primavera.p3.P3PRXFileReader)base.JavaObject;
    }
}
