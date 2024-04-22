using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Rate : IJavaObjectProxy<net.sf.mpxj.Rate>
    {
        public static readonly Rate Zero = new Rate(net.sf.mpxj.Rate.ZERO);

        public net.sf.mpxj.Rate JavaObject { get; }

        internal Rate(net.sf.mpxj.Rate javaObject)
        {
            JavaObject = javaObject;
        }

        public Rate(double amount, TimeUnit time)
        {
            JavaObject = new net.sf.mpxj.Rate(amount, time.ConvertType());
        }

        public double Amount => JavaObject.getAmount();

        public TimeUnit? Units => JavaObject.getUnits().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

