using System.Text;

namespace MPXJ.Net
{
    public class MSPDIReader : AbstractProjectReader
    {
        internal MSPDIReader(org.mpxj.mspdi.MSPDIReader reader) : base(reader) { }

        public MSPDIReader() : base(new org.mpxj.mspdi.MSPDIReader()) { }

        public new org.mpxj.mspdi.MSPDIReader JavaObject => (org.mpxj.mspdi.MSPDIReader)base.JavaObject;

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
        }

        public bool MicrosoftProjectCompatibleInput
        {
            get => JavaObject.getMicrosoftProjectCompatibleInput();
            set => JavaObject.setMicrosoftProjectCompatibleInput(value);
        }
    }
}
