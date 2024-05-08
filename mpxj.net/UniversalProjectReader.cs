namespace MPXJ.Net
{
    public class UniversalProjectReader : AbstractProjectReader
    {
        public UniversalProjectReader()
        {
            base.JavaObject = new net.sf.mpxj.reader.UniversalProjectReader();
        }

        public new net.sf.mpxj.reader.UniversalProjectReader JavaObject => (net.sf.mpxj.reader.UniversalProjectReader)base.JavaObject;
    }
}

