namespace MPXJ.Net
{
    public class GanttDesignerReader : AbstractProjectReader
    {
        internal GanttDesignerReader(net.sf.mpxj.ganttdesigner.GanttDesignerReader reader) : base(reader) { }

        public GanttDesignerReader() : base(new net.sf.mpxj.ganttdesigner.GanttDesignerReader()) { }

        public new net.sf.mpxj.ganttdesigner.GanttDesignerReader JavaObject => (net.sf.mpxj.ganttdesigner.GanttDesignerReader)base.JavaObject;
    }
}
