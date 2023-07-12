using org.mpxj.proxy;

namespace org.mpxj
{
    public class TimephasedItem<M> : IJavaObjectProxy<net.sf.mpxj.TimephasedItem>
    {
        public net.sf.mpxj.TimephasedItem JavaObject { get; }

        internal TimephasedItem(net.sf.mpxj.TimephasedItem javaObject)
        {
            JavaObject = javaObject;
        }

        public java.time.LocalDateTime Start
        {
            get => JavaObject.getStart();
            set => JavaObject.setStart(value);
        }

        public M AmountPerDay
        {
            get => (M)JavaObject.getAmountPerDay();
            set => JavaObject.setAmountPerDay(value);
        }

        public bool Modified
        {
            get => JavaObject.getModified();
            set => JavaObject.setModified(value);
        }

        public M TotalAmount
        {
            get => (M)JavaObject.getTotalAmount();
            set => JavaObject.setTotalAmount(value);
        }

        public java.time.LocalDateTime Finish
        {
            get => JavaObject.getFinish();
            set => JavaObject.setFinish(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

