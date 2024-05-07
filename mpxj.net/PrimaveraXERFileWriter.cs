using System.Text;

namespace MPXJ.Net
{
    public class PrimaveraXERFileWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.primavera.PrimaveraXERFileWriter JavaObject => (net.sf.mpxj.primavera.PrimaveraXERFileWriter)base.JavaObject;

        public PrimaveraXERFileWriter() : base(new net.sf.mpxj.primavera.PrimaveraXERFileWriter()) { }

        public string Encoding
        {
            // TODO add to MPXJ
            // get => JavaObject.getEncoding();
            set => JavaObject.setEncoding(value);
        }
        public Encoding Charset
        {
            // TODO add to MPXJ
            //get => Encoding.GetEncoding(JavaObject.getCharset().name());
            set => JavaObject.setCharset(java.nio.charset.Charset.forName(value.EncodingName));
        }
    }
}
