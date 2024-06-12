namespace MPXJ.Net
{
    public class GanttProjectReader : AbstractProjectReader
    {
        internal GanttProjectReader(net.sf.mpxj.ganttproject.GanttProjectReader reader) : base(reader) { }

        public GanttProjectReader() : base(new net.sf.mpxj.ganttproject.GanttProjectReader()) { }

        public new net.sf.mpxj.ganttproject.GanttProjectReader JavaObject => (net.sf.mpxj.ganttproject.GanttProjectReader)base.JavaObject;
    }
}
