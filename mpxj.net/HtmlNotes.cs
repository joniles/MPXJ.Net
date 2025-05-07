using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class HtmlNotes : Notes, IJavaObjectProxy<org.mpxj.HtmlNotes>
    {
        public new org.mpxj.HtmlNotes JavaObject => (org.mpxj.HtmlNotes)base.JavaObject;

        internal HtmlNotes(org.mpxj.HtmlNotes value) : base(value) { }

        public HtmlNotes(string html) : base(new org.mpxj.HtmlNotes(html)) { }

        public string Html => JavaObject.getHtml();
    }
}
