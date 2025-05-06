using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Priority : IJavaObjectProxy<org.mpxj.Priority>
    {
        public org.mpxj.Priority JavaObject { get; }

        internal Priority(org.mpxj.Priority javaObject)
        {
            JavaObject = javaObject;
        }
    
        public static Priority GetInstance(int priority) => new Priority(org.mpxj.Priority.getInstance(priority));

        public int Value => JavaObject.getValue();

        public override string ToString() => JavaObject.toString();

        public const int Lowest = org.mpxj.Priority.LOWEST;
        public const int VeryLow = org.mpxj.Priority.VERY_LOW;
        public const int Lower = org.mpxj.Priority.LOWER;
        public const int Low = org.mpxj.Priority.LOW;
        public const int Medium = org.mpxj.Priority.MEDIUM;
        public const int High = org.mpxj.Priority.HIGH;
        public const int Higher = org.mpxj.Priority.HIGHER;
        public const int VeryHigh = org.mpxj.Priority.VERY_HIGH;
        public const int Highest = org.mpxj.Priority.HIGHEST;
        public const int DoNotLevel = org.mpxj.Priority.DO_NOT_LEVEL;
    }
}
