using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Shift : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.Shift>
    {
        internal readonly ProxyManager _proxyManager;

        public net.sf.mpxj.Shift JavaObject { get; }

        internal Shift(ProxyManager proxyManager, net.sf.mpxj.Shift javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public ICollection<ShiftPeriod> Periods => _proxyManager.ProxyCollection<net.sf.mpxj.ShiftPeriod, ShiftPeriod>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getPeriods());

        public class Builder : IJavaObjectProxy<net.sf.mpxj.Shift.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.Shift.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.Shift.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Shift Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
