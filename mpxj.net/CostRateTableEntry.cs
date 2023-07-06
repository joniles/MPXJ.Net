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

        public java.time.LocalDateTime StartDate
        {
            get => JavaObject.getStartDate();
        }

        public java.time.LocalDateTime EndDate
        {
            get => JavaObject.getEndDate();
        }

        public net.sf.mpxj.Rate GetRate(int index)
        {
            return JavaObject.getRate(index);
        }

        public net.sf.mpxj.Rate StandardRate
        {
            get => JavaObject.getStandardRate();
        }

        public net.sf.mpxj.Rate OvertimeRate
        {
            get => JavaObject.getOvertimeRate();
        }

        public java.lang.Number CostPerUse
        {
            get => JavaObject.getCostPerUse();
        }
    }
}

