namespace MPXJ.Net
{
    public class OpenPlanReader : AbstractProjectReader
    {
        internal OpenPlanReader(org.mpxj.openplan.OpenPlanReader reader) : base(reader) { }

        public OpenPlanReader() : base(new org.mpxj.openplan.OpenPlanReader()) { }

        public new org.mpxj.openplan.OpenPlanReader JavaObject => (org.mpxj.openplan.OpenPlanReader)base.JavaObject;
    }
}
