namespace MPXJ.Net
{
    public class MerlinReader : AbstractProjectReader
    {
        public MerlinReader()
        {
            base.JavaObject = new net.sf.mpxj.merlin.MerlinReader();
        }

        public new net.sf.mpxj.merlin.MerlinReader JavaObject => (net.sf.mpxj.merlin.MerlinReader)base.JavaObject;
    }
}
