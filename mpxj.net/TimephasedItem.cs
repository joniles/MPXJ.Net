using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public abstract class TimephasedItem<M> : IJavaObjectProxy<org.mpxj.TimephasedItem>
    {
        public org.mpxj.TimephasedItem JavaObject { get; }

        internal TimephasedItem(org.mpxj.TimephasedItem javaObject)
        {
            JavaObject = javaObject;
        }

        public DateTime? Start
        {
            get => JavaObject.getStart().ConvertType();
            set => JavaObject.setStart(value.ConvertType());
        }
        
        public DateTime? Finish
        {
            get => JavaObject.getFinish().ConvertType();
            set => JavaObject.setFinish(value.ConvertType());
        }

        public abstract M AmountPerHour
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

