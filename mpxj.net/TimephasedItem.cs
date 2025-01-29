using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class TimephasedItem<M> : IJavaObjectProxy<net.sf.mpxj.TimephasedItem>
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
        
        public bool Modified
        {
            get => JavaObject.getModified();
            set => JavaObject.setModified(value);
        }
        
        public DateTime? Finish
        {
            get => JavaObject.getFinish().ConvertType();
            set => JavaObject.setFinish(value.ConvertType());
        }

        public abstract M AmountPerDay
        {
            get;
            set;
        }

        public abstract M TotalAmount
        {
            get;
            set;
        }

        public override string ToString() => JavaObject.toString();
    }
}

