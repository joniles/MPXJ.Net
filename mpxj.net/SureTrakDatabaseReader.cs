namespace MPXJ.Net
{
    public class SureTrakDatabaseReader : AbstractProjectReader
    {
        public SureTrakDatabaseReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader();
        }

        public new net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader JavaObject => (net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader)base.JavaObject;
    }
}
