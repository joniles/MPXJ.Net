using System.Text;

namespace MPXJ.Net
{
    public class PrimaveraXERFileWriter : AbstractProjectWriter
    {
        public new org.mpxj.primavera.PrimaveraXERFileWriter JavaObject => (org.mpxj.primavera.PrimaveraXERFileWriter)base.JavaObject;

        public PrimaveraXERFileWriter() : base(new org.mpxj.primavera.PrimaveraXERFileWriter()) { }

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }
    }
}
