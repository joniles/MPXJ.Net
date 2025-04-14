using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimephasedCost : TimephasedItem<double?>, IJavaObjectProxy<org.mpxj.TimephasedCost>
    {
        public new org.mpxj.TimephasedCost JavaObject => (org.mpxj.TimephasedCost)base.JavaObject;

        internal TimephasedCost(org.mpxj.TimephasedCost javaObject) : base(javaObject) { }

        public TimephasedCost() : base(new org.mpxj.TimephasedCost()) { }
        
        public override double? TotalAmount
        {
            get => ((java.lang.Number)JavaObject.getTotalAmount()).ConvertType();
            set => JavaObject.setTotalAmount(value.ConvertType());
        }
        
        public override double? AmountPerDay
        {
            get => ((java.lang.Number)JavaObject.getAmountPerDay()).ConvertType();
            set => JavaObject.setAmountPerDay(value.ConvertType());
        }
    }
}
