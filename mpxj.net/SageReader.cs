namespace MPXJ.Net
{
    public class SageReader : AbstractProjectReader
    {
        public SageReader() : base(new net.sf.mpxj.sage.SageReader()) { }

        public new net.sf.mpxj.sage.SageReader JavaObject => (net.sf.mpxj.sage.SageReader)base.JavaObject;

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
        }
    }
}
