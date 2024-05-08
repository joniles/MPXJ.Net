namespace MPXJ.Net
{
    public class PlannerReader : AbstractProjectReader
    {
        public PlannerReader()
        {
            base.JavaObject = new net.sf.mpxj.planner.PlannerReader();
        }

        public new net.sf.mpxj.planner.PlannerReader JavaObject => (net.sf.mpxj.planner.PlannerReader)base.JavaObject;
    }
}