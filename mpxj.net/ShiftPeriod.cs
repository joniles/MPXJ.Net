using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ShiftPeriod : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ShiftPeriod>
    {
        private readonly ProxyManager _proxyManager;

        public net.sf.mpxj.ShiftPeriod JavaObject { get; }

        internal ShiftPeriod(ProxyManager proxyManager, net.sf.mpxj.ShiftPeriod javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public Shift ParentShift => _proxyManager.ProxyObject(JavaObject.getParentShift());

        public TimeOnly? Start => JavaObject.getStart().ConvertType();

        public Duration Duration => _proxyManager.ProxyObject(JavaObject.getDuration());

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ShiftPeriod.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ShiftPeriod.Builder JavaObject { get; }

            public Builder(ProjectFile file, Shift shift)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ShiftPeriod.Builder(file.JavaObject, shift.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Start(TimeOnly value)
            {
                JavaObject.start(value.ConvertType());
                return this;
            }

            public ShiftPeriod Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
