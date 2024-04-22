using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCode : IJavaObjectProxy<net.sf.mpxj.ActivityCode>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ActivityCode JavaObject { get; }

        internal ActivityCode(ProxyManager proxyManager, net.sf.mpxj.ActivityCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public ActivityCodeScope? Scope => JavaObject.getScope().ConvertType();

        public int? ScopeProjectUniqueID => JavaObject.getScopeProjectUniqueID().ConvertType();

        public int? ScopeEpsUniqueID => JavaObject.getScopeEpsUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public int? MaxLength => JavaObject.getMaxLength().ConvertType();

        public IList<ActivityCodeValue> Values => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());
    }
}

