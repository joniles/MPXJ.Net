namespace MPXJ.Net
{
    public class MSPDIWriter : AbstractProjectWriter
    {
        public new org.mpxj.mspdi.MSPDIWriter JavaObject => (org.mpxj.mspdi.MSPDIWriter)base.JavaObject;

        public MSPDIWriter() : base(new org.mpxj.mspdi.MSPDIWriter()) { }

        public bool MicrosoftProjectCompatibleOutput
        {
            get => JavaObject.getMicrosoftProjectCompatibleOutput();
            set => JavaObject.setMicrosoftProjectCompatibleOutput(value);
        }
        
        public bool WriteTimephasedData
        {
            get => JavaObject.getWriteTimephasedData();
            set => JavaObject.setWriteTimephasedData(value);
        }

        public bool GenerateMissingTimephasedData
        {
            get => JavaObject.getGenerateMissingTimephasedData();
            set => JavaObject.setGenerateMissingTimephasedData(value);
        }

        public SaveVersion? SaveVersion
        {
            get => JavaObject.getSaveVersion().ConvertType();
            set => JavaObject.setSaveVersion(value.ConvertType());
        }
    }
}
