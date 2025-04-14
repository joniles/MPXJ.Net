using System;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CostRateTableEntry : IJavaObjectProxy<org.mpxj.CostRateTableEntry>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.CostRateTableEntry JavaObject { get; }

        internal CostRateTableEntry(ProxyManager proxyManager, org.mpxj.CostRateTableEntry javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public CostRateTableEntry(ProjectFile file, DateTime startDate, DateTime endDate, double? costPerUse, Rate[] rates)
        {
            _proxyManager = file._proxyManager;
            JavaObject = new org.mpxj.CostRateTableEntry(startDate.ConvertType(), endDate.ConvertType(), costPerUse.ConvertType(), rates.Select(r => r.JavaObject).ToArray());
        }

        public DateTime? StartDate => JavaObject.getStartDate().ConvertType();

        public DateTime? EndDate => JavaObject.getEndDate().ConvertType();

        public Rate GetRate(int index) => _proxyManager.ProxyObject(JavaObject.getRate(index));

        public Rate StandardRate => _proxyManager.ProxyObject(JavaObject.getStandardRate());

        public Rate OvertimeRate => _proxyManager.ProxyObject(JavaObject.getOvertimeRate());

        public double? CostPerUse => JavaObject.getCostPerUse().ConvertType();
    }
}

