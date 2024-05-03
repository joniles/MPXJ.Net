namespace MPXJ.Net
{
    public class MSPDIWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.mspdi.MSPDIWriter JavaObject => (net.sf.mpxj.mspdi.MSPDIWriter)base.JavaObject;  
        
        public bool MicrosoftProjectCompatibleOutput
        {
            get => JavaObject.getMicrosoftProjectCompatibleOutput();
            set => JavaObject.setMicrosoftProjectCompatibleOutput(value);
        }

        public bool SplitTimephasedAsDays
        {
            get => JavaObject.getSplitTimephasedAsDays();
            set => JavaObject.setSplitTimephasedAsDays(value);
        }

        public bool WriteTimephasedData
        {
            get => JavaObject.getWriteTimephasedData();
            set => JavaObject.setWriteTimephasedData(value);
        }

        public SaveVersion? SaveVersion
        {
            get => JavaObject.getSaveVersion().ConvertType();
            set => JavaObject.setSaveVersion(value.ConvertType());
        }
    }
}
