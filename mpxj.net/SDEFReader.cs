namespace MPXJ.Net
{
    public class SDEFReader : AbstractProjectReader
    {
        public SDEFReader()
        {
            base.JavaObject = new net.sf.mpxj.sdef.SDEFReader();
        }

        public new net.sf.mpxj.sdef.SDEFReader JavaObject => (net.sf.mpxj.sdef.SDEFReader)base.JavaObject;
    }
}
