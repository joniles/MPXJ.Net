using System.Text;

namespace MPXJ.Net
{
    public class PlannerWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.planner.PlannerWriter JavaObject => (net.sf.mpxj.planner.PlannerWriter)base.JavaObject;

        public PlannerWriter() : base(new net.sf.mpxj.planner.PlannerWriter()) { }

        public Encoding Encoding
        {
            get => Encoding.GetEncoding(JavaObject.getCharset().name());
            set => JavaObject.setCharset(java.nio.charset.Charset.forName(value.EncodingName));
        }
    }
}
