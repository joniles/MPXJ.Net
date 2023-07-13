using org.mpxj.proxy;

namespace org.mpxj
{
    public class FontStyle : IJavaObjectProxy<net.sf.mpxj.mpp.FontStyle>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.mpp.FontStyle JavaObject { get; }

        internal FontStyle(ProxyManager proxyManager, net.sf.mpxj.mpp.FontStyle javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public FontBase FontBase => _proxyManager.ProxyObject(JavaObject.getFontBase());

        public bool Bold => JavaObject.getBold();

        public java.awt.Color Color => JavaObject.getColor();

        public bool Italic => JavaObject.getItalic();

        public bool Underline => JavaObject.getUnderline();

        public bool Strikethrough => JavaObject.getStrikethrough();

        public java.awt.Color BackgroundColor => JavaObject.getBackgroundColor();

        public BackgroundPattern? BackgroundPattern => JavaObject.getBackgroundPattern().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

