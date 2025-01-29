using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class TimephasedWork : TimephasedItem<Duration>, IJavaObjectProxy<net.sf.mpxj.TimephasedWork>
    {
        public new net.sf.mpxj.TimephasedWork JavaObject => (net.sf.mpxj.TimephasedWork)base.JavaObject;

        internal TimephasedWork(net.sf.mpxj.TimephasedWork javaObject) : base(javaObject) { }

        public TimephasedWork() : base(new net.sf.mpxj.TimephasedWork()) { }
        
        public override Duration TotalAmount
        {
            get => new Duration((net.sf.mpxj.Duration)JavaObject.getTotalAmount());
            set => JavaObject.setTotalAmount(value.JavaObject);
        }
        
        public override Duration AmountPerDay
        {
            get => new Duration((net.sf.mpxj.Duration)JavaObject.getAmountPerDay());
            set => JavaObject.setAmountPerDay(value.JavaObject);
        }
    }
}
