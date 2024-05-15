namespace MPXJ.Net
{
    public class MPXReader : AbstractProjectReader
    {
        public MPXReader()
        {
            base.JavaObject = new net.sf.mpxj.mpx.MPXReader();
        }

        public new net.sf.mpxj.mpx.MPXReader JavaObject => (net.sf.mpxj.mpx.MPXReader)base.JavaObject;
    }
}
