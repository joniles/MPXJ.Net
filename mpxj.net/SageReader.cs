namespace MPXJ.Net
{
    public class SageReader : AbstractProjectReader
    {
        internal SageReader(org.mpxj.sage.SageReader reader) : base(reader) { }

        public SageReader() : base(new org.mpxj.sage.SageReader()) { }

        public new org.mpxj.sage.SageReader JavaObject => (org.mpxj.sage.SageReader)base.JavaObject;

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
        }
    }
}
