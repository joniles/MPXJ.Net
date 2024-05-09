namespace MPXJ.Net
{
    public class SageReader : AbstractProjectReader
    {
        public SageReader()
        {
            base.JavaObject = new net.sf.mpxj.sage.SageReader();
        }

        public new net.sf.mpxj.sage.SageReader JavaObject => (net.sf.mpxj.sage.SageReader)base.JavaObject;
    }
}
