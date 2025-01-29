using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TimephasedCost : TimephasedItem<double?>, IJavaObjectProxy<net.sf.mpxj.TimephasedCost>
    {
        public new net.sf.mpxj.TimephasedCost JavaObject => (net.sf.mpxj.TimephasedCost)base.JavaObject;

        internal TimephasedCost(net.sf.mpxj.TimephasedCost javaObject) : base(javaObject) { }

        public TimephasedCost() : base(new net.sf.mpxj.TimephasedCost()) { }
        
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
