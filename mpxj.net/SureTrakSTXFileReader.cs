namespace MPXJ.Net
{
    public class SureTrakSTXFileReader : AbstractProjectReader
    {
        internal SureTrakSTXFileReader(net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader reader) : base(reader) { }

        public SureTrakSTXFileReader() : base(new net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader()) { }

        public new net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader JavaObject => (net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader)base.JavaObject;
    }
}
