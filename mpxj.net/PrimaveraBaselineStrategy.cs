namespace MPXJ.Net
{
    public class PrimaveraBaselineStrategy : IBaselineStrategy
    {
        internal PrimaveraBaselineStrategy(org.mpxj.primavera.PrimaveraBaselineStrategy javaObject) 
        {
            JavaObject = javaObject;
        }

        public static readonly PrimaveraBaselineStrategy PlannedAttributes = new PrimaveraBaselineStrategy(org.mpxj.primavera.PrimaveraBaselineStrategy.PLANNED_ATTRIBUTES);

        public static readonly PrimaveraBaselineStrategy CurrentAttributes = new PrimaveraBaselineStrategy(org.mpxj.primavera.PrimaveraBaselineStrategy.CURRENT_ATTRIBUTES);

        public org.mpxj.BaselineStrategy JavaObject { get; }

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
