namespace MPXJ.Net
{
    public class PhoenixReader : AbstractProjectReader
    {
        public PhoenixReader()
        {
            base.JavaObject = new net.sf.mpxj.phoenix.PhoenixReader();
        }

        public new net.sf.mpxj.phoenix.PhoenixReader JavaObject => (net.sf.mpxj.phoenix.PhoenixReader)base.JavaObject;
    }
}
