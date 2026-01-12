using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MsPlannerProject : IJavaObjectProxy<org.mpxj.msplanner.MsPlannerProject>
    {
        public org.mpxj.msplanner.MsPlannerProject JavaObject { get; }
        
        internal MsPlannerProject(org.mpxj.msplanner.MsPlannerProject javaObject)
        {
            JavaObject = javaObject;
        }

        public MsPlannerProject() { }

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