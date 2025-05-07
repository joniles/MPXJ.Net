using System.Text;

namespace MPXJ.Net
{
    public class SDEFWriter : AbstractProjectWriter
    {
        public new org.mpxj.sdef.SDEFWriter JavaObject => (org.mpxj.sdef.SDEFWriter)base.JavaObject;

        public SDEFWriter() : base(new org.mpxj.sdef.SDEFWriter()) { }

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }
    }
}
