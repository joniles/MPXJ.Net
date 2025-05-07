namespace MPXJ.Net
{
    public class TurboProjectReader : AbstractProjectReader
    {
        internal TurboProjectReader(org.mpxj.turboproject.TurboProjectReader reader) : base(reader) { }

        public TurboProjectReader() : base(new org.mpxj.turboproject.TurboProjectReader()) { }

        public new org.mpxj.turboproject.TurboProjectReader JavaObject => (org.mpxj.turboproject.TurboProjectReader)base.JavaObject;
    }
}
