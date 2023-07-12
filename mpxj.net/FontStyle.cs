using org.mpxj.proxy;

namespace org.mpxj
{
    public class FontStyle : IJavaObjectProxy<net.sf.mpxj.mpp.FontStyle>
    {
        public net.sf.mpxj.mpp.FontStyle JavaObject { get; }

        internal FontStyle(net.sf.mpxj.mpp.FontStyle javaObject)
        {
            JavaObject = javaObject;
        }

        public net.sf.mpxj.mpp.FontBase FontBase => JavaObject.getFontBase();

        public bool Bold => JavaObject.getBold();

        public java.awt.Color Color => JavaObject.getColor();

        public bool Italic => JavaObject.getItalic();

        public bool Underline => JavaObject.getUnderline();

        public bool Strikethrough => JavaObject.getStrikethrough();

        public java.awt.Color BackgroundColor => JavaObject.getBackgroundColor();

        public net.sf.mpxj.mpp.BackgroundPattern BackgroundPattern => JavaObject.getBackgroundPattern();

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

