namespace MPXJ.Net
{
    public class PrimaveraBaselineStrategy : IBaselineStrategy
    {
        public static readonly PrimaveraBaselineStrategy Instance = new PrimaveraBaselineStrategy();

        private PrimaveraBaselineStrategy() { }

        public net.sf.mpxj.BaselineStrategy JavaObject => net.sf.mpxj.primavera.PrimaveraBaselineStrategy.INSTANCE;

        public void ClearBaseline(ProjectFile project, int index)
        {
            JavaObject.clearBaseline(project.JavaObject, index);
        }

        public void PopulateBaseline(ProjectFile project, ProjectFile baseline, int index)
        {
            JavaObject.populateBaseline(project.JavaObject, baseline.JavaObject, index);
        }
    }
}
