﻿using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Duration : IJavaObjectProxy<net.sf.mpxj.Duration>
    {
        public net.sf.mpxj.Duration JavaObject { get; }

        internal Duration(net.sf.mpxj.Duration javaObject)
        {
            JavaObject = javaObject;
        }

        public double DurationValue => JavaObject.getDuration();

        public TimeUnit? Units => JavaObject.getUnits().ConvertType();

        public Duration ConvertUnits<T>(TimeUnit type, ITimeUnitDefaultsContainer<T> defaults) where T : net.sf.mpxj.TimeUnitDefaultsContainer => GetProxyManager(defaults).ProxyObject(JavaObject.convertUnits(type.ConvertType(), defaults.JavaObject));

        public bool DurationComponentEquals(Duration rhs) => JavaObject.durationComponentEquals(rhs.JavaObject);

        public override string ToString() => JavaObject.toString();

        public static Duration ConvertUnits<T>(double duration, TimeUnit fromUnits, TimeUnit toUnits, ITimeUnitDefaultsContainer<T> defaults) where T : net.sf.mpxj.TimeUnitDefaultsContainer
        {
            return GetProxyManager(defaults).ProxyObject(net.sf.mpxj.Duration.convertUnits(duration, fromUnits.ConvertType(), toUnits.ConvertType(), defaults.JavaObject));
        }

        public static Duration ConvertUnits(ProjectFile project, double duration, TimeUnit fromUnits, TimeUnit toUnits, double minutesPerDay, double minutesPerWeek, double daysPerMonth)
        {
            return project._proxyManager.ProxyObject(net.sf.mpxj.Duration.convertUnits(duration, fromUnits.ConvertType(), toUnits.ConvertType(), minutesPerDay, minutesPerWeek, daysPerMonth));
        }

        public static Duration GetInstance(double duration, TimeUnit type)
        {
            return new Duration(net.sf.mpxj.Duration.getInstance(duration, type.ConvertType()));
        }

        public static Duration GetInstance(int duration, TimeUnit type)
        {
            return new Duration(net.sf.mpxj.Duration.getInstance(duration, type.ConvertType()));
        }

        public static bool DurationValueEquals(double lhs, double rhs)
        {
            return net.sf.mpxj.Duration.durationValueEquals(lhs, rhs);
        }

        public static Duration Add<T>(Duration a, Duration b, ITimeUnitDefaultsContainer<T> defaults) where T : net.sf.mpxj.TimeUnitDefaultsContainer
        {
            return GetProxyManager(defaults).ProxyObject(net.sf.mpxj.Duration.add(a.JavaObject, b.JavaObject, defaults.JavaObject));
        }

        public override bool Equals(object obj) => Equals(obj as Duration);

        public bool Equals(Duration d) => d != null && JavaObject.Equals(d.JavaObject);

        public override int GetHashCode() => JavaObject.hashCode();

        public static bool operator ==(Duration lhs, Duration rhs) => lhs?.Equals(rhs) ?? rhs is null;

        public static bool operator !=(Duration lhs, Duration rhs) => !(lhs == rhs);

        private static ProxyManager GetProxyManager<T>(ITimeUnitDefaultsContainer<T> defaults) where T : net.sf.mpxj.TimeUnitDefaultsContainer
        {
            switch (defaults)
            {
                case ProjectProperties props:
                    return props._proxyManager;
                case ProjectCalendar cal:
                    return cal._proxyManager;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
