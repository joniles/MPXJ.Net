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

        public const int Lowest = net.sf.mpxj.Priority.LOWEST;
        public const int VeryLow = net.sf.mpxj.Priority.VERY_LOW;
        public const int Lower = net.sf.mpxj.Priority.LOWER;
        public const int Low = net.sf.mpxj.Priority.LOW;
        public const int Medium = net.sf.mpxj.Priority.MEDIUM;
        public const int High = net.sf.mpxj.Priority.HIGH;
        public const int Higher = net.sf.mpxj.Priority.HIGHER;
        public const int VeryHigh = net.sf.mpxj.Priority.VERY_HIGH;
        public const int Highest = net.sf.mpxj.Priority.HIGHEST;
        public const int DoNotLevel = net.sf.mpxj.Priority.DO_NOT_LEVEL;
    }
}
