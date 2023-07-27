using System;
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

        public DateTime? Start
        {
            get => JavaObject.getStart().ConvertType();
            set => JavaObject.setStart(value.ConvertType());
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

        public DateTime? Finish
        {
            get => JavaObject.getFinish().ConvertType();
            set => JavaObject.setFinish(value.ConvertType());
        }

        public override string ToString() => JavaObject.toString();
    }
}

