using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class HtmlNotes : Notes, IJavaObjectProxy<net.sf.mpxj.HtmlNotes>
    {
        public new net.sf.mpxj.HtmlNotes JavaObject => (net.sf.mpxj.HtmlNotes)base.JavaObject;

        internal HtmlNotes(net.sf.mpxj.HtmlNotes value) : base(value) { }

        public HtmlNotes(string html) : base(new net.sf.mpxj.HtmlNotes(html)) { }

        public string Html => JavaObject.getHtml();
    }
}
