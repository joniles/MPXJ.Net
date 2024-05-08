﻿namespace MPXJ.Net
{
    public class GanttProjectReader : AbstractProjectReader
    {
        public GanttProjectReader()
        {
            base.JavaObject = new net.sf.mpxj.ganttproject.GanttProjectReader();
        }

        public new net.sf.mpxj.ganttproject.GanttProjectReader JavaObject => (net.sf.mpxj.ganttproject.GanttProjectReader)base.JavaObject;
    }
}
