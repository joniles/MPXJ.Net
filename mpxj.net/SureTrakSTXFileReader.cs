namespace MPXJ.Net
{
    public class SureTrakSTXFileReader : AbstractProjectReader
    {
        internal SureTrakSTXFileReader(org.mpxj.primavera.suretrak.SureTrakSTXFileReader reader) : base(reader) { }

        public SureTrakSTXFileReader() : base(new org.mpxj.primavera.suretrak.SureTrakSTXFileReader()) { }

        public new org.mpxj.primavera.suretrak.SureTrakSTXFileReader JavaObject => (org.mpxj.primavera.suretrak.SureTrakSTXFileReader)base.JavaObject;
    }
}
