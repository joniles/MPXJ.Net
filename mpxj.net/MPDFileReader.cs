namespace MPXJ.Net
{
    public class MPDFileReader : AbstractProjectReader
    {
        public MPDFileReader()
        {
            base.JavaObject = new net.sf.mpxj.mpd.MPDFileReader();
        }

        public new net.sf.mpxj.mpd.MPDFileReader JavaObject => (net.sf.mpxj.mpd.MPDFileReader)base.JavaObject;
    }
}
