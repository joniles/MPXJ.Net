using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectConfig : IJavaObjectProxy<net.sf.mpxj.ProjectConfig>
    {
        public net.sf.mpxj.ProjectConfig JavaObject { get; }

        internal ProjectConfig(net.sf.mpxj.ProjectConfig javaObject)
        {
            JavaObject = javaObject;
        }

        public bool AutoWBS
        {
            get => JavaObject.getAutoWBS();
            set => JavaObject.setAutoWBS(value);
        }

        public bool AutoOutlineLevel
        {
            get => JavaObject.getAutoOutlineLevel();
            set => JavaObject.setAutoOutlineLevel(value);
        }

        public bool AutoOutlineNumber
        {
            get => JavaObject.getAutoOutlineNumber();
            set => JavaObject.setAutoOutlineNumber(value);
        }

        public bool AutoTaskUniqueID
        {
            get => JavaObject.getAutoTaskID();
            set => JavaObject.setAutoTaskID(value);
        }

        public bool AutoCalendarUniqueID
        {
            get => JavaObject.getAutoCalendarUniqueID();
            set => JavaObject.setAutoCalendarUniqueID(value);
        }

        public bool AutoAssignmentUniqueID
        {
            get => JavaObject.getAutoAssignmentUniqueID();
            set => JavaObject.setAutoAssignmentUniqueID(value);
        }

        public bool AutoTaskID
        {
            get => JavaObject.getAutoTaskID();
            set => JavaObject.setAutoTaskID(value);
        }

        public bool AutoResourceUniqueID
        {
            get => JavaObject.getAutoResourceUniqueID();
            set => JavaObject.setAutoResourceUniqueID(value);
        }

        public bool AutoResourceID
        {
            get => JavaObject.getAutoResourceID();
            set => JavaObject.setAutoResourceID(value);
        }

        public bool AutoRelationUniqueID
        {
            get => JavaObject.getAutoRelationUniqueID();
            set => JavaObject.setAutoRelationUniqueID(value);
        }

        public bool CompleteThroughIsNextWorkStart
        {
            get => JavaObject.getCompleteThroughIsNextWorkStart();
            set => JavaObject.setCompleteThroughIsNextWorkStart(value);
        }

        // TODO implement baseline strategy hierarchy
        /*
        public IBaselineStrategy BaselineStrategy
        {            
            get => JavaObject.getBaselineStrategy();
            set => JavaObject.setBaselineStrategy(value.JavaObject);
        }
        */

        public string SubprojectWorkingDirectory
        {
            get => JavaObject.getSubprojectWorkingDirectory()?.getPath();
            set => JavaObject.setSubprojectWorkingDirectory(value == null ? null : new java.io.File(value));
        }
    }
}