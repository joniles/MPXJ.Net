using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class TimephasedWork : TimephasedItem<Duration>, IJavaObjectProxy<org.mpxj.TimephasedWork>
    {
        public new org.mpxj.TimephasedWork JavaObject => (org.mpxj.TimephasedWork)base.JavaObject;

        internal TimephasedWork(org.mpxj.TimephasedWork javaObject) : base(javaObject) { }

        public TimephasedWork() : base(new org.mpxj.TimephasedWork()) { }
        
        public override Duration TotalAmount
        {
            get => new Duration((org.mpxj.Duration)JavaObject.getTotalAmount());
            set => JavaObject.setTotalAmount(value.JavaObject);
        }
        
        public override Duration AmountPerDay
        {
            get => new Duration((org.mpxj.Duration)JavaObject.getAmountPerDay());
            set => JavaObject.setAmountPerDay(value.JavaObject);
        }
    }
}
