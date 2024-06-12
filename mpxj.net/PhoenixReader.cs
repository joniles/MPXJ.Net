namespace MPXJ.Net
{
    public class PhoenixReader : AbstractProjectReader
    {
        internal PhoenixReader(net.sf.mpxj.phoenix.PhoenixReader reader) : base(reader) { }

        public PhoenixReader() : base(new net.sf.mpxj.phoenix.PhoenixReader()) { }

        public new net.sf.mpxj.phoenix.PhoenixReader JavaObject => (net.sf.mpxj.phoenix.PhoenixReader)base.JavaObject;

        public bool UseActivityCodesForTaskHierarchy
        {
            get => JavaObject.getUseActivityCodesForTaskHierarchy();
            set => JavaObject.setUseActivityCodesForTaskHierarchy(value);
        }
    }
}
