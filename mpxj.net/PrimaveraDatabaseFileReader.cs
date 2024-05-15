namespace MPXJ.Net
{
    public class PrimaveraDatabaseFileReader : AbstractProjectReader
    {
        public PrimaveraDatabaseFileReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.PrimaveraDatabaseFileReader();
        }

        public new net.sf.mpxj.primavera.PrimaveraDatabaseFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraDatabaseFileReader)base.JavaObject;
    }
}
