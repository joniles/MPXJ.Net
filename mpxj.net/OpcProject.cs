using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class OpcProject : IJavaObjectProxy<org.mpxj.opc.OpcProject>
    {
        public org.mpxj.opc.OpcProject JavaObject { get; }
        
        internal OpcProject(org.mpxj.opc.OpcProject javaObject)
        {
            JavaObject = javaObject;
        }

        public OpcProject()
        {
            JavaObject = new org.mpxj.opc.OpcProject();
        }
        
        public long ProjectId
        {
            get => JavaObject.getProjectId();
            set => JavaObject.setProjectId(value);
        }

        public long WorkspaceId
        {
            get => JavaObject.getWorkspaceId();
            set => JavaObject.setWorkspaceId(value);
        }

        public string ProjectName
        {
            get => JavaObject.getProjectName();
            set => JavaObject.setProjectName(value);
        }
    }
}