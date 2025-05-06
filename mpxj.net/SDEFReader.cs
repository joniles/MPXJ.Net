using System.Text;

namespace MPXJ.Net
{
    public class SDEFReader : AbstractProjectReader
    {
        internal SDEFReader(org.mpxj.sdef.SDEFReader reader) : base(reader) { }

        public SDEFReader() : base(new org.mpxj.sdef.SDEFReader()) { }

        public new org.mpxj.sdef.SDEFReader JavaObject => (org.mpxj.sdef.SDEFReader)base.JavaObject;

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
