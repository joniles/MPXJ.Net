namespace MPXJ.Net
{
    public class MSPDIReader : AbstractProjectReader
    {
        public MSPDIReader()
        {
            base.JavaObject = new net.sf.mpxj.mspdi.MSPDIReader();
        }

        public new net.sf.mpxj.mspdi.MSPDIReader JavaObject => (net.sf.mpxj.mspdi.MSPDIReader)base.JavaObject;
    }
}
