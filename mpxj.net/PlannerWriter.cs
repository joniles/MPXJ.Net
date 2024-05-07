namespace MPXJ.Net
{
    public class PlannerWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.planner.PlannerWriter JavaObject => (net.sf.mpxj.planner.PlannerWriter)base.JavaObject;

        public PlannerWriter() : base(new net.sf.mpxj.planner.PlannerWriter()) { }

        public string Encoding
        {
            get => JavaObject.getEncoding();
            set => JavaObject.setEncoding(value);
        }
    }
}
