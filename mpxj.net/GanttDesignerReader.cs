namespace MPXJ.Net
{
    public class GanttDesignerReader : AbstractProjectReader
    {
        public GanttDesignerReader()
        {
            base.JavaObject = new net.sf.mpxj.ganttdesigner.GanttDesignerReader();
        }

        public new net.sf.mpxj.ganttdesigner.GanttDesignerReader JavaObject => (net.sf.mpxj.ganttdesigner.GanttDesignerReader)base.JavaObject;
    }
}
