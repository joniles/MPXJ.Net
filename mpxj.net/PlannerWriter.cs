using System.Text;

namespace MPXJ.Net
{
    public class PlannerWriter : AbstractProjectWriter
    {
        public new org.mpxj.planner.PlannerWriter JavaObject => (org.mpxj.planner.PlannerWriter)base.JavaObject;

        public PlannerWriter() : base(new org.mpxj.planner.PlannerWriter()) { }

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }
    }
}
