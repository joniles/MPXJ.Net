namespace MPXJ.Net
{
    internal class PrimaveraXERFileReader : AbstractProjectReader
    {
        public PrimaveraXERFileReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.PrimaveraXERFileReader();
        }

        public new net.sf.mpxj.primavera.PrimaveraXERFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraXERFileReader)base.JavaObject;
    }
}
