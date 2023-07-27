using org.mpxj.proxy;

namespace org.mpxj
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

        public java.time.LocalDateTime StartDate => JavaObject.getStartDate();

        public java.time.LocalDateTime EndDate => JavaObject.getEndDate();

        public Rate GetRate(int index) => _proxyManager.ProxyObject(JavaObject.getRate(index));

        public Rate StandardRate => _proxyManager.ProxyObject(JavaObject.getStandardRate());

        public mpxj.Rate OvertimeRate => _proxyManager.ProxyObject(JavaObject.getOvertimeRate());

        public double? CostPerUse => JavaObject.getCostPerUse().ConvertType();
    }
}

