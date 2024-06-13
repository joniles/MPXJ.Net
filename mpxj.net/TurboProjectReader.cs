namespace MPXJ.Net
{
    public class TurboProjectReader : AbstractProjectReader
    {
        internal TurboProjectReader(net.sf.mpxj.turboproject.TurboProjectReader reader) : base(reader) { }

        public TurboProjectReader() : base(new net.sf.mpxj.turboproject.TurboProjectReader()) { }

        public new net.sf.mpxj.turboproject.TurboProjectReader JavaObject => (net.sf.mpxj.turboproject.TurboProjectReader)base.JavaObject;
    }
}
