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

        public Guid? ProjectId => JavaObject.getProjectId().ConvertType();

        public string ProjectName => JavaObject.getProjectName();

        public DateTime? CreatedOn => JavaObject.getCreatedOn().ConvertType();

        public DateTime? ModifiedOn => JavaObject.getModifiedOn().ConvertType();
        
        public string ProjectManagerName => JavaObject.getProjectManagerName();
        
        public Guid? PortfolioId => JavaObject.getPortfolioId().ConvertType();
        
        public string PortfolioName => JavaObject.getPortfolioName();

        public int? StateCode => JavaObject.getStateCode().ConvertType();
    }
}