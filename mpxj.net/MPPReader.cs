namespace MPXJ.Net
{
    public class MPPReader : AbstractProjectReader
    {
        public MPPReader() : base(new net.sf.mpxj.mpp.MPPReader()) { }

        public new net.sf.mpxj.mpp.MPPReader JavaObject => (net.sf.mpxj.mpp.MPPReader)base.JavaObject;

        public string ReadPassword
        {
            get => JavaObject.getReadPassword();
            set => JavaObject.setReadPassword(value);
        }

        public bool ReadPresentationData
        {
            get => JavaObject.getReadPresentationData();
            set => JavaObject.setReadPresentationData(value);
        }

        public bool ReadPropertiesOnly
        {
            get => JavaObject.getReadPropertiesOnly();
            set => JavaObject.setReadPropertiesOnly(value);
        }

        public bool RespectPasswordProtection
        {
            // TODO: 12.10.3 or later
            //get => JavaObject.getREspectPasswordProtection();
            set => JavaObject.setRespectPasswordProtection(value);
        }

        public bool UseRawTimephasedData
        {
            get => JavaObject.getUseRawTimephasedData();
            set => JavaObject.setUseRawTimephasedData(value);
        }
    }
}
