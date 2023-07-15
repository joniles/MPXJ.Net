using org.mpxj.proxy;

namespace org.mpxj
{
    public class Duration : IJavaObjectProxy<net.sf.mpxj.Duration>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Duration JavaObject { get; }

        internal Duration(ProxyManager proxyManager, net.sf.mpxj.Duration javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public double DurationValue => JavaObject.getDuration();

        public TimeUnit? Units => JavaObject.getUnits().ConvertType();

        public Duration ConvertUnits(TimeUnit type, net.sf.mpxj.TimeUnitDefaultsContainer defaults) => _proxyManager.ProxyObject(JavaObject.convertUnits(type.ConvertType(), defaults));

        public bool DurationComponentEquals(Duration rhs) => JavaObject.durationComponentEquals(rhs.JavaObject);

        public override string ToString() => JavaObject.toString();

        public static Duration ConvertUnits(ProjectFile project, double duration, TimeUnit fromUnits, TimeUnit toUnits, ITimeUnitDefaultsContainer<net.sf.mpxj.TimeUnitDefaultsContainer> defaults)
        {
            return project._proxyManager.ProxyObject(net.sf.mpxj.Duration.convertUnits(duration, fromUnits.ConvertType(), toUnits.ConvertType(), defaults.JavaObject));
        }

        public static Duration ConvertUnits(ProjectFile project, double duration, TimeUnit fromUnits, TimeUnit toUnits, double minutesPerDay, double minutesPerWeek, double daysPerMonth)
        {
            return project._proxyManager.ProxyObject(net.sf.mpxj.Duration.convertUnits(duration, fromUnits.ConvertType(), toUnits.ConvertType(), minutesPerDay, minutesPerWeek, daysPerMonth));
        }

        public static Duration GetInstance(ProjectFile project, double duration, TimeUnit type)
        {
            return new Duration(project._proxyManager, net.sf.mpxj.Duration.getInstance(duration, type.ConvertType()));
        }

        public static Duration GetInstance(ProjectFile project, int duration, TimeUnit type)
        {
            return new Duration(project._proxyManager, net.sf.mpxj.Duration.getInstance(duration, type.ConvertType()));
        }

        public static bool DurationValueEquals(double lhs, double rhs)
        {
            return net.sf.mpxj.Duration.durationValueEquals(lhs, rhs);
        }

        public static Duration Add(Duration a, Duration b, ITimeUnitDefaultsContainer<net.sf.mpxj.TimeUnitDefaultsContainer> defaults)
        {
            return a._proxyManager.ProxyObject(net.sf.mpxj.Duration.add(a.JavaObject, b.JavaObject, defaults.JavaObject));
        }
    }
}
