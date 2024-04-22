using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CostRateTableEntry : IJavaObjectProxy<net.sf.mpxj.CostRateTableEntry>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CostRateTableEntry JavaObject { get; }

        internal CostRateTableEntry(ProxyManager proxyManager, net.sf.mpxj.CostRateTableEntry javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public DateTime? StartDate => JavaObject.getStartDate().ConvertType();

        public DateTime? EndDate => JavaObject.getEndDate().ConvertType();

        public Rate GetRate(int index) => _proxyManager.ProxyObject(JavaObject.getRate(index));

        public Rate StandardRate => _proxyManager.ProxyObject(JavaObject.getStandardRate());

        public Rate OvertimeRate => _proxyManager.ProxyObject(JavaObject.getOvertimeRate());

        public double? CostPerUse => JavaObject.getCostPerUse().ConvertType();
    }
}

