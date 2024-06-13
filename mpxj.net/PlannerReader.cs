namespace MPXJ.Net
{
    public class PlannerReader : AbstractProjectReader
    {
        internal PlannerReader(net.sf.mpxj.planner.PlannerReader reader) : base(reader) { }

        public PlannerReader() : base(new net.sf.mpxj.planner.PlannerReader()) { }

        public new net.sf.mpxj.planner.PlannerReader JavaObject => (net.sf.mpxj.planner.PlannerReader)base.JavaObject;
    }
}