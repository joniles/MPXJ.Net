namespace MPXJ.Net
{
    public class MPPReader : AbstractProjectReader
    {
        public MPPReader()
        {
            base.JavaObject = new net.sf.mpxj.mpp.MPPReader();
        }

        public new net.sf.mpxj.mpp.MPPReader JavaObject => (net.sf.mpxj.mpp.MPPReader)base.JavaObject;
    }
}
