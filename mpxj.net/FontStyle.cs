using System.Drawing;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class FontStyle : IJavaObjectProxy<org.mpxj.mpp.FontStyle>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.mpp.FontStyle JavaObject { get; }

        internal FontStyle(ProxyManager proxyManager, org.mpxj.mpp.FontStyle javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public FontBase FontBase => _proxyManager.ProxyObject(JavaObject.getFontBase());

        public bool Bold => JavaObject.getBold();

        public Color? Color => JavaObject.getColor().ConvertType();

        public bool Italic => JavaObject.getItalic();

        public bool Underline => JavaObject.getUnderline();

        public bool Strikethrough => JavaObject.getStrikethrough();

        public Color? BackgroundColor => JavaObject.getBackgroundColor().ConvertType();

        public BackgroundPattern? BackgroundPattern => JavaObject.getBackgroundPattern().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

