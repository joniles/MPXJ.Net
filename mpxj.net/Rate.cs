using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Rate : IJavaObjectProxy<org.mpxj.Rate>
    {
        public static readonly Rate Zero = new Rate(org.mpxj.Rate.ZERO);

        public org.mpxj.Rate JavaObject { get; }

        internal Rate(org.mpxj.Rate javaObject)
        {
            JavaObject = javaObject;
        }

        public Rate(double amount, TimeUnit time)
        {
            JavaObject = new org.mpxj.Rate(amount, time.ConvertType());
        }

        public double Amount => JavaObject.getAmount();

        public TimeUnit? Units => JavaObject.getUnits().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

