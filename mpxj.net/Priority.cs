using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Priority : IJavaObjectProxy<net.sf.mpxj.Priority>
    {
        public net.sf.mpxj.Priority JavaObject { get; }

        internal Priority(net.sf.mpxj.Priority javaObject)
        {
            JavaObject = javaObject;
        }
    
        public static Priority GetInstance(int priority) => new Priority(net.sf.mpxj.Priority.getInstance(priority));

        public int Value => JavaObject.getValue();

        public override string ToString() => JavaObject.toString();

        public static readonly int Lowest = net.sf.mpxj.Priority.LOWEST;
        public static readonly int VeryLow = net.sf.mpxj.Priority.VERY_LOW;
        public static readonly int Lower = net.sf.mpxj.Priority.LOWER;
        public static readonly int Low = net.sf.mpxj.Priority.LOW;
        public static readonly int Medium = net.sf.mpxj.Priority.MEDIUM;
        public static readonly int High = net.sf.mpxj.Priority.HIGH;
        public static readonly int Higher = net.sf.mpxj.Priority.HIGHER;
        public static readonly int VeryHigh = net.sf.mpxj.Priority.VERY_HIGH;
        public static readonly int Highest = net.sf.mpxj.Priority.HIGHEST;
        public static readonly int DoNotLevel = net.sf.mpxj.Priority.DO_NOT_LEVEL;
    }
}
