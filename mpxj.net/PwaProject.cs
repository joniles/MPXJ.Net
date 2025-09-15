using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PwaProject : IJavaObjectProxy<org.mpxj.pwa.PwaProject>
    {
        public org.mpxj.pwa.PwaProject JavaObject { get; }
        
        internal PwaProject(org.mpxj.pwa.PwaProject javaObject)
        {
            JavaObject = javaObject;
        }

        public PwaProject() { }

        public Guid? ProjectId
        {
            get => JavaObject.getProjectId().ConvertType();
            set => JavaObject.setProjectId(value.ConvertType());
        }

        public string ProjectName
        {
            get => JavaObject.getProjectName();
            set => JavaObject.setProjectName(value);
        }
    }
}