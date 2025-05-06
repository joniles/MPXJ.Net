using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RtfNotes : Notes, IJavaObjectProxy<org.mpxj.RtfNotes>
    {
        public new org.mpxj.RtfNotes JavaObject => (org.mpxj.RtfNotes)base.JavaObject;

        internal RtfNotes(org.mpxj.RtfNotes value) : base(value) { }

        public RtfNotes(string rtf) : base(new org.mpxj.RtfNotes(rtf)) { }

        public string Rtf => JavaObject.getRtf();
    }
}
