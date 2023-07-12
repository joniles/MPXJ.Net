using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostRateTableEntry : IJavaObjectProxy<net.sf.mpxj.CostRateTableEntry>
    {
        public net.sf.mpxj.CostRateTableEntry JavaObject { get; }

        internal CostRateTableEntry(net.sf.mpxj.CostRateTableEntry javaObject)
        {
            JavaObject = javaObject;
        }

        public java.time.LocalDateTime StartDate => JavaObject.getStartDate();

        public java.time.LocalDateTime EndDate => JavaObject.getEndDate();

        public net.sf.mpxj.Rate GetRate(int index)
        {
            return JavaObject.getRate(index);
        }

        public net.sf.mpxj.Rate StandardRate => JavaObject.getStandardRate();

        public net.sf.mpxj.Rate OvertimeRate => JavaObject.getOvertimeRate();

        public java.lang.Number CostPerUse => JavaObject.getCostPerUse();
    }
}

