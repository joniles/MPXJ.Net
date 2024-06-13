using System.Text;

namespace MPXJ.Net
{
    public class SDEFReader : AbstractProjectReader
    {
        internal SDEFReader(net.sf.mpxj.sdef.SDEFReader reader) : base(reader) { }

        public SDEFReader() : base(new net.sf.mpxj.sdef.SDEFReader()) { }

        public new net.sf.mpxj.sdef.SDEFReader JavaObject => (net.sf.mpxj.sdef.SDEFReader)base.JavaObject;

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
        }

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }
    }
}
