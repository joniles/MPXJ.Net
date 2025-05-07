namespace MPXJ.Net
{
    public class PlannerReader : AbstractProjectReader
    {
        internal PlannerReader(org.mpxj.planner.PlannerReader reader) : base(reader) { }

        public PlannerReader() : base(new org.mpxj.planner.PlannerReader()) { }

        public new org.mpxj.planner.PlannerReader JavaObject => (org.mpxj.planner.PlannerReader)base.JavaObject;
    }
}