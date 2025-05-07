namespace MPXJ.Net
{
    public class MPPReader : AbstractProjectReader
    {
        internal MPPReader(org.mpxj.mpp.MPPReader reader) : base(reader) { }

        public MPPReader() : base(new org.mpxj.mpp.MPPReader()) { }

        public new org.mpxj.mpp.MPPReader JavaObject => (org.mpxj.mpp.MPPReader)base.JavaObject;

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
            get => JavaObject.getRespectPasswordProtection();
            set => JavaObject.setRespectPasswordProtection(value);
        }

        public bool UseRawTimephasedData
        {
            get => JavaObject.getUseRawTimephasedData();
            set => JavaObject.setUseRawTimephasedData(value);
        }
    }
}
