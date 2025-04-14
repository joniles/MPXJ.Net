namespace MPXJ.Net
{
    public class GanttProjectReader : AbstractProjectReader
    {
        internal GanttProjectReader(org.mpxj.ganttproject.GanttProjectReader reader) : base(reader) { }

        public GanttProjectReader() : base(new org.mpxj.ganttproject.GanttProjectReader()) { }

        public new org.mpxj.ganttproject.GanttProjectReader JavaObject => (org.mpxj.ganttproject.GanttProjectReader)base.JavaObject;
    }
}
