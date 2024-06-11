using System.Text;

namespace MPXJ.Net
{
    public class SDEFWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.sdef.SDEFWriter JavaObject => (net.sf.mpxj.sdef.SDEFWriter)base.JavaObject;

        public SDEFWriter() : base(new net.sf.mpxj.sdef.SDEFWriter()) { }

        public Encoding Charset
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }
    }
}
