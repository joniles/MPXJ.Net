namespace MPXJ.Net
{
    public class GanttDesignerReader : AbstractProjectReader
    {
        internal GanttDesignerReader(org.mpxj.ganttdesigner.GanttDesignerReader reader) : base(reader) { }

        public GanttDesignerReader() : base(new org.mpxj.ganttdesigner.GanttDesignerReader()) { }

        public new org.mpxj.ganttdesigner.GanttDesignerReader JavaObject => (org.mpxj.ganttdesigner.GanttDesignerReader)base.JavaObject;
    }
}
