namespace MPXJ.Net
{
    public class GanttDesignerReader : AbstractProjectReader
    {
        public GanttDesignerReader() : base(new net.sf.mpxj.ganttdesigner.GanttDesignerReader()) { }

        public new net.sf.mpxj.ganttdesigner.GanttDesignerReader JavaObject => (net.sf.mpxj.ganttdesigner.GanttDesignerReader)base.JavaObject;
    }
}
