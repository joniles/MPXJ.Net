namespace MPXJ.Net
{
    public class OpenPlanReader : AbstractProjectReader
    {
        internal OpenPlanReader(net.sf.mpxj.openplan.OpenPlanReader reader) : base(reader) { }

        public OpenPlanReader() : base(new net.sf.mpxj.openplan.OpenPlanReader()) { }

        public new net.sf.mpxj.openplan.OpenPlanReader JavaObject => (net.sf.mpxj.openplan.OpenPlanReader)base.JavaObject;
    }
}
