using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MsPlannerPortfolio : IJavaObjectProxy<org.mpxj.msplanner.MsPlannerPortfolio>
    {
        public org.mpxj.msplanner.MsPlannerPortfolio JavaObject { get; }
        
        internal MsPlannerPortfolio(org.mpxj.msplanner.MsPlannerPortfolio javaObject)
        {
            JavaObject = javaObject;
        }

        public MsPlannerPortfolio() { }

        public Guid? PortfolioId => JavaObject.getPortfolioId().ConvertType();

        public string PortfolioName => JavaObject.getPortfolioName();

        public DateTime? CreatedOn => JavaObject.getCreatedOn().ConvertType();

        public DateTime? ModifiedOn => JavaObject.getModifiedOn().ConvertType();
    }
}