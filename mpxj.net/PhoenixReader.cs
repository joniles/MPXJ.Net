namespace MPXJ.Net
{
    public class PhoenixReader : AbstractProjectReader
    {
        internal PhoenixReader(org.mpxj.phoenix.PhoenixReader reader) : base(reader) { }

        public PhoenixReader() : base(new org.mpxj.phoenix.PhoenixReader()) { }

        public new org.mpxj.phoenix.PhoenixReader JavaObject => (org.mpxj.phoenix.PhoenixReader)base.JavaObject;

        public bool UseActivityCodesForTaskHierarchy
        {
            get => JavaObject.getUseActivityCodesForTaskHierarchy();
            set => JavaObject.setUseActivityCodesForTaskHierarchy(value);
        }
    }
}
