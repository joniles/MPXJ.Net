using System.Text;

namespace MPXJ.Net
{
    public class MSPDIReader : AbstractProjectReader
    {
        public MSPDIReader()
        {
            base.JavaObject = new net.sf.mpxj.mspdi.MSPDIReader();
        }

        public new net.sf.mpxj.mspdi.MSPDIReader JavaObject => (net.sf.mpxj.mspdi.MSPDIReader)base.JavaObject;

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
