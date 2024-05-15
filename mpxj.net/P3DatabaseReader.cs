namespace MPXJ.Net
{
    public class P3DatabaseReader : AbstractProjectReader
    {
        public P3DatabaseReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.p3.P3DatabaseReader();
        }

        public new net.sf.mpxj.primavera.p3.P3DatabaseReader JavaObject => (net.sf.mpxj.primavera.p3.P3DatabaseReader)base.JavaObject;
    }
}
