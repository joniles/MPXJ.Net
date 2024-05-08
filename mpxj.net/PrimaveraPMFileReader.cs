namespace MPXJ.Net
{
    public class PrimaveraPMFileReader : AbstractProjectReader
    {
        public PrimaveraPMFileReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.PrimaveraPMFileReader();
        }

        public new net.sf.mpxj.primavera.PrimaveraPMFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraPMFileReader)base.JavaObject;
    }
}
